﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LaserGRBL.GrblEmulator
{

	public class Grblv11Emulator
	{
		private static string filename = System.IO.Path.Combine(GrblCore.DataPath, "GrblEmulator.v11.bin");

		public static event  SendMessage EmulatorMessage;

		private bool mPaused = false; //da spostare nel spb
		private bool mCheck = false;
		private GrblCommand.StatePositionBuilder SPB;
		decimal px, py, pz, wx, wy, wz;
		
		TimeSpan toSleep = TimeSpan.Zero;
		private Tools.ThreadObject RX;
		private Tools.ThreadObject TX;
		private Queue<string> rxBuf = new Queue<string>();
		private Queue<string> txBuf = new Queue<string>();

		public delegate void SendMessage(string message);
		private SendMessage mSendFunc;

		private bool opened;
		private GrblConf conf;

		public Grblv11Emulator(SendMessage sendFunc)
		{
			SPB = new GrblCommand.StatePositionBuilder();
			RX = new Tools.ThreadObject(ManageRX, 0, true, "Emulator RX", null);
			TX = new Tools.ThreadObject(ManageTX, 0, true, "Emulator TX", null);
			mSendFunc = sendFunc;

			conf = (GrblConf)Tools.Serializer.ObjFromFile(filename);
			if (conf == null) conf = new GrblConf(new GrblCore.GrblVersionInfo(1, 1, '#'), new Dictionary<int, decimal> { { 0, 10 }, { 1, 25 }, { 2, 0 }, { 3, 0 }, { 4, 0 }, { 5, 0 }, { 6, 0 }, { 10, 1 }, { 11, 0.010m }, { 12, 0.002m }, { 13, 0 }, { 20, 0 }, { 21, 0 }, { 22, 0 }, { 23, 0 }, { 24, 25.000m }, { 25, 500.000m }, { 26, 250 }, { 27, 1.000m }, { 30, 1000.0m }, { 31, 0.0m }, { 32, 0 }, { 100, 250.000m }, { 101, 250.000m }, { 102, 250.000m }, { 110, 500.000m }, { 111, 500.000m }, { 112, 500.000m }, { 120, 10.000m }, { 121, 10.000m }, { 122, 10.000m }, { 130, 200.000m }, { 131, 200.000m }, { 132, 200.000m } });
		}

		public void CloseCom()
		{
			if (opened)
			{
				opened = false;

				RX.Stop();
				TX.Stop();

				lock (rxBuf)
				{
					rxBuf.Clear();
					txBuf.Clear();
				}

				EmuLog("Connection lost!");
				Tools.Serializer.ObjToFile(conf, filename);
			}
		}

		private void EmuLog(string p)
		{
			try
			{
				if (EmulatorMessage != null)
					EmulatorMessage(p);
			}
			catch { }
		}

		public void OpenCom()
		{
			if (!opened)
			{
				opened = true;
				EmuLog("Client connected!");

				lock (rxBuf)
				{
					rxBuf.Clear();
					txBuf.Clear();
				}
				
				mPaused = false;
				mCheck = false;
				RX.Start();
				TX.Start();

				SendVersion();
			}
		}

		public void ManageMessage(byte[] data)
		{
			if (data.Length == 1)
			{
				/*if (data[0] == 24)
					GrblReset();
				else if (data[0] == 63)
					SendStatus();
				else if (data[0] == 33)
					Pause(true);
				else if (data[0] == 126)
					Pause(false);*/
			}
			else
			{
				string message = Encoding.UTF8.GetString(data);

                if (message == "version\n")
                    ;
                else if (message == "{fb:n}\n")
                    ;
                else if (message == "M114\n")
                    SendStatus();
                else
                    EnqueueRX(message);
			}
		}

		private void Pause(bool value)
		{
			mPaused = value;
			SendStatus();
		}

		static System.Text.RegularExpressions.Regex confRegEX = new System.Text.RegularExpressions.Regex(@"^[$](\d+) *= *(\d+\.?\d*)");
		private bool IsSetConf(string p)
		{ return confRegEX.IsMatch(p); }

		private void SetConfig(string p)
		{
			try
			{
                EnqueueTX("echo:busy:proccessing");
                System.Threading.Thread.Sleep(10);
				System.Text.RegularExpressions.MatchCollection matches = confRegEX.Matches(p);
				int key = int.Parse(matches[0].Groups[1].Value);

				if (conf.ContainsKey(key))
				{
					conf.SetValue(key, decimal.Parse(matches[0].Groups[2].Value, System.Globalization.CultureInfo.InvariantCulture));
					EnqueueTX("ok");
				}
				else
					EnqueueTX("error");
			}
			catch (Exception ex)
			{
				EnqueueTX("error");
			}
		}

		private void SendConfig()
		{
			EnqueueTX("ok"); //REPLY TO $$

			foreach (KeyValuePair<int, decimal> kvp in conf)
				ImmediateTX(string.Format(System.Globalization.CultureInfo.InvariantCulture, "${0}={1}", kvp.Key, kvp.Value));
		}

		private void EnqueueRX(string message)
		{
			lock (rxBuf)
			{ rxBuf.Enqueue(message); }
		}

		private void GrblReset()
		{
			lock (rxBuf)
			{
				rxBuf.Clear();
                EnqueueTX("echo:busy:proccessing");
                System.Threading.Thread.Sleep(50);
				
				mCheck = mPaused = false;
				toSleep = TimeSpan.Zero;

				SPB = new GrblCommand.StatePositionBuilder();
				

				EmuLog(null);
				EmuLog("Grbl Reset");
				SendVersion();
			}
		}

		//private void PrintArray(byte[] p)
		//{
		//	StringBuilder sb = new StringBuilder("B: ");
		//	foreach (byte b in p)
		//	{
		//		sb.Append(b.ToString());
		//		sb.Append(" ");
		//	}
		//	EmuLog(sb.ToString().Trim());
		//}

		private void SendVersion()
		{ ImmediateTX("Grbl 1.1# ['$' for help]"); }

		private void SendStatus()
		{
            EnqueueTX("X:0.00 Y:0.00 Z:0.00 E:0.00 Count X:0 Y:0 Z:0");

            if (rxBuf.Count > 0)
                EnqueueTX("echo:busy:processing");
            else
                EnqueueTX("ok");

			//if (SPB.HasWCO)
			//	ImmediateTX(String.Format(System.Globalization.CultureInfo.InvariantCulture, "<{0}|MPos:{1:0.000},{2:0.000},{3:0.000}|WCO:{4:0.000},{5:0.000},{6:0.000}>\n", Status, px,py,pz,wx,wy,wz)); 
			//else
			//	ImmediateTX(String.Format(System.Globalization.CultureInfo.InvariantCulture, "<{0}|MPos:{1:0.000},{2:0.000},{3:0.000}>\n", Status, px, py, pz)); 
		}

		private string Status
		{
			get
			{
				if (mCheck)
					return "Check";
				else if (mPaused)
					return "Hold";
				else if (rxBuf.Count > 0)
					return "Run";
				else
					return "Idle";
			}
		}

		private void ManageRX()
		{
			lock (rxBuf)
			{
				if (rxBuf.Count > 0 && !mPaused)
				{
					try
					{
						string line = rxBuf.Dequeue();

						if (line == "$$\n")
							SendConfig();
						else if (IsSetConf(line))
							SetConfig(line);
						else if (line == "$C\n")
							SwapCheck();
						else if (line == "$H\n")
							EmulateHoming();
						else if (line.StartsWith("$J="))
							EmulateCommand(new JogCommand(line));
						else
							EmulateCommand(new GrblCommand(line));

						EmuLog(line.Trim("\n".ToCharArray()));
					}
					catch (Exception ex)
					{
					}
				}

				RX.SleepTime = rxBuf.Count > 0 ? 0 : 1;
			}
		}

		private void EmulateHoming()
		{
            EnqueueTX("echo:busy:proccessing");
            System.Threading.Thread.Sleep(2000);
			SPB.Homing();
			px = py = pz = 0;
			EnqueueTX("ok");
		}

		private void SwapCheck()
		{
			mCheck = !mCheck;
			EnqueueTX("ok");
			EnqueueTX(mCheck ? "[Enabled]" : "[Disabled]");
		}

		private void ManageTX()
		{
			lock (txBuf)
			{
				if (txBuf.Count > 0)
				{
					try
					{
						string line = txBuf.Dequeue();
						mSendFunc(line);
					}
					catch (Exception ex)
					{
					}
				}

				TX.SleepTime = txBuf.Count > 0 ? 0 : 1;
			}
		}

		private void EnqueueTX(String response)
		{
			lock (txBuf)
			{ txBuf.Enqueue(response + "\n"); }
		}

		private void ImmediateTX(String response)
		{
			lock (txBuf)
			{ mSendFunc(response + "\n"); }
		}

		private void EmulateCommand(GrblCommand cmd)
		{
			if (!mCheck)
			{
				try
				{
					TimeSpan cmdTime = SPB.AnalyzeCommand(cmd, true, conf);
					toSleep += cmdTime;

					if (toSleep.TotalMilliseconds > 15) //execute sleep
					{
						long start = Tools.HiResTimer.TotalNano;
						System.Threading.Thread.Sleep(toSleep);
						long stop = Tools.HiResTimer.TotalNano;
						toSleep -= TimeSpan.FromMilliseconds((double)(stop - start) / 1000.0 / 1000.0);
					}

					px = SPB.X.Number;
					py = SPB.Y.Number;
					pz = SPB.Z.Number;
					wx = SPB.WcoX;
					wy = SPB.WcoY;
					wz = SPB.WcoZ;
				}
				catch (Exception ex) { throw ex; }
				finally { cmd.DeleteHelper(); }
			}
             if (rxBuf.Count > 1)
                 EnqueueTX("echo:busy:proccessing");
              else
            EnqueueTX("ok");
        }
    }
}

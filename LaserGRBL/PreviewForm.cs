﻿/*
 * Created by SharpDevelop.
 * User: Diego
 * Date: 05/12/2016
 * Time: 23:25
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace LaserGRBL
{
	/// <summary>
	/// Description of PreviewForm.
	/// </summary>
	public partial class PreviewForm : System.Windows.Forms.UserControl
	{
		GrblCore Core;

		public PreviewForm()
		{
			InitializeComponent();
		}

		public void SetCore(GrblCore core)
		{
			Core = core;
			Preview.SetComProgram(core);

			RefreshCustomButtons();
			TimerUpdate();
		}

		public void TimerUpdate()
		{
			Preview.TimerUpdate();
			SuspendLayout();
			BtnReset.Enabled = Core.CanResetGrbl;
			BtnHoming.Visible = Core.Configuration.HomingEnabled;
			BtnHoming.Enabled = Core.CanDoHoming;
			BtnZeroing.Enabled = Core.CanDoZeroing;

			foreach (CustomButtonIB ib in CustomButtonArea.Controls)
				ib.RefreshEnabled();

			ResumeLayout();
		}

		void BtnGoHomeClick(object sender, EventArgs e)
		{
			Core.GrblHoming();
		}
		void BtnResetClick(object sender, EventArgs e)
		{
			Core.GrblReset();
		}
		void BtnStopClick(object sender, EventArgs e)
		{
			Core.FeedHold();
		}
		void BtnResumeClick(object sender, EventArgs e)
		{
			Core.CycleStartResume();
		}

		private void BtnUnlockClick(object sender, EventArgs e)
		{
			Core.GrblUnlock();
		}

		private void addCustomButtonToolStripMenuItem_Click(object sender, EventArgs e)
		{
			CustomButtonForm.CreateAndShowDialog();
			RefreshCustomButtons();
		}

		private void RefreshCustomButtons()
		{
			CustomButtonArea.Controls.Clear();
			foreach (CustomButton cb in CustomButtons.Buttons)
			{
				CustomButtonIB ib = new CustomButtonIB(Core, cb, this);
				CustomButtonArea.Controls.Add(ib);
			}

		}

		private class CustomButtonIB : UserControls.ImageButton
		{
			private GrblCore Core;
			private LaserGRBL.CustomButton cb;
			PreviewForm form;
			private ToolTip tt;
			private ContextMenuStrip cms;
			private bool mDrawDisabled = true;

			public CustomButtonIB(GrblCore Core, LaserGRBL.CustomButton cb, PreviewForm form)
			{
				// TODO: Complete member initialization
				this.Core = Core;
				this.cb = cb;
				this.form = form;
				this.tt = new ToolTip();

				Image = cb.Image;
				Tag = cb;

				//ContextMenuStrip = MNRemEditCB;
				SizingMode = UserControls.ImageButton.SizingModes.FixedSize;
				BorderStyle = BorderStyle.FixedSingle;
				Size = new Size(49, 49);
				Margin = new Padding(2);
				tt.SetToolTip(this, cb.ToolTip);


				cms = new ContextMenuStrip();
				cms.Items.Add(Strings.CustomButtonRemove, null, RemoveButton_Click);
				cms.Items.Add(Strings.CustomButtonEdit, null, EditButton_Click);

				this.ContextMenuStrip = cms;
			}


			protected override void Dispose(bool disposing)
			{
				tt.SetToolTip(this, null);
				base.Dispose(disposing);
			}

			public CustomButton CustomButton
			{ get { return Tag as CustomButton; } }

			internal void RefreshEnabled()
			{
				bool disabled = !CustomButton.EnabledNow(Core);
				if (mDrawDisabled != disabled)
				{
					mDrawDisabled = disabled;
					Refresh();
				}
			}

			protected override bool DrawDisabled()
			{
				return mDrawDisabled;
			}

			private bool on;
			protected override void OnClick(EventArgs e)
			{
				if (((MouseEventArgs)e).Button != MouseButtons.Left)
					return;

				if (mDrawDisabled || !CustomButton.EnabledNow(Core))
					return;

				if (cb.ButtonType == CustomButton.ButtonTypes.Button)
					Core.ExecuteCustombutton(cb.GCode);

				if (cb.ButtonType == CustomButton.ButtonTypes.TwoStateButton)
				{
					on = !on;
					Core.ExecuteCustombutton(on ? cb.GCode : cb.GCode2);
					BackColor = on ? Color.Orange : Parent.BackColor;
				}

				base.OnClick(e);
			}


			protected override void OnMouseDown(MouseEventArgs e)
			{
				if (e.Button != MouseButtons.Left)
					return;

				if (mDrawDisabled || !CustomButton.EnabledNow(Core))
					return;

				if (cb.ButtonType == CustomButton.ButtonTypes.PushButton)
				{
					Core.ExecuteCustombutton(cb.GCode);
					BackColor = Color.LightBlue;
				}

				base.OnMouseDown(e);
			}

			protected override void OnMouseUp(MouseEventArgs e)
			{
				if (e.Button != MouseButtons.Left)
					return;

				if (mDrawDisabled || !CustomButton.EnabledNow(Core))
					return;

				if (cb.ButtonType == CustomButton.ButtonTypes.PushButton)
				{
					Core.ExecuteCustombutton(cb.GCode2);
					BackColor = Parent.BackColor;
				}

				base.OnMouseUp(e);
			}

			private void RemoveButton_Click(object sender, EventArgs e)
			{
				if (MessageBox.Show(Strings.BoxDeleteCustomButtonText, Strings.BoxDeleteCustomButtonTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
				{
					CustomButtons.Remove(CustomButton);
					CustomButtons.SaveFile();
					form.RefreshCustomButtons();
				}
			}

			private void EditButton_Click(object sender, EventArgs e)
			{
				CustomButtonForm.CreateAndShowDialog(CustomButton);
				form.RefreshCustomButtons();
			}

		}

		private class MyFlowPanel : FlowLayoutPanel
		{
			public MyFlowPanel()
			{
				ResizeRedraw = true;
			}

			protected override void OnControlAdded(ControlEventArgs e)
			{
				base.OnControlAdded(e);
				Invalidate();
			}
			protected override void OnControlRemoved(ControlEventArgs e)
			{
				base.OnControlRemoved(e);
				Invalidate();
			}

			protected override void OnPaintBackground(PaintEventArgs e)
			{
				e.Graphics.Clear(BackColor);
				if (Controls.Count == 0)
				{
					SizeF size = e.Graphics.MeasureString("Right click here to add custom buttons", Font);
					e.Graphics.DrawString("Right click here to add custom buttons", Font, Brushes.DarkGray, (Width - size.Width) / 2, (Height - size.Height) / 2);
				}
			}
		}


		internal void OnColorChange()
		{
			Preview.OnColorChange();
		}

		private void BtnZeroing_Click(object sender, EventArgs e)
		{
			Core.SetNewZero();
		}

		private void exportCustomButtonsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			CustomButtons.Export();
		}

		private void importCustomButtonsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (CustomButtons.Import())
			{
				RefreshCustomButtons();
				CustomButtons.SaveFile();
			}
		}

		private void MNAddCB_Opening(object sender, CancelEventArgs e)
		{
			exportCustomButtonsToolStripMenuItem.Enabled = CustomButtons.Count > 0;
		}
	}

}

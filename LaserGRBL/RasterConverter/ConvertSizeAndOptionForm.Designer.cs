﻿/*
 * Created by SharpDevelop.
 * User: Diego
 * Date: 15/01/2017
 * Time: 12:12
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace LaserGRBL.RasterConverter
{
	partial class ConvertSizeAndOptionForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
		private System.Windows.Forms.GroupBox GbSize;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label4;
		private LaserGRBL.UserControls.NumericInput.DecimalInputRanged IIOffsetX;
		private LaserGRBL.UserControls.NumericInput.DecimalInputRanged IIOffsetY;
		private LaserGRBL.UserControls.NumericInput.DecimalInputRanged IISizeH;
		private LaserGRBL.UserControls.NumericInput.DecimalInputRanged IISizeW;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.GroupBox GbSpeed;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
		private System.Windows.Forms.Label LblBorderTracing;
		private LaserGRBL.UserControls.NumericInput.IntegerInputRanged IIBorderTracing;
		private LaserGRBL.UserControls.NumericInput.IntegerInputRanged IILinearFilling;
		private System.Windows.Forms.Label LblLinearFilling;
		private System.Windows.Forms.GroupBox GbLaser;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.Label LblSmin;
		private LaserGRBL.UserControls.NumericInput.IntegerInputRanged IIMinPower;
		private System.Windows.Forms.Label LblSmax;
		private LaserGRBL.UserControls.NumericInput.IntegerInputRanged IIMaxPower;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Button BtnCreate;
		private System.Windows.Forms.Button BtnCancel;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConvertSizeAndOptionForm));
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.GbSize = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.IIOffsetX = new LaserGRBL.UserControls.NumericInput.DecimalInputRanged();
            this.IIOffsetY = new LaserGRBL.UserControls.NumericInput.DecimalInputRanged();
            this.IISizeH = new LaserGRBL.UserControls.NumericInput.DecimalInputRanged();
            this.IISizeW = new LaserGRBL.UserControls.NumericInput.DecimalInputRanged();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.CbAutosize = new System.Windows.Forms.CheckBox();
            this.IIDpi = new LaserGRBL.UserControls.NumericInput.IntegerInputRanged();
            this.BtnDPI = new LaserGRBL.UserControls.ImageButton();
            this.GbSpeed = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.LblBorderTracing = new System.Windows.Forms.Label();
            this.LblBorderTracingmm = new System.Windows.Forms.Label();
            this.IIBorderTracing = new LaserGRBL.UserControls.NumericInput.IntegerInputRanged();
            this.IILinearFilling = new LaserGRBL.UserControls.NumericInput.IntegerInputRanged();
            this.LblLinearFillingmm = new System.Windows.Forms.Label();
            this.LblLinearFilling = new System.Windows.Forms.Label();
            this.GbLaser = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnModulationInfo = new LaserGRBL.UserControls.ImageButton();
            this.label26 = new System.Windows.Forms.Label();
            this.LblSmin = new System.Windows.Forms.Label();
            this.IIMinPower = new LaserGRBL.UserControls.NumericInput.IntegerInputRanged();
            this.LblSmax = new System.Windows.Forms.Label();
            this.IIMaxPower = new LaserGRBL.UserControls.NumericInput.IntegerInputRanged();
            this.label18 = new System.Windows.Forms.Label();
            this.BtnOnOffInfo = new LaserGRBL.UserControls.ImageButton();
            this.CBLaserON = new System.Windows.Forms.ComboBox();
            this.CBLaserOFF = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.OffsetZ = new LaserGRBL.UserControls.NumericInput.IntegerInputRanged();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnCreate = new System.Windows.Forms.Button();
            this.TT = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel9.SuspendLayout();
            this.GbSize.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.GbSpeed.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.GbLaser.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel9
            // 
            resources.ApplyResources(this.tableLayoutPanel9, "tableLayoutPanel9");
            this.tableLayoutPanel9.Controls.Add(this.GbSize, 0, 2);
            this.tableLayoutPanel9.Controls.Add(this.GbSpeed, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.GbLaser, 0, 1);
            this.tableLayoutPanel9.Controls.Add(this.tableLayoutPanel1, 0, 3);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            // 
            // GbSize
            // 
            resources.ApplyResources(this.GbSize, "GbSize");
            this.GbSize.Controls.Add(this.tableLayoutPanel3);
            this.GbSize.Name = "GbSize";
            this.GbSize.TabStop = false;
            // 
            // tableLayoutPanel3
            // 
            resources.ApplyResources(this.tableLayoutPanel3, "tableLayoutPanel3");
            this.tableLayoutPanel3.Controls.Add(this.label9, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.IIOffsetX, 2, 3);
            this.tableLayoutPanel3.Controls.Add(this.IIOffsetY, 4, 3);
            this.tableLayoutPanel3.Controls.Add(this.IISizeH, 4, 2);
            this.tableLayoutPanel3.Controls.Add(this.IISizeW, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.label6, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.label10, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.label7, 3, 2);
            this.tableLayoutPanel3.Controls.Add(this.label11, 3, 3);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // IIOffsetX
            // 
            resources.ApplyResources(this.IIOffsetX, "IIOffsetX");
            this.IIOffsetX.CurrentValue = 0F;
            this.IIOffsetX.DecimalPositions = 1;
            this.IIOffsetX.ForceMinMax = false;
            this.IIOffsetX.MaxValue = 1000F;
            this.IIOffsetX.MinValue = 0F;
            this.IIOffsetX.Name = "IIOffsetX";
            this.IIOffsetX.NormalBorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.IIOffsetX.CurrentValueChanged += new LaserGRBL.UserControls.NumericInput.DecimalInputBase.CurrentValueChangedDlg(this.IIOffsetXYCurrentValueChanged);
            // 
            // IIOffsetY
            // 
            this.IIOffsetY.CurrentValue = 0F;
            this.IIOffsetY.DecimalPositions = 1;
            this.IIOffsetY.ForceMinMax = false;
            resources.ApplyResources(this.IIOffsetY, "IIOffsetY");
            this.IIOffsetY.MaxValue = 1000F;
            this.IIOffsetY.MinValue = 0F;
            this.IIOffsetY.Name = "IIOffsetY";
            this.IIOffsetY.NormalBorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.IIOffsetY.CurrentValueChanged += new LaserGRBL.UserControls.NumericInput.DecimalInputBase.CurrentValueChangedDlg(this.IIOffsetXYCurrentValueChanged);
            // 
            // IISizeH
            // 
            this.IISizeH.CurrentValue = 0F;
            this.IISizeH.DecimalPositions = 1;
            this.IISizeH.ForceMinMax = false;
            resources.ApplyResources(this.IISizeH, "IISizeH");
            this.IISizeH.MaxValue = 1000F;
            this.IISizeH.MinValue = 10F;
            this.IISizeH.Name = "IISizeH";
            this.IISizeH.NormalBorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.IISizeH.CurrentValueChanged += new LaserGRBL.UserControls.NumericInput.DecimalInputBase.CurrentValueChangedDlg(this.IISizeH_CurrentValueChanged);
            this.IISizeH.OnTheFlyValueChanged += new LaserGRBL.UserControls.NumericInput.DecimalInputBase.CurrentValueChangedDlg(this.IISizeH_OnTheFlyValueChanged);
            // 
            // IISizeW
            // 
            this.IISizeW.CurrentValue = 0F;
            this.IISizeW.DecimalPositions = 1;
            this.IISizeW.ForceMinMax = false;
            resources.ApplyResources(this.IISizeW, "IISizeW");
            this.IISizeW.MaxValue = 1000F;
            this.IISizeW.MinValue = 10F;
            this.IISizeW.Name = "IISizeW";
            this.IISizeW.NormalBorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.IISizeW.CurrentValueChanged += new LaserGRBL.UserControls.NumericInput.DecimalInputBase.CurrentValueChangedDlg(this.IISizeW_CurrentValueChanged);
            this.IISizeW.OnTheFlyValueChanged += new LaserGRBL.UserControls.NumericInput.DecimalInputBase.CurrentValueChangedDlg(this.IISizeW_OnTheFlyValueChanged);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel3.SetColumnSpan(this.tableLayoutPanel2, 5);
            this.tableLayoutPanel2.Controls.Add(this.label1, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.CbAutosize, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.IIDpi, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.BtnDPI, 3, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // CbAutosize
            // 
            resources.ApplyResources(this.CbAutosize, "CbAutosize");
            this.CbAutosize.Name = "CbAutosize";
            this.CbAutosize.UseVisualStyleBackColor = true;
            this.CbAutosize.CheckedChanged += new System.EventHandler(this.CbAutosize_CheckedChanged);
            // 
            // IIDpi
            // 
            resources.ApplyResources(this.IIDpi, "IIDpi");
            this.IIDpi.CurrentValue = 300;
            this.IIDpi.ForcedText = null;
            this.IIDpi.ForceMinMax = false;
            this.IIDpi.MaxValue = 10000;
            this.IIDpi.MinValue = 1;
            this.IIDpi.Name = "IIDpi";
            this.IIDpi.NormalBorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.IIDpi.CurrentValueChanged += new LaserGRBL.UserControls.NumericInput.IntegerInputBase.CurrentValueChangedEventHandler(this.IIDpi_CurrentValueChanged);
            // 
            // BtnDPI
            // 
            this.BtnDPI.AltImage = null;
            resources.ApplyResources(this.BtnDPI, "BtnDPI");
            this.BtnDPI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnDPI.Coloration = System.Drawing.Color.Empty;
            this.BtnDPI.Image = ((System.Drawing.Image)(resources.GetObject("BtnDPI.Image")));
            this.BtnDPI.Name = "BtnDPI";
            this.BtnDPI.SizingMode = LaserGRBL.UserControls.ImageButton.SizingModes.FixedSize;
            this.TT.SetToolTip(this.BtnDPI, resources.GetString("BtnDPI.ToolTip"));
            this.BtnDPI.UseAltImage = false;
            this.BtnDPI.Click += new System.EventHandler(this.BtnDPI_Click);
            // 
            // GbSpeed
            // 
            resources.ApplyResources(this.GbSpeed, "GbSpeed");
            this.GbSpeed.Controls.Add(this.tableLayoutPanel6);
            this.GbSpeed.Name = "GbSpeed";
            this.GbSpeed.TabStop = false;
            // 
            // tableLayoutPanel6
            // 
            resources.ApplyResources(this.tableLayoutPanel6, "tableLayoutPanel6");
            this.tableLayoutPanel6.Controls.Add(this.LblBorderTracing, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.LblBorderTracingmm, 2, 0);
            this.tableLayoutPanel6.Controls.Add(this.IIBorderTracing, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.IILinearFilling, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.LblLinearFillingmm, 2, 1);
            this.tableLayoutPanel6.Controls.Add(this.LblLinearFilling, 0, 1);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            // 
            // LblBorderTracing
            // 
            resources.ApplyResources(this.LblBorderTracing, "LblBorderTracing");
            this.LblBorderTracing.Name = "LblBorderTracing";
            // 
            // LblBorderTracingmm
            // 
            resources.ApplyResources(this.LblBorderTracingmm, "LblBorderTracingmm");
            this.LblBorderTracingmm.Name = "LblBorderTracingmm";
            // 
            // IIBorderTracing
            // 
            resources.ApplyResources(this.IIBorderTracing, "IIBorderTracing");
            this.IIBorderTracing.CurrentValue = 1000;
            this.IIBorderTracing.ForcedText = null;
            this.IIBorderTracing.ForceMinMax = false;
            this.IIBorderTracing.MaxValue = 4000;
            this.IIBorderTracing.MinValue = 1;
            this.IIBorderTracing.Name = "IIBorderTracing";
            this.IIBorderTracing.NormalBorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.IIBorderTracing.CurrentValueChanged += new LaserGRBL.UserControls.NumericInput.IntegerInputBase.CurrentValueChangedEventHandler(this.IIBorderTracingCurrentValueChanged);
            // 
            // IILinearFilling
            // 
            resources.ApplyResources(this.IILinearFilling, "IILinearFilling");
            this.IILinearFilling.CurrentValue = 1000;
            this.IILinearFilling.ForcedText = null;
            this.IILinearFilling.ForceMinMax = false;
            this.IILinearFilling.MaxValue = 4000;
            this.IILinearFilling.MinValue = 1;
            this.IILinearFilling.Name = "IILinearFilling";
            this.IILinearFilling.NormalBorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.IILinearFilling.CurrentValueChanged += new LaserGRBL.UserControls.NumericInput.IntegerInputBase.CurrentValueChangedEventHandler(this.IIMarkSpeedCurrentValueChanged);
            // 
            // LblLinearFillingmm
            // 
            resources.ApplyResources(this.LblLinearFillingmm, "LblLinearFillingmm");
            this.LblLinearFillingmm.Name = "LblLinearFillingmm";
            // 
            // LblLinearFilling
            // 
            resources.ApplyResources(this.LblLinearFilling, "LblLinearFilling");
            this.LblLinearFilling.Name = "LblLinearFilling";
            // 
            // GbLaser
            // 
            resources.ApplyResources(this.GbLaser, "GbLaser");
            this.GbLaser.Controls.Add(this.tableLayoutPanel7);
            this.GbLaser.Name = "GbLaser";
            this.GbLaser.TabStop = false;
            // 
            // tableLayoutPanel7
            // 
            resources.ApplyResources(this.tableLayoutPanel7, "tableLayoutPanel7");
            this.tableLayoutPanel7.Controls.Add(this.BtnModulationInfo, 4, 1);
            this.tableLayoutPanel7.Controls.Add(this.label26, 2, 0);
            this.tableLayoutPanel7.Controls.Add(this.LblSmin, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.IIMinPower, 1, 1);
            this.tableLayoutPanel7.Controls.Add(this.LblSmax, 2, 1);
            this.tableLayoutPanel7.Controls.Add(this.IIMaxPower, 3, 1);
            this.tableLayoutPanel7.Controls.Add(this.label18, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.BtnOnOffInfo, 4, 0);
            this.tableLayoutPanel7.Controls.Add(this.CBLaserON, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.CBLaserOFF, 3, 0);
            this.tableLayoutPanel7.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel7.Controls.Add(this.label3, 2, 2);
            this.tableLayoutPanel7.Controls.Add(this.OffsetZ, 1, 2);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            // 
            // BtnModulationInfo
            // 
            this.BtnModulationInfo.AltImage = null;
            resources.ApplyResources(this.BtnModulationInfo, "BtnModulationInfo");
            this.BtnModulationInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnModulationInfo.Coloration = System.Drawing.Color.Empty;
            this.BtnModulationInfo.Image = ((System.Drawing.Image)(resources.GetObject("BtnModulationInfo.Image")));
            this.BtnModulationInfo.Name = "BtnModulationInfo";
            this.BtnModulationInfo.SizingMode = LaserGRBL.UserControls.ImageButton.SizingModes.FixedSize;
            this.TT.SetToolTip(this.BtnModulationInfo, resources.GetString("BtnModulationInfo.ToolTip"));
            this.BtnModulationInfo.UseAltImage = false;
            this.BtnModulationInfo.Click += new System.EventHandler(this.BtnModulationInfo_Click);
            // 
            // label26
            // 
            resources.ApplyResources(this.label26, "label26");
            this.label26.Name = "label26";
            // 
            // LblSmin
            // 
            resources.ApplyResources(this.LblSmin, "LblSmin");
            this.LblSmin.Name = "LblSmin";
            // 
            // IIMinPower
            // 
            resources.ApplyResources(this.IIMinPower, "IIMinPower");
            this.IIMinPower.ForcedText = null;
            this.IIMinPower.ForceMinMax = false;
            this.IIMinPower.MaxValue = 999;
            this.IIMinPower.MinValue = 0;
            this.IIMinPower.Name = "IIMinPower";
            this.IIMinPower.NormalBorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.IIMinPower.CurrentValueChanged += new LaserGRBL.UserControls.NumericInput.IntegerInputBase.CurrentValueChangedEventHandler(this.IIMinPowerCurrentValueChanged);
            // 
            // LblSmax
            // 
            resources.ApplyResources(this.LblSmax, "LblSmax");
            this.LblSmax.Name = "LblSmax";
            // 
            // IIMaxPower
            // 
            resources.ApplyResources(this.IIMaxPower, "IIMaxPower");
            this.IIMaxPower.CurrentValue = 255;
            this.IIMaxPower.ForcedText = null;
            this.IIMaxPower.ForceMinMax = false;
            this.IIMaxPower.MaxValue = 1000;
            this.IIMaxPower.MinValue = 1;
            this.IIMaxPower.Name = "IIMaxPower";
            this.IIMaxPower.NormalBorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.IIMaxPower.CurrentValueChanged += new LaserGRBL.UserControls.NumericInput.IntegerInputBase.CurrentValueChangedEventHandler(this.IIMaxPowerCurrentValueChanged);
            // 
            // label18
            // 
            resources.ApplyResources(this.label18, "label18");
            this.label18.Name = "label18";
            // 
            // BtnOnOffInfo
            // 
            this.BtnOnOffInfo.AltImage = null;
            resources.ApplyResources(this.BtnOnOffInfo, "BtnOnOffInfo");
            this.BtnOnOffInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnOnOffInfo.Coloration = System.Drawing.Color.Empty;
            this.BtnOnOffInfo.Image = ((System.Drawing.Image)(resources.GetObject("BtnOnOffInfo.Image")));
            this.BtnOnOffInfo.Name = "BtnOnOffInfo";
            this.BtnOnOffInfo.SizingMode = LaserGRBL.UserControls.ImageButton.SizingModes.FixedSize;
            this.TT.SetToolTip(this.BtnOnOffInfo, resources.GetString("BtnOnOffInfo.ToolTip"));
            this.BtnOnOffInfo.UseAltImage = false;
            this.BtnOnOffInfo.Click += new System.EventHandler(this.BtnOnOffInfo_Click);
            // 
            // CBLaserON
            // 
            this.CBLaserON.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBLaserON.FormattingEnabled = true;
            this.CBLaserON.Items.AddRange(new object[] {
            resources.GetString("CBLaserON.Items")});
            resources.ApplyResources(this.CBLaserON, "CBLaserON");
            this.CBLaserON.Name = "CBLaserON";
            this.CBLaserON.SelectedIndexChanged += new System.EventHandler(this.CBLaserON_SelectedIndexChanged);
            // 
            // CBLaserOFF
            // 
            this.CBLaserOFF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBLaserOFF.FormattingEnabled = true;
            this.CBLaserOFF.Items.AddRange(new object[] {
            resources.GetString("CBLaserOFF.Items"),
            resources.GetString("CBLaserOFF.Items1"),
            resources.GetString("CBLaserOFF.Items2")});
            resources.ApplyResources(this.CBLaserOFF, "CBLaserOFF");
            this.CBLaserOFF.Name = "CBLaserOFF";
            this.CBLaserOFF.SelectedIndexChanged += new System.EventHandler(this.CBLaserOFF_SelectedIndexChanged);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // OffsetZ
            // 
            resources.ApplyResources(this.OffsetZ, "OffsetZ");
            this.OffsetZ.CurrentValue = 50;
            this.OffsetZ.ForcedText = null;
            this.OffsetZ.ForceMinMax = false;
            this.OffsetZ.MaxValue = 0;
            this.OffsetZ.MinValue = 360;
            this.OffsetZ.Name = "OffsetZ";
            this.OffsetZ.CurrentValueChanged += new LaserGRBL.UserControls.NumericInput.IntegerInputBase.CurrentValueChangedEventHandler(this.OffsetZ_CurrentValueChanged);
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.BtnCancel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtnCreate, 2, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // BtnCancel
            // 
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.BtnCancel, "BtnCancel");
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnCreate
            // 
            this.BtnCreate.DialogResult = System.Windows.Forms.DialogResult.OK;
            resources.ApplyResources(this.BtnCreate, "BtnCreate");
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.UseVisualStyleBackColor = true;
            // 
            // TT
            // 
            this.TT.AutoPopDelay = 10000;
            this.TT.InitialDelay = 500;
            this.TT.ReshowDelay = 100;
            // 
            // ConvertSizeAndOptionForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ConvertSizeAndOptionForm";
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            this.GbSize.ResumeLayout(false);
            this.GbSize.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.GbSpeed.ResumeLayout(false);
            this.GbSpeed.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.GbLaser.ResumeLayout(false);
            this.GbLaser.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		private UserControls.ImageButton BtnModulationInfo;
		private UserControls.ImageButton BtnOnOffInfo;
		private System.Windows.Forms.ComboBox CBLaserON;
		private System.Windows.Forms.ComboBox CBLaserOFF;
		private System.Windows.Forms.ToolTip TT;
		private System.Windows.Forms.Label LblBorderTracingmm;
		private System.Windows.Forms.Label LblLinearFillingmm;
        private System.Windows.Forms.CheckBox CbAutosize;
        private UserControls.NumericInput.IntegerInputRanged IIDpi;
		private UserControls.ImageButton BtnDPI;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private UserControls.NumericInput.IntegerInputRanged OffsetZ;
    }
}

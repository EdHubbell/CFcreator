﻿
namespace CFCreator
{
    partial class CFCreatorForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.TargetIDLabel = new System.Windows.Forms.Label();
            this.TargetID = new System.Windows.Forms.TextBox();
            this.TgtRegLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.TgtRegLabel = new System.Windows.Forms.Label();
            this.tgtRegRowLabel = new System.Windows.Forms.Label();
            this.tgtRegColsLabel = new System.Windows.Forms.Label();
            this.TgtRegCols = new System.Windows.Forms.NumericUpDown();
            this.TgtRegRows = new System.Windows.Forms.NumericUpDown();
            this.TgtPrintLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.TgtPrintsLabel = new System.Windows.Forms.Label();
            this.TgtPrintRowLabel = new System.Windows.Forms.Label();
            this.TgtPrintColLabel = new System.Windows.Forms.Label();
            this.TgtPrintRows = new System.Windows.Forms.NumericUpDown();
            this.TgtPrintCols = new System.Windows.Forms.NumericUpDown();
            this.SourceIDLabel = new System.Windows.Forms.Label();
            this.SourceID = new System.Windows.Forms.TextBox();
            this.SrcRegionsLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.SrcRegLabel = new System.Windows.Forms.Label();
            this.srcRegRowLabel = new System.Windows.Forms.Label();
            this.SrcRegRows = new System.Windows.Forms.NumericUpDown();
            this.srcRegColLabel = new System.Windows.Forms.Label();
            this.SrcRegCols = new System.Windows.Forms.NumericUpDown();
            this.SrcClustersLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.SrcClusterLabel = new System.Windows.Forms.Label();
            this.srcClustRowLabel = new System.Windows.Forms.Label();
            this.srcClustColLabel = new System.Windows.Forms.Label();
            this.SrcClustRows = new System.Windows.Forms.NumericUpDown();
            this.SrcClustCols = new System.Windows.Forms.NumericUpDown();
            this.PickIndexLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.PPFLabel = new System.Windows.Forms.Label();
            this.PicksPerField = new System.Windows.Forms.NumericUpDown();
            this.StartIndexLabel = new System.Windows.Forms.Label();
            this.StartIndex = new System.Windows.Forms.NumericUpDown();
            this.ClickOrderLabel = new System.Windows.Forms.Label();
            this.OrderBoxFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.TgtClickOrderCheckBox = new System.Windows.Forms.CheckBox();
            this.SrcClickOrderCheckBox = new System.Windows.Forms.CheckBox();
            this.ButtonLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.DrawWafer = new System.Windows.Forms.Button();
            this.CreateCF = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.TgtRegLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TgtRegCols)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TgtRegRows)).BeginInit();
            this.TgtPrintLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TgtPrintRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TgtPrintCols)).BeginInit();
            this.SrcRegionsLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SrcRegRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SrcRegCols)).BeginInit();
            this.SrcClustersLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SrcClustRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SrcClustCols)).BeginInit();
            this.PickIndexLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicksPerField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartIndex)).BeginInit();
            this.OrderBoxFlowLayout.SuspendLayout();
            this.ButtonLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.06504F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.93496F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(745, 620);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.TargetIDLabel);
            this.flowLayoutPanel1.Controls.Add(this.TargetID);
            this.flowLayoutPanel1.Controls.Add(this.TgtRegLayoutPanel);
            this.flowLayoutPanel1.Controls.Add(this.TgtPrintLayoutPanel);
            this.flowLayoutPanel1.Controls.Add(this.SourceIDLabel);
            this.flowLayoutPanel1.Controls.Add(this.SourceID);
            this.flowLayoutPanel1.Controls.Add(this.SrcRegionsLayoutPanel);
            this.flowLayoutPanel1.Controls.Add(this.SrcClustersLayoutPanel);
            this.flowLayoutPanel1.Controls.Add(this.PickIndexLayoutPanel);
            this.flowLayoutPanel1.Controls.Add(this.ClickOrderLabel);
            this.flowLayoutPanel1.Controls.Add(this.OrderBoxFlowLayout);
            this.flowLayoutPanel1.Controls.Add(this.ButtonLayoutPanel);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.tableLayoutPanel1.SetRowSpan(this.flowLayoutPanel1, 2);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(173, 614);
            this.flowLayoutPanel1.TabIndex = 2;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // TargetIDLabel
            // 
            this.TargetIDLabel.AutoSize = true;
            this.TargetIDLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TargetIDLabel.Location = new System.Drawing.Point(3, 0);
            this.TargetIDLabel.Name = "TargetIDLabel";
            this.TargetIDLabel.Size = new System.Drawing.Size(159, 15);
            this.TargetIDLabel.TabIndex = 19;
            this.TargetIDLabel.Text = "Target ID";
            this.TargetIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TargetID
            // 
            this.TargetID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TargetID.Location = new System.Drawing.Point(3, 18);
            this.TargetID.Name = "TargetID";
            this.TargetID.Size = new System.Drawing.Size(159, 23);
            this.TargetID.TabIndex = 17;
            // 
            // TgtRegLayoutPanel
            // 
            this.TgtRegLayoutPanel.ColumnCount = 2;
            this.TgtRegLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TgtRegLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TgtRegLayoutPanel.Controls.Add(this.TgtRegLabel, 0, 0);
            this.TgtRegLayoutPanel.Controls.Add(this.tgtRegRowLabel, 0, 1);
            this.TgtRegLayoutPanel.Controls.Add(this.tgtRegColsLabel, 1, 1);
            this.TgtRegLayoutPanel.Controls.Add(this.TgtRegCols, 1, 2);
            this.TgtRegLayoutPanel.Controls.Add(this.TgtRegRows, 0, 2);
            this.TgtRegLayoutPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.TgtRegLayoutPanel.Location = new System.Drawing.Point(3, 47);
            this.TgtRegLayoutPanel.Name = "TgtRegLayoutPanel";
            this.TgtRegLayoutPanel.RowCount = 3;
            this.TgtRegLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TgtRegLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TgtRegLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TgtRegLayoutPanel.Size = new System.Drawing.Size(159, 61);
            this.TgtRegLayoutPanel.TabIndex = 26;
            // 
            // TgtRegLabel
            // 
            this.TgtRegLabel.AutoSize = true;
            this.TgtRegLayoutPanel.SetColumnSpan(this.TgtRegLabel, 2);
            this.TgtRegLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TgtRegLabel.Location = new System.Drawing.Point(3, 0);
            this.TgtRegLabel.Name = "TgtRegLabel";
            this.TgtRegLabel.Size = new System.Drawing.Size(153, 15);
            this.TgtRegLabel.TabIndex = 0;
            this.TgtRegLabel.Text = "Target Regions";
            this.TgtRegLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tgtRegRowLabel
            // 
            this.tgtRegRowLabel.AutoSize = true;
            this.tgtRegRowLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tgtRegRowLabel.Location = new System.Drawing.Point(3, 15);
            this.tgtRegRowLabel.Name = "tgtRegRowLabel";
            this.tgtRegRowLabel.Size = new System.Drawing.Size(73, 15);
            this.tgtRegRowLabel.TabIndex = 0;
            this.tgtRegRowLabel.Text = "Rows";
            this.tgtRegRowLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tgtRegColsLabel
            // 
            this.tgtRegColsLabel.AutoSize = true;
            this.tgtRegColsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tgtRegColsLabel.Location = new System.Drawing.Point(82, 15);
            this.tgtRegColsLabel.Name = "tgtRegColsLabel";
            this.tgtRegColsLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tgtRegColsLabel.Size = new System.Drawing.Size(74, 15);
            this.tgtRegColsLabel.TabIndex = 2;
            this.tgtRegColsLabel.Text = "Columns";
            this.tgtRegColsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TgtRegCols
            // 
            this.TgtRegCols.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TgtRegCols.Location = new System.Drawing.Point(82, 33);
            this.TgtRegCols.Name = "TgtRegCols";
            this.TgtRegCols.Size = new System.Drawing.Size(74, 23);
            this.TgtRegCols.TabIndex = 3;
            this.TgtRegCols.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // TgtRegRows
            // 
            this.TgtRegRows.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TgtRegRows.Location = new System.Drawing.Point(3, 33);
            this.TgtRegRows.Name = "TgtRegRows";
            this.TgtRegRows.Size = new System.Drawing.Size(73, 23);
            this.TgtRegRows.TabIndex = 1;
            this.TgtRegRows.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // TgtPrintLayoutPanel
            // 
            this.TgtPrintLayoutPanel.ColumnCount = 2;
            this.TgtPrintLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TgtPrintLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TgtPrintLayoutPanel.Controls.Add(this.TgtPrintsLabel, 0, 0);
            this.TgtPrintLayoutPanel.Controls.Add(this.TgtPrintRowLabel, 0, 1);
            this.TgtPrintLayoutPanel.Controls.Add(this.TgtPrintColLabel, 1, 1);
            this.TgtPrintLayoutPanel.Controls.Add(this.TgtPrintRows, 0, 2);
            this.TgtPrintLayoutPanel.Controls.Add(this.TgtPrintCols, 1, 2);
            this.TgtPrintLayoutPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.TgtPrintLayoutPanel.Location = new System.Drawing.Point(3, 114);
            this.TgtPrintLayoutPanel.Name = "TgtPrintLayoutPanel";
            this.TgtPrintLayoutPanel.RowCount = 3;
            this.TgtPrintLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TgtPrintLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TgtPrintLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TgtPrintLayoutPanel.Size = new System.Drawing.Size(159, 62);
            this.TgtPrintLayoutPanel.TabIndex = 27;
            // 
            // TgtPrintsLabel
            // 
            this.TgtPrintsLabel.AutoSize = true;
            this.TgtPrintLayoutPanel.SetColumnSpan(this.TgtPrintsLabel, 2);
            this.TgtPrintsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TgtPrintsLabel.Location = new System.Drawing.Point(3, 0);
            this.TgtPrintsLabel.Name = "TgtPrintsLabel";
            this.TgtPrintsLabel.Size = new System.Drawing.Size(153, 15);
            this.TgtPrintsLabel.TabIndex = 0;
            this.TgtPrintsLabel.Text = "Prints Per Region";
            this.TgtPrintsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TgtPrintRowLabel
            // 
            this.TgtPrintRowLabel.AutoSize = true;
            this.TgtPrintRowLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TgtPrintRowLabel.Location = new System.Drawing.Point(3, 15);
            this.TgtPrintRowLabel.Name = "TgtPrintRowLabel";
            this.TgtPrintRowLabel.Size = new System.Drawing.Size(73, 15);
            this.TgtPrintRowLabel.TabIndex = 10;
            this.TgtPrintRowLabel.Text = "Rows";
            this.TgtPrintRowLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TgtPrintColLabel
            // 
            this.TgtPrintColLabel.AutoSize = true;
            this.TgtPrintColLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TgtPrintColLabel.Location = new System.Drawing.Point(82, 15);
            this.TgtPrintColLabel.Name = "TgtPrintColLabel";
            this.TgtPrintColLabel.Size = new System.Drawing.Size(74, 15);
            this.TgtPrintColLabel.TabIndex = 11;
            this.TgtPrintColLabel.Text = "Columns";
            this.TgtPrintColLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TgtPrintRows
            // 
            this.TgtPrintRows.Location = new System.Drawing.Point(3, 33);
            this.TgtPrintRows.Name = "TgtPrintRows";
            this.TgtPrintRows.Size = new System.Drawing.Size(73, 23);
            this.TgtPrintRows.TabIndex = 8;
            this.TgtPrintRows.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // TgtPrintCols
            // 
            this.TgtPrintCols.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TgtPrintCols.Location = new System.Drawing.Point(82, 33);
            this.TgtPrintCols.Name = "TgtPrintCols";
            this.TgtPrintCols.Size = new System.Drawing.Size(74, 23);
            this.TgtPrintCols.TabIndex = 9;
            this.TgtPrintCols.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // SourceIDLabel
            // 
            this.SourceIDLabel.AutoSize = true;
            this.SourceIDLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SourceIDLabel.Location = new System.Drawing.Point(3, 179);
            this.SourceIDLabel.Name = "SourceIDLabel";
            this.SourceIDLabel.Size = new System.Drawing.Size(159, 15);
            this.SourceIDLabel.TabIndex = 20;
            this.SourceIDLabel.Text = "Source ID";
            this.SourceIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SourceID
            // 
            this.SourceID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SourceID.Location = new System.Drawing.Point(3, 197);
            this.SourceID.Name = "SourceID";
            this.SourceID.Size = new System.Drawing.Size(159, 23);
            this.SourceID.TabIndex = 18;
            // 
            // SrcRegionsLayoutPanel
            // 
            this.SrcRegionsLayoutPanel.ColumnCount = 2;
            this.SrcRegionsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SrcRegionsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SrcRegionsLayoutPanel.Controls.Add(this.SrcRegLabel, 0, 0);
            this.SrcRegionsLayoutPanel.Controls.Add(this.srcRegRowLabel, 0, 1);
            this.SrcRegionsLayoutPanel.Controls.Add(this.SrcRegRows, 0, 2);
            this.SrcRegionsLayoutPanel.Controls.Add(this.srcRegColLabel, 1, 1);
            this.SrcRegionsLayoutPanel.Controls.Add(this.SrcRegCols, 1, 2);
            this.SrcRegionsLayoutPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SrcRegionsLayoutPanel.Location = new System.Drawing.Point(3, 226);
            this.SrcRegionsLayoutPanel.Name = "SrcRegionsLayoutPanel";
            this.SrcRegionsLayoutPanel.RowCount = 3;
            this.SrcRegionsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.SrcRegionsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.SrcRegionsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SrcRegionsLayoutPanel.Size = new System.Drawing.Size(159, 64);
            this.SrcRegionsLayoutPanel.TabIndex = 28;
            // 
            // SrcRegLabel
            // 
            this.SrcRegLabel.AutoSize = true;
            this.SrcRegionsLayoutPanel.SetColumnSpan(this.SrcRegLabel, 2);
            this.SrcRegLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SrcRegLabel.Location = new System.Drawing.Point(3, 0);
            this.SrcRegLabel.Name = "SrcRegLabel";
            this.SrcRegLabel.Size = new System.Drawing.Size(153, 16);
            this.SrcRegLabel.TabIndex = 0;
            this.SrcRegLabel.Text = "Source Regions";
            this.SrcRegLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // srcRegRowLabel
            // 
            this.srcRegRowLabel.AutoSize = true;
            this.srcRegRowLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.srcRegRowLabel.Location = new System.Drawing.Point(3, 16);
            this.srcRegRowLabel.Name = "srcRegRowLabel";
            this.srcRegRowLabel.Size = new System.Drawing.Size(73, 16);
            this.srcRegRowLabel.TabIndex = 4;
            this.srcRegRowLabel.Text = "Rows";
            this.srcRegRowLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SrcRegRows
            // 
            this.SrcRegRows.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SrcRegRows.Location = new System.Drawing.Point(3, 35);
            this.SrcRegRows.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SrcRegRows.Name = "SrcRegRows";
            this.SrcRegRows.Size = new System.Drawing.Size(73, 23);
            this.SrcRegRows.TabIndex = 5;
            this.SrcRegRows.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // srcRegColLabel
            // 
            this.srcRegColLabel.AutoSize = true;
            this.srcRegColLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.srcRegColLabel.Location = new System.Drawing.Point(82, 16);
            this.srcRegColLabel.Name = "srcRegColLabel";
            this.srcRegColLabel.Size = new System.Drawing.Size(74, 16);
            this.srcRegColLabel.TabIndex = 6;
            this.srcRegColLabel.Text = "Columns";
            this.srcRegColLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SrcRegCols
            // 
            this.SrcRegCols.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SrcRegCols.Location = new System.Drawing.Point(82, 35);
            this.SrcRegCols.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SrcRegCols.Name = "SrcRegCols";
            this.SrcRegCols.Size = new System.Drawing.Size(74, 23);
            this.SrcRegCols.TabIndex = 7;
            this.SrcRegCols.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // SrcClustersLayoutPanel
            // 
            this.SrcClustersLayoutPanel.ColumnCount = 2;
            this.SrcClustersLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SrcClustersLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SrcClustersLayoutPanel.Controls.Add(this.SrcClusterLabel, 0, 0);
            this.SrcClustersLayoutPanel.Controls.Add(this.srcClustRowLabel, 0, 1);
            this.SrcClustersLayoutPanel.Controls.Add(this.srcClustColLabel, 1, 1);
            this.SrcClustersLayoutPanel.Controls.Add(this.SrcClustRows, 0, 2);
            this.SrcClustersLayoutPanel.Controls.Add(this.SrcClustCols, 1, 2);
            this.SrcClustersLayoutPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SrcClustersLayoutPanel.Location = new System.Drawing.Point(3, 296);
            this.SrcClustersLayoutPanel.Name = "SrcClustersLayoutPanel";
            this.SrcClustersLayoutPanel.RowCount = 3;
            this.SrcClustersLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.SrcClustersLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.SrcClustersLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SrcClustersLayoutPanel.Size = new System.Drawing.Size(159, 63);
            this.SrcClustersLayoutPanel.TabIndex = 29;
            // 
            // SrcClusterLabel
            // 
            this.SrcClusterLabel.AutoSize = true;
            this.SrcClustersLayoutPanel.SetColumnSpan(this.SrcClusterLabel, 2);
            this.SrcClusterLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SrcClusterLabel.Location = new System.Drawing.Point(3, 0);
            this.SrcClusterLabel.Name = "SrcClusterLabel";
            this.SrcClusterLabel.Size = new System.Drawing.Size(153, 15);
            this.SrcClusterLabel.TabIndex = 0;
            this.SrcClusterLabel.Text = "Clusters Per Region";
            this.SrcClusterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // srcClustRowLabel
            // 
            this.srcClustRowLabel.AutoSize = true;
            this.srcClustRowLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.srcClustRowLabel.Location = new System.Drawing.Point(3, 15);
            this.srcClustRowLabel.Name = "srcClustRowLabel";
            this.srcClustRowLabel.Size = new System.Drawing.Size(73, 15);
            this.srcClustRowLabel.TabIndex = 14;
            this.srcClustRowLabel.Text = "Rows";
            this.srcClustRowLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // srcClustColLabel
            // 
            this.srcClustColLabel.AutoSize = true;
            this.srcClustColLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.srcClustColLabel.Location = new System.Drawing.Point(82, 15);
            this.srcClustColLabel.Name = "srcClustColLabel";
            this.srcClustColLabel.Size = new System.Drawing.Size(74, 15);
            this.srcClustColLabel.TabIndex = 15;
            this.srcClustColLabel.Text = "Columns";
            this.srcClustColLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SrcClustRows
            // 
            this.SrcClustRows.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SrcClustRows.Location = new System.Drawing.Point(3, 33);
            this.SrcClustRows.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SrcClustRows.Name = "SrcClustRows";
            this.SrcClustRows.Size = new System.Drawing.Size(73, 23);
            this.SrcClustRows.TabIndex = 12;
            this.SrcClustRows.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // SrcClustCols
            // 
            this.SrcClustCols.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SrcClustCols.Location = new System.Drawing.Point(82, 33);
            this.SrcClustCols.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SrcClustCols.Name = "SrcClustCols";
            this.SrcClustCols.Size = new System.Drawing.Size(74, 23);
            this.SrcClustCols.TabIndex = 13;
            this.SrcClustCols.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // PickIndexLayoutPanel
            // 
            this.PickIndexLayoutPanel.ColumnCount = 2;
            this.PickIndexLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.97484F));
            this.PickIndexLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.02516F));
            this.PickIndexLayoutPanel.Controls.Add(this.PPFLabel, 0, 0);
            this.PickIndexLayoutPanel.Controls.Add(this.PicksPerField, 0, 1);
            this.PickIndexLayoutPanel.Controls.Add(this.StartIndexLabel, 1, 0);
            this.PickIndexLayoutPanel.Controls.Add(this.StartIndex, 1, 1);
            this.PickIndexLayoutPanel.Location = new System.Drawing.Point(3, 365);
            this.PickIndexLayoutPanel.Name = "PickIndexLayoutPanel";
            this.PickIndexLayoutPanel.RowCount = 2;
            this.PickIndexLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.14634F));
            this.PickIndexLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.85366F));
            this.PickIndexLayoutPanel.Size = new System.Drawing.Size(159, 50);
            this.PickIndexLayoutPanel.TabIndex = 30;
            // 
            // PPFLabel
            // 
            this.PPFLabel.AutoSize = true;
            this.PPFLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PPFLabel.Location = new System.Drawing.Point(3, 0);
            this.PPFLabel.Name = "PPFLabel";
            this.PPFLabel.Size = new System.Drawing.Size(83, 17);
            this.PPFLabel.TabIndex = 22;
            this.PPFLabel.Text = "Picks Per Field";
            this.PPFLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PicksPerField
            // 
            this.PicksPerField.AllowDrop = true;
            this.PicksPerField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PicksPerField.Location = new System.Drawing.Point(3, 20);
            this.PicksPerField.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.PicksPerField.Name = "PicksPerField";
            this.PicksPerField.Size = new System.Drawing.Size(83, 23);
            this.PicksPerField.TabIndex = 23;
            this.PicksPerField.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // StartIndexLabel
            // 
            this.StartIndexLabel.AutoSize = true;
            this.StartIndexLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StartIndexLabel.Location = new System.Drawing.Point(92, 0);
            this.StartIndexLabel.Name = "StartIndexLabel";
            this.StartIndexLabel.Size = new System.Drawing.Size(64, 17);
            this.StartIndexLabel.TabIndex = 24;
            this.StartIndexLabel.Text = "Start Index";
            this.StartIndexLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StartIndex
            // 
            this.StartIndex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StartIndex.Location = new System.Drawing.Point(92, 20);
            this.StartIndex.Name = "StartIndex";
            this.StartIndex.Size = new System.Drawing.Size(64, 23);
            this.StartIndex.TabIndex = 25;
            this.StartIndex.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ClickOrderLabel
            // 
            this.ClickOrderLabel.AutoSize = true;
            this.ClickOrderLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ClickOrderLabel.Location = new System.Drawing.Point(3, 418);
            this.ClickOrderLabel.Name = "ClickOrderLabel";
            this.ClickOrderLabel.Size = new System.Drawing.Size(118, 15);
            this.ClickOrderLabel.TabIndex = 25;
            this.ClickOrderLabel.Text = "Preserve Click Order?";
            this.ClickOrderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OrderBoxFlowLayout
            // 
            this.OrderBoxFlowLayout.Controls.Add(this.TgtClickOrderCheckBox);
            this.OrderBoxFlowLayout.Controls.Add(this.SrcClickOrderCheckBox);
            this.OrderBoxFlowLayout.Dock = System.Windows.Forms.DockStyle.Left;
            this.OrderBoxFlowLayout.Location = new System.Drawing.Point(3, 436);
            this.OrderBoxFlowLayout.Name = "OrderBoxFlowLayout";
            this.OrderBoxFlowLayout.Size = new System.Drawing.Size(142, 24);
            this.OrderBoxFlowLayout.TabIndex = 25;
            // 
            // TgtClickOrderCheckBox
            // 
            this.TgtClickOrderCheckBox.AutoSize = true;
            this.TgtClickOrderCheckBox.Location = new System.Drawing.Point(3, 3);
            this.TgtClickOrderCheckBox.Name = "TgtClickOrderCheckBox";
            this.TgtClickOrderCheckBox.Size = new System.Drawing.Size(58, 19);
            this.TgtClickOrderCheckBox.TabIndex = 16;
            this.TgtClickOrderCheckBox.Text = "Target";
            this.TgtClickOrderCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TgtClickOrderCheckBox.UseVisualStyleBackColor = true;
            // 
            // SrcClickOrderCheckBox
            // 
            this.SrcClickOrderCheckBox.AutoSize = true;
            this.SrcClickOrderCheckBox.Location = new System.Drawing.Point(67, 3);
            this.SrcClickOrderCheckBox.Name = "SrcClickOrderCheckBox";
            this.SrcClickOrderCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SrcClickOrderCheckBox.Size = new System.Drawing.Size(62, 19);
            this.SrcClickOrderCheckBox.TabIndex = 24;
            this.SrcClickOrderCheckBox.Text = "Source";
            this.SrcClickOrderCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SrcClickOrderCheckBox.UseVisualStyleBackColor = true;
            // 
            // ButtonLayoutPanel
            // 
            this.ButtonLayoutPanel.ColumnCount = 2;
            this.ButtonLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ButtonLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ButtonLayoutPanel.Controls.Add(this.DrawWafer, 0, 0);
            this.ButtonLayoutPanel.Controls.Add(this.CreateCF, 1, 0);
            this.ButtonLayoutPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ButtonLayoutPanel.Location = new System.Drawing.Point(3, 466);
            this.ButtonLayoutPanel.Name = "ButtonLayoutPanel";
            this.ButtonLayoutPanel.RowCount = 1;
            this.ButtonLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ButtonLayoutPanel.Size = new System.Drawing.Size(159, 47);
            this.ButtonLayoutPanel.TabIndex = 31;
            // 
            // DrawWafer
            // 
            this.DrawWafer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DrawWafer.Location = new System.Drawing.Point(3, 3);
            this.DrawWafer.Name = "DrawWafer";
            this.DrawWafer.Size = new System.Drawing.Size(73, 41);
            this.DrawWafer.TabIndex = 1;
            this.DrawWafer.Text = "Draw Wafers";
            this.DrawWafer.UseVisualStyleBackColor = true;
            this.DrawWafer.Click += new System.EventHandler(this.DrawWafer_Click);
            // 
            // CreateCF
            // 
            this.CreateCF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CreateCF.Location = new System.Drawing.Point(82, 3);
            this.CreateCF.Name = "CreateCF";
            this.CreateCF.Size = new System.Drawing.Size(74, 41);
            this.CreateCF.TabIndex = 3;
            this.CreateCF.Text = "Create Cycle File";
            this.CreateCF.UseVisualStyleBackColor = true;
            this.CreateCF.Click += new System.EventHandler(this.CreateCF_Click);
            // 
            // CFCreatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 620);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CFCreatorForm";
            this.Text = "CFCreator";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.TgtRegLayoutPanel.ResumeLayout(false);
            this.TgtRegLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TgtRegCols)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TgtRegRows)).EndInit();
            this.TgtPrintLayoutPanel.ResumeLayout(false);
            this.TgtPrintLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TgtPrintRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TgtPrintCols)).EndInit();
            this.SrcRegionsLayoutPanel.ResumeLayout(false);
            this.SrcRegionsLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SrcRegRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SrcRegCols)).EndInit();
            this.SrcClustersLayoutPanel.ResumeLayout(false);
            this.SrcClustersLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SrcClustRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SrcClustCols)).EndInit();
            this.PickIndexLayoutPanel.ResumeLayout(false);
            this.PickIndexLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicksPerField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartIndex)).EndInit();
            this.OrderBoxFlowLayout.ResumeLayout(false);
            this.OrderBoxFlowLayout.PerformLayout();
            this.ButtonLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button DrawWafer;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.NumericUpDown TgtRegRows;
        private System.Windows.Forms.NumericUpDown TgtRegCols;
        private System.Windows.Forms.Button CreateCF;
        private System.Windows.Forms.NumericUpDown SrcRegRows;
        private System.Windows.Forms.Label srcRegColLabel;
        private System.Windows.Forms.NumericUpDown SrcRegCols;
        private System.Windows.Forms.NumericUpDown TgtPrintRows;
        private System.Windows.Forms.NumericUpDown TgtPrintCols;
        private System.Windows.Forms.Label TgtPrintRowLabel;
        private System.Windows.Forms.Label TgtPrintColLabel;
        private System.Windows.Forms.NumericUpDown SrcClustRows;
        private System.Windows.Forms.NumericUpDown SrcClustCols;
        private System.Windows.Forms.Label srcRegRowLabel;
        private System.Windows.Forms.Label srcClustRowLabel;
        private System.Windows.Forms.Label srcClustColLabel;
        private System.Windows.Forms.CheckBox TgtClickOrderCheckBox;
        private System.Windows.Forms.Label TargetIDLabel;
        private System.Windows.Forms.TextBox TargetID;
        private System.Windows.Forms.Label SourceIDLabel;
        private System.Windows.Forms.TextBox SourceID;
        private System.Windows.Forms.Label PPFLabel;
        private System.Windows.Forms.NumericUpDown PicksPerField;
        private System.Windows.Forms.FlowLayoutPanel OrderBoxFlowLayout;
        private System.Windows.Forms.CheckBox SrcClickOrderCheckBox;
        private System.Windows.Forms.Label ClickOrderLabel;
        private System.Windows.Forms.TableLayoutPanel TgtRegLayoutPanel;
        private System.Windows.Forms.Label TgtRegLabel;
        private System.Windows.Forms.Label tgtRegRowLabel;
        private System.Windows.Forms.Label tgtRegColsLabel;
        private System.Windows.Forms.TableLayoutPanel TgtPrintLayoutPanel;
        private System.Windows.Forms.Label TgtPrintsLabel;
        private System.Windows.Forms.TableLayoutPanel SrcRegionsLayoutPanel;
        private System.Windows.Forms.Label SrcRegLabel;
        private System.Windows.Forms.TableLayoutPanel SrcClustersLayoutPanel;
        private System.Windows.Forms.Label SrcClusterLabel;
        private System.Windows.Forms.TableLayoutPanel PickIndexLayoutPanel;
        private System.Windows.Forms.Label StartIndexLabel;
        private System.Windows.Forms.NumericUpDown StartIndex;
        private System.Windows.Forms.TableLayoutPanel ButtonLayoutPanel;
    }
}


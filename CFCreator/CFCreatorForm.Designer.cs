
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
            this.tgtRegRowLabel = new System.Windows.Forms.Label();
            this.nudTgtRegRows = new System.Windows.Forms.NumericUpDown();
            this.tgtRegColsLabel = new System.Windows.Forms.Label();
            this.nudTgtRegCols = new System.Windows.Forms.NumericUpDown();
            this.TgtPrintRowLabel = new System.Windows.Forms.Label();
            this.nudTgtPrintRows = new System.Windows.Forms.NumericUpDown();
            this.TgtPrintColLabel = new System.Windows.Forms.Label();
            this.nudTgtPrintCols = new System.Windows.Forms.NumericUpDown();
            this.srcRegRowLabel = new System.Windows.Forms.Label();
            this.nudSrcRegRows = new System.Windows.Forms.NumericUpDown();
            this.srcRegColLabel = new System.Windows.Forms.Label();
            this.nudSrcRegCols = new System.Windows.Forms.NumericUpDown();
            this.srcClustRowLabel = new System.Windows.Forms.Label();
            this.nudSrcClustRows = new System.Windows.Forms.NumericUpDown();
            this.srcClustColLabel = new System.Windows.Forms.Label();
            this.nudSrcClustCols = new System.Windows.Forms.NumericUpDown();
            this.DrawWafer = new System.Windows.Forms.Button();
            this.ClickOrderCheckBox = new System.Windows.Forms.CheckBox();
            this.CreateCF = new System.Windows.Forms.Button();
            this.lblTarget = new System.Windows.Forms.Label();
            this.lblSource = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOpenRecipe = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTgtRegRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTgtRegCols)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTgtPrintRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTgtPrintCols)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSrcRegRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSrcRegCols)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSrcClustRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSrcClustCols)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.06504F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.93496F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblTarget, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblSource, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 46);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1348, 1343);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.tgtRegRowLabel);
            this.flowLayoutPanel1.Controls.Add(this.nudTgtRegRows);
            this.flowLayoutPanel1.Controls.Add(this.tgtRegColsLabel);
            this.flowLayoutPanel1.Controls.Add(this.nudTgtRegCols);
            this.flowLayoutPanel1.Controls.Add(this.TgtPrintRowLabel);
            this.flowLayoutPanel1.Controls.Add(this.nudTgtPrintRows);
            this.flowLayoutPanel1.Controls.Add(this.TgtPrintColLabel);
            this.flowLayoutPanel1.Controls.Add(this.nudTgtPrintCols);
            this.flowLayoutPanel1.Controls.Add(this.srcRegRowLabel);
            this.flowLayoutPanel1.Controls.Add(this.nudSrcRegRows);
            this.flowLayoutPanel1.Controls.Add(this.srcRegColLabel);
            this.flowLayoutPanel1.Controls.Add(this.nudSrcRegCols);
            this.flowLayoutPanel1.Controls.Add(this.srcClustRowLabel);
            this.flowLayoutPanel1.Controls.Add(this.nudSrcClustRows);
            this.flowLayoutPanel1.Controls.Add(this.srcClustColLabel);
            this.flowLayoutPanel1.Controls.Add(this.nudSrcClustCols);
            this.flowLayoutPanel1.Controls.Add(this.DrawWafer);
            this.flowLayoutPanel1.Controls.Add(this.ClickOrderCheckBox);
            this.flowLayoutPanel1.Controls.Add(this.CreateCF);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 6);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.tableLayoutPanel1.SetRowSpan(this.flowLayoutPanel1, 4);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(312, 1331);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // tgtRegRowLabel
            // 
            this.tgtRegRowLabel.AutoSize = true;
            this.tgtRegRowLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tgtRegRowLabel.Location = new System.Drawing.Point(6, 0);
            this.tgtRegRowLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.tgtRegRowLabel.Name = "tgtRegRowLabel";
            this.tgtRegRowLabel.Size = new System.Drawing.Size(293, 32);
            this.tgtRegRowLabel.TabIndex = 0;
            this.tgtRegRowLabel.Text = "Target Region Rows";
            // 
            // nudTgtRegRows
            // 
            this.nudTgtRegRows.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudTgtRegRows.Location = new System.Drawing.Point(6, 38);
            this.nudTgtRegRows.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.nudTgtRegRows.Name = "nudTgtRegRows";
            this.nudTgtRegRows.Size = new System.Drawing.Size(293, 39);
            this.nudTgtRegRows.TabIndex = 1;
            this.nudTgtRegRows.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // tgtRegColsLabel
            // 
            this.tgtRegColsLabel.AutoSize = true;
            this.tgtRegColsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tgtRegColsLabel.Location = new System.Drawing.Point(6, 83);
            this.tgtRegColsLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.tgtRegColsLabel.Name = "tgtRegColsLabel";
            this.tgtRegColsLabel.Size = new System.Drawing.Size(293, 32);
            this.tgtRegColsLabel.TabIndex = 2;
            this.tgtRegColsLabel.Text = "Target Region Columns";
            // 
            // nudTgtRegCols
            // 
            this.nudTgtRegCols.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudTgtRegCols.Location = new System.Drawing.Point(6, 121);
            this.nudTgtRegCols.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.nudTgtRegCols.Name = "nudTgtRegCols";
            this.nudTgtRegCols.Size = new System.Drawing.Size(293, 39);
            this.nudTgtRegCols.TabIndex = 3;
            this.nudTgtRegCols.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // TgtPrintRowLabel
            // 
            this.TgtPrintRowLabel.AutoSize = true;
            this.TgtPrintRowLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TgtPrintRowLabel.Location = new System.Drawing.Point(6, 166);
            this.TgtPrintRowLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.TgtPrintRowLabel.Name = "TgtPrintRowLabel";
            this.TgtPrintRowLabel.Size = new System.Drawing.Size(293, 32);
            this.TgtPrintRowLabel.TabIndex = 10;
            this.TgtPrintRowLabel.Text = "Print Rows";
            // 
            // nudTgtPrintRows
            // 
            this.nudTgtPrintRows.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudTgtPrintRows.Location = new System.Drawing.Point(6, 204);
            this.nudTgtPrintRows.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.nudTgtPrintRows.Name = "nudTgtPrintRows";
            this.nudTgtPrintRows.Size = new System.Drawing.Size(293, 39);
            this.nudTgtPrintRows.TabIndex = 8;
            this.nudTgtPrintRows.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // TgtPrintColLabel
            // 
            this.TgtPrintColLabel.AutoSize = true;
            this.TgtPrintColLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TgtPrintColLabel.Location = new System.Drawing.Point(6, 249);
            this.TgtPrintColLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.TgtPrintColLabel.Name = "TgtPrintColLabel";
            this.TgtPrintColLabel.Size = new System.Drawing.Size(293, 32);
            this.TgtPrintColLabel.TabIndex = 11;
            this.TgtPrintColLabel.Text = "Print Columns";
            // 
            // nudTgtPrintCols
            // 
            this.nudTgtPrintCols.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudTgtPrintCols.Location = new System.Drawing.Point(6, 287);
            this.nudTgtPrintCols.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.nudTgtPrintCols.Name = "nudTgtPrintCols";
            this.nudTgtPrintCols.Size = new System.Drawing.Size(293, 39);
            this.nudTgtPrintCols.TabIndex = 9;
            this.nudTgtPrintCols.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // srcRegRowLabel
            // 
            this.srcRegRowLabel.AutoSize = true;
            this.srcRegRowLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.srcRegRowLabel.Location = new System.Drawing.Point(6, 332);
            this.srcRegRowLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.srcRegRowLabel.Name = "srcRegRowLabel";
            this.srcRegRowLabel.Size = new System.Drawing.Size(293, 32);
            this.srcRegRowLabel.TabIndex = 4;
            this.srcRegRowLabel.Text = "Source Region Rows";
            // 
            // nudSrcRegRows
            // 
            this.nudSrcRegRows.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudSrcRegRows.Location = new System.Drawing.Point(6, 370);
            this.nudSrcRegRows.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.nudSrcRegRows.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSrcRegRows.Name = "nudSrcRegRows";
            this.nudSrcRegRows.Size = new System.Drawing.Size(293, 39);
            this.nudSrcRegRows.TabIndex = 5;
            this.nudSrcRegRows.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // srcRegColLabel
            // 
            this.srcRegColLabel.AutoSize = true;
            this.srcRegColLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.srcRegColLabel.Location = new System.Drawing.Point(6, 415);
            this.srcRegColLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.srcRegColLabel.Name = "srcRegColLabel";
            this.srcRegColLabel.Size = new System.Drawing.Size(293, 32);
            this.srcRegColLabel.TabIndex = 6;
            this.srcRegColLabel.Text = "Source Region Columns";
            // 
            // nudSrcRegCols
            // 
            this.nudSrcRegCols.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudSrcRegCols.Location = new System.Drawing.Point(6, 453);
            this.nudSrcRegCols.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.nudSrcRegCols.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSrcRegCols.Name = "nudSrcRegCols";
            this.nudSrcRegCols.Size = new System.Drawing.Size(293, 39);
            this.nudSrcRegCols.TabIndex = 7;
            this.nudSrcRegCols.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // srcClustRowLabel
            // 
            this.srcClustRowLabel.AutoSize = true;
            this.srcClustRowLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.srcClustRowLabel.Location = new System.Drawing.Point(6, 498);
            this.srcClustRowLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.srcClustRowLabel.Name = "srcClustRowLabel";
            this.srcClustRowLabel.Size = new System.Drawing.Size(293, 32);
            this.srcClustRowLabel.TabIndex = 14;
            this.srcClustRowLabel.Text = "Source Cluster Rows";
            // 
            // nudSrcClustRows
            // 
            this.nudSrcClustRows.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudSrcClustRows.Location = new System.Drawing.Point(6, 536);
            this.nudSrcClustRows.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.nudSrcClustRows.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSrcClustRows.Name = "nudSrcClustRows";
            this.nudSrcClustRows.Size = new System.Drawing.Size(293, 39);
            this.nudSrcClustRows.TabIndex = 12;
            this.nudSrcClustRows.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // srcClustColLabel
            // 
            this.srcClustColLabel.AutoSize = true;
            this.srcClustColLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.srcClustColLabel.Location = new System.Drawing.Point(6, 581);
            this.srcClustColLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.srcClustColLabel.Name = "srcClustColLabel";
            this.srcClustColLabel.Size = new System.Drawing.Size(293, 32);
            this.srcClustColLabel.TabIndex = 15;
            this.srcClustColLabel.Text = "Source Cluster Columns";
            // 
            // nudSrcClustCols
            // 
            this.nudSrcClustCols.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudSrcClustCols.Location = new System.Drawing.Point(6, 619);
            this.nudSrcClustCols.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.nudSrcClustCols.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSrcClustCols.Name = "nudSrcClustCols";
            this.nudSrcClustCols.Size = new System.Drawing.Size(293, 39);
            this.nudSrcClustCols.TabIndex = 13;
            this.nudSrcClustCols.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // DrawWafer
            // 
            this.DrawWafer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DrawWafer.Location = new System.Drawing.Point(6, 670);
            this.DrawWafer.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.DrawWafer.Name = "DrawWafer";
            this.DrawWafer.Size = new System.Drawing.Size(293, 113);
            this.DrawWafer.TabIndex = 1;
            this.DrawWafer.Text = "Draw Wafers";
            this.DrawWafer.UseVisualStyleBackColor = true;
            this.DrawWafer.Click += new System.EventHandler(this.DrawWafer_Click);
            // 
            // ClickOrderCheckBox
            // 
            this.ClickOrderCheckBox.AutoSize = true;
            this.ClickOrderCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ClickOrderCheckBox.Location = new System.Drawing.Point(6, 795);
            this.ClickOrderCheckBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ClickOrderCheckBox.Name = "ClickOrderCheckBox";
            this.ClickOrderCheckBox.Size = new System.Drawing.Size(293, 36);
            this.ClickOrderCheckBox.TabIndex = 16;
            this.ClickOrderCheckBox.Text = "Order cycle file by click";
            this.ClickOrderCheckBox.UseVisualStyleBackColor = true;
            // 
            // CreateCF
            // 
            this.CreateCF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CreateCF.Location = new System.Drawing.Point(6, 843);
            this.CreateCF.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.CreateCF.Name = "CreateCF";
            this.CreateCF.Size = new System.Drawing.Size(293, 90);
            this.CreateCF.TabIndex = 3;
            this.CreateCF.Text = "Create Cycle File";
            this.CreateCF.UseVisualStyleBackColor = true;
            this.CreateCF.Click += new System.EventHandler(this.CreateCF_Click);
            // 
            // lblTarget
            // 
            this.lblTarget.AutoSize = true;
            this.lblTarget.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTarget.Location = new System.Drawing.Point(330, 0);
            this.lblTarget.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTarget.Name = "lblTarget";
            this.lblTarget.Size = new System.Drawing.Size(1012, 43);
            this.lblTarget.TabIndex = 3;
            this.lblTarget.Text = "Target";
            this.lblTarget.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSource.Location = new System.Drawing.Point(330, 671);
            this.lblSource.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(1012, 43);
            this.lblSource.TabIndex = 4;
            this.lblSource.Text = "Source";
            this.lblSource.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(11, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(1348, 46);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiFile
            // 
            this.tsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiOpenRecipe});
            this.tsmiFile.Name = "tsmiFile";
            this.tsmiFile.Size = new System.Drawing.Size(71, 36);
            this.tsmiFile.Text = "File";
            // 
            // tsmiOpenRecipe
            // 
            this.tsmiOpenRecipe.Name = "tsmiOpenRecipe";
            this.tsmiOpenRecipe.Size = new System.Drawing.Size(359, 44);
            this.tsmiOpenRecipe.Text = "Open Recipe";
            this.tsmiOpenRecipe.Click += new System.EventHandler(this.tsmiOpenRecipe_Click);
            // 
            // CFCreatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 1389);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "CFCreatorForm";
            this.Text = "CFCreator";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTgtRegRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTgtRegCols)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTgtPrintRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTgtPrintCols)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSrcRegRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSrcRegCols)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSrcClustRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSrcClustCols)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button DrawWafer;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label tgtRegRowLabel;
        private System.Windows.Forms.NumericUpDown nudTgtRegRows;
        private System.Windows.Forms.Label tgtRegColsLabel;
        private System.Windows.Forms.NumericUpDown nudTgtRegCols;
        private System.Windows.Forms.Button CreateCF;
        private System.Windows.Forms.NumericUpDown nudSrcRegRows;
        private System.Windows.Forms.Label srcRegColLabel;
        private System.Windows.Forms.NumericUpDown nudSrcRegCols;
        private System.Windows.Forms.NumericUpDown nudTgtPrintRows;
        private System.Windows.Forms.NumericUpDown nudTgtPrintCols;
        private System.Windows.Forms.Label TgtPrintRowLabel;
        private System.Windows.Forms.Label TgtPrintColLabel;
        private System.Windows.Forms.NumericUpDown nudSrcClustRows;
        private System.Windows.Forms.NumericUpDown nudSrcClustCols;
        private System.Windows.Forms.Label srcRegRowLabel;
        private System.Windows.Forms.Label srcClustRowLabel;
        private System.Windows.Forms.Label srcClustColLabel;
        private System.Windows.Forms.CheckBox ClickOrderCheckBox;
        private System.Windows.Forms.Label lblTarget;
        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpenRecipe;
    }
}


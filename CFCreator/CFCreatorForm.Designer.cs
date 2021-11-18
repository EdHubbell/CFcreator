
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
            this.TgtRegRows = new System.Windows.Forms.NumericUpDown();
            this.tgtRegColsLabel = new System.Windows.Forms.Label();
            this.TgtRegCols = new System.Windows.Forms.NumericUpDown();
            this.TgtPrintRowLabel = new System.Windows.Forms.Label();
            this.TgtPrintRows = new System.Windows.Forms.NumericUpDown();
            this.TgtPrintColLabel = new System.Windows.Forms.Label();
            this.TgtPrintCols = new System.Windows.Forms.NumericUpDown();
            this.srcRegRowLabel = new System.Windows.Forms.Label();
            this.SrcRegRows = new System.Windows.Forms.NumericUpDown();
            this.srcRegColLabel = new System.Windows.Forms.Label();
            this.SrcRegCols = new System.Windows.Forms.NumericUpDown();
            this.srcClustRowLabel = new System.Windows.Forms.Label();
            this.SrcClustRows = new System.Windows.Forms.NumericUpDown();
            this.srcClustColLabel = new System.Windows.Forms.Label();
            this.SrcClustCols = new System.Windows.Forms.NumericUpDown();
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
            ((System.ComponentModel.ISupportInitialize)(this.TgtRegRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TgtRegCols)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TgtPrintRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TgtPrintCols)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SrcRegRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SrcRegCols)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SrcClustRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SrcClustCols)).BeginInit();
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(726, 627);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.tgtRegRowLabel);
            this.flowLayoutPanel1.Controls.Add(this.TgtRegRows);
            this.flowLayoutPanel1.Controls.Add(this.tgtRegColsLabel);
            this.flowLayoutPanel1.Controls.Add(this.TgtRegCols);
            this.flowLayoutPanel1.Controls.Add(this.TgtPrintRowLabel);
            this.flowLayoutPanel1.Controls.Add(this.TgtPrintRows);
            this.flowLayoutPanel1.Controls.Add(this.TgtPrintColLabel);
            this.flowLayoutPanel1.Controls.Add(this.TgtPrintCols);
            this.flowLayoutPanel1.Controls.Add(this.srcRegRowLabel);
            this.flowLayoutPanel1.Controls.Add(this.SrcRegRows);
            this.flowLayoutPanel1.Controls.Add(this.srcRegColLabel);
            this.flowLayoutPanel1.Controls.Add(this.SrcRegCols);
            this.flowLayoutPanel1.Controls.Add(this.srcClustRowLabel);
            this.flowLayoutPanel1.Controls.Add(this.SrcClustRows);
            this.flowLayoutPanel1.Controls.Add(this.srcClustColLabel);
            this.flowLayoutPanel1.Controls.Add(this.SrcClustCols);
            this.flowLayoutPanel1.Controls.Add(this.DrawWafer);
            this.flowLayoutPanel1.Controls.Add(this.ClickOrderCheckBox);
            this.flowLayoutPanel1.Controls.Add(this.CreateCF);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.tableLayoutPanel1.SetRowSpan(this.flowLayoutPanel1, 4);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(168, 621);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // tgtRegRowLabel
            // 
            this.tgtRegRowLabel.AutoSize = true;
            this.tgtRegRowLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tgtRegRowLabel.Location = new System.Drawing.Point(3, 0);
            this.tgtRegRowLabel.Name = "tgtRegRowLabel";
            this.tgtRegRowLabel.Size = new System.Drawing.Size(148, 15);
            this.tgtRegRowLabel.TabIndex = 0;
            this.tgtRegRowLabel.Text = "Target Region Rows";
            // 
            // TgtRegRows
            // 
            this.TgtRegRows.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TgtRegRows.Location = new System.Drawing.Point(3, 18);
            this.TgtRegRows.Name = "TgtRegRows";
            this.TgtRegRows.Size = new System.Drawing.Size(148, 23);
            this.TgtRegRows.TabIndex = 1;
            this.TgtRegRows.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // tgtRegColsLabel
            // 
            this.tgtRegColsLabel.AutoSize = true;
            this.tgtRegColsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tgtRegColsLabel.Location = new System.Drawing.Point(3, 44);
            this.tgtRegColsLabel.Name = "tgtRegColsLabel";
            this.tgtRegColsLabel.Size = new System.Drawing.Size(148, 15);
            this.tgtRegColsLabel.TabIndex = 2;
            this.tgtRegColsLabel.Text = "Target Region Columns";
            // 
            // TgtRegCols
            // 
            this.TgtRegCols.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TgtRegCols.Location = new System.Drawing.Point(3, 62);
            this.TgtRegCols.Name = "TgtRegCols";
            this.TgtRegCols.Size = new System.Drawing.Size(148, 23);
            this.TgtRegCols.TabIndex = 3;
            this.TgtRegCols.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // TgtPrintRowLabel
            // 
            this.TgtPrintRowLabel.AutoSize = true;
            this.TgtPrintRowLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TgtPrintRowLabel.Location = new System.Drawing.Point(3, 88);
            this.TgtPrintRowLabel.Name = "TgtPrintRowLabel";
            this.TgtPrintRowLabel.Size = new System.Drawing.Size(148, 15);
            this.TgtPrintRowLabel.TabIndex = 10;
            this.TgtPrintRowLabel.Text = "Print Rows";
            // 
            // TgtPrintRows
            // 
            this.TgtPrintRows.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TgtPrintRows.Location = new System.Drawing.Point(3, 106);
            this.TgtPrintRows.Name = "TgtPrintRows";
            this.TgtPrintRows.Size = new System.Drawing.Size(148, 23);
            this.TgtPrintRows.TabIndex = 8;
            this.TgtPrintRows.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // TgtPrintColLabel
            // 
            this.TgtPrintColLabel.AutoSize = true;
            this.TgtPrintColLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TgtPrintColLabel.Location = new System.Drawing.Point(3, 132);
            this.TgtPrintColLabel.Name = "TgtPrintColLabel";
            this.TgtPrintColLabel.Size = new System.Drawing.Size(148, 15);
            this.TgtPrintColLabel.TabIndex = 11;
            this.TgtPrintColLabel.Text = "Print Columns";
            // 
            // TgtPrintCols
            // 
            this.TgtPrintCols.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TgtPrintCols.Location = new System.Drawing.Point(3, 150);
            this.TgtPrintCols.Name = "TgtPrintCols";
            this.TgtPrintCols.Size = new System.Drawing.Size(148, 23);
            this.TgtPrintCols.TabIndex = 9;
            this.TgtPrintCols.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // srcRegRowLabel
            // 
            this.srcRegRowLabel.AutoSize = true;
            this.srcRegRowLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.srcRegRowLabel.Location = new System.Drawing.Point(3, 176);
            this.srcRegRowLabel.Name = "srcRegRowLabel";
            this.srcRegRowLabel.Size = new System.Drawing.Size(148, 15);
            this.srcRegRowLabel.TabIndex = 4;
            this.srcRegRowLabel.Text = "Source Region Rows";
            // 
            // SrcRegRows
            // 
            this.SrcRegRows.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SrcRegRows.Location = new System.Drawing.Point(3, 194);
            this.SrcRegRows.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SrcRegRows.Name = "SrcRegRows";
            this.SrcRegRows.Size = new System.Drawing.Size(148, 23);
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
            this.srcRegColLabel.Location = new System.Drawing.Point(3, 220);
            this.srcRegColLabel.Name = "srcRegColLabel";
            this.srcRegColLabel.Size = new System.Drawing.Size(148, 15);
            this.srcRegColLabel.TabIndex = 6;
            this.srcRegColLabel.Text = "Source Region Columns";
            // 
            // SrcRegCols
            // 
            this.SrcRegCols.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SrcRegCols.Location = new System.Drawing.Point(3, 238);
            this.SrcRegCols.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SrcRegCols.Name = "SrcRegCols";
            this.SrcRegCols.Size = new System.Drawing.Size(148, 23);
            this.SrcRegCols.TabIndex = 7;
            this.SrcRegCols.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // srcClustRowLabel
            // 
            this.srcClustRowLabel.AutoSize = true;
            this.srcClustRowLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.srcClustRowLabel.Location = new System.Drawing.Point(3, 264);
            this.srcClustRowLabel.Name = "srcClustRowLabel";
            this.srcClustRowLabel.Size = new System.Drawing.Size(148, 15);
            this.srcClustRowLabel.TabIndex = 14;
            this.srcClustRowLabel.Text = "Source Cluster Rows";
            // 
            // SrcClustRows
            // 
            this.SrcClustRows.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SrcClustRows.Location = new System.Drawing.Point(3, 282);
            this.SrcClustRows.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SrcClustRows.Name = "SrcClustRows";
            this.SrcClustRows.Size = new System.Drawing.Size(148, 23);
            this.SrcClustRows.TabIndex = 12;
            this.SrcClustRows.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // srcClustColLabel
            // 
            this.srcClustColLabel.AutoSize = true;
            this.srcClustColLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.srcClustColLabel.Location = new System.Drawing.Point(3, 308);
            this.srcClustColLabel.Name = "srcClustColLabel";
            this.srcClustColLabel.Size = new System.Drawing.Size(148, 15);
            this.srcClustColLabel.TabIndex = 15;
            this.srcClustColLabel.Text = "Source Cluster Columns";
            // 
            // SrcClustCols
            // 
            this.SrcClustCols.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SrcClustCols.Location = new System.Drawing.Point(3, 326);
            this.SrcClustCols.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SrcClustCols.Name = "SrcClustCols";
            this.SrcClustCols.Size = new System.Drawing.Size(148, 23);
            this.SrcClustCols.TabIndex = 13;
            this.SrcClustCols.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // DrawWafer
            // 
            this.DrawWafer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DrawWafer.Location = new System.Drawing.Point(3, 355);
            this.DrawWafer.Name = "DrawWafer";
            this.DrawWafer.Size = new System.Drawing.Size(148, 53);
            this.DrawWafer.TabIndex = 1;
            this.DrawWafer.Text = "Draw Wafers";
            this.DrawWafer.UseVisualStyleBackColor = true;
            this.DrawWafer.Click += new System.EventHandler(this.DrawWafer_Click);
            // 
            // ClickOrderCheckBox
            // 
            this.ClickOrderCheckBox.AutoSize = true;
            this.ClickOrderCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ClickOrderCheckBox.Location = new System.Drawing.Point(3, 414);
            this.ClickOrderCheckBox.Name = "ClickOrderCheckBox";
            this.ClickOrderCheckBox.Size = new System.Drawing.Size(148, 19);
            this.ClickOrderCheckBox.TabIndex = 16;
            this.ClickOrderCheckBox.Text = "Order cycle file by click";
            this.ClickOrderCheckBox.UseVisualStyleBackColor = true;
            // 
            // CreateCF
            // 
            this.CreateCF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CreateCF.Location = new System.Drawing.Point(3, 439);
            this.CreateCF.Name = "CreateCF";
            this.CreateCF.Size = new System.Drawing.Size(148, 42);
            this.CreateCF.TabIndex = 3;
            this.CreateCF.Text = "Create Cycle File";
            this.CreateCF.UseVisualStyleBackColor = true;
            this.CreateCF.Click += new System.EventHandler(this.CreateCF_Click);
            // 
            // lblTarget
            // 
            this.lblTarget.AutoSize = true;
            this.lblTarget.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTarget.Location = new System.Drawing.Point(177, 0);
            this.lblTarget.Name = "lblTarget";
            this.lblTarget.Size = new System.Drawing.Size(546, 20);
            this.lblTarget.TabIndex = 3;
            this.lblTarget.Text = "Target";
            this.lblTarget.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSource.Location = new System.Drawing.Point(177, 313);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(546, 20);
            this.lblSource.TabIndex = 4;
            this.lblSource.Text = "Source";
            this.lblSource.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(726, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiFile
            // 
            this.tsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiOpenRecipe});
            this.tsmiFile.Name = "tsmiFile";
            this.tsmiFile.Size = new System.Drawing.Size(37, 20);
            this.tsmiFile.Text = "File";
            // 
            // tsmiOpenRecipe
            // 
            this.tsmiOpenRecipe.Name = "tsmiOpenRecipe";
            this.tsmiOpenRecipe.Size = new System.Drawing.Size(180, 22);
            this.tsmiOpenRecipe.Text = "Open Recipe";
            this.tsmiOpenRecipe.Click += new System.EventHandler(this.tsmiOpenRecipe_Click);
            // 
            // CFCreatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 651);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CFCreatorForm";
            this.Text = "CFCreator";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TgtRegRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TgtRegCols)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TgtPrintRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TgtPrintCols)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SrcRegRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SrcRegCols)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SrcClustRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SrcClustCols)).EndInit();
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
        private System.Windows.Forms.NumericUpDown TgtRegRows;
        private System.Windows.Forms.Label tgtRegColsLabel;
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
        private System.Windows.Forms.CheckBox ClickOrderCheckBox;
        private System.Windows.Forms.Label lblTarget;
        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpenRecipe;
    }
}


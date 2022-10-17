namespace SQLManager.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbDatabases = new System.Windows.Forms.ComboBox();
            this.tbQuery = new System.Windows.Forms.TextBox();
            this.btnExecute = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgResults = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgResults)).BeginInit();
            this.SuspendLayout();
            // 
            // cbDatabases
            // 
            this.cbDatabases.FormattingEnabled = true;
            this.cbDatabases.Location = new System.Drawing.Point(12, 12);
            this.cbDatabases.Name = "cbDatabases";
            this.cbDatabases.Size = new System.Drawing.Size(226, 23);
            this.cbDatabases.TabIndex = 0;
            // 
            // tbQuery
            // 
            this.tbQuery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbQuery.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbQuery.Location = new System.Drawing.Point(0, 0);
            this.tbQuery.Multiline = true;
            this.tbQuery.Name = "tbQuery";
            this.tbQuery.Size = new System.Drawing.Size(887, 403);
            this.tbQuery.TabIndex = 1;
            this.tbQuery.TextChanged += new System.EventHandler(this.TbQuery_TextChanged);
            this.tbQuery.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TbQuery_KeyDown);
            // 
            // btnExecute
            // 
            this.btnExecute.BackColor = System.Drawing.Color.SpringGreen;
            this.btnExecute.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExecute.Enabled = false;
            this.btnExecute.Location = new System.Drawing.Point(241, 10);
            this.btnExecute.Margin = new System.Windows.Forms.Padding(0);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(114, 26);
            this.btnExecute.TabIndex = 2;
            this.btnExecute.Text = "Execute query";
            this.btnExecute.UseVisualStyleBackColor = false;
            this.btnExecute.Click += new System.EventHandler(this.BtnExecute_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(12, 41);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tbQuery);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgResults);
            this.splitContainer1.Size = new System.Drawing.Size(887, 497);
            this.splitContainer1.SplitterDistance = 403;
            this.splitContainer1.TabIndex = 3;
            // 
            // dgResults
            // 
            this.dgResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgResults.Location = new System.Drawing.Point(0, 0);
            this.dgResults.Name = "dgResults";
            this.dgResults.RowTemplate.Height = 25;
            this.dgResults.Size = new System.Drawing.Size(887, 90);
            this.dgResults.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 550);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.cbDatabases);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgResults)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBox cbDatabases;
        private TextBox tbQuery;
        private Button btnExecute;
        private SplitContainer splitContainer1;
        private DataGridView dgResults;
    }
}
namespace procedureExtractor
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
            this.btnExport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbConnectionString = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDirectory = new System.Windows.Forms.TextBox();
            this.radMSSQL = new System.Windows.Forms.RadioButton();
            this.radOracle = new System.Windows.Forms.RadioButton();
            this.tbOwner = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlOwner = new System.Windows.Forms.Panel();
            this.pnlOwner.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(308, 131);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 0;
            this.btnExport.Text = "Start Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Connection String";
            // 
            // tbConnectionString
            // 
            this.tbConnectionString.Location = new System.Drawing.Point(13, 61);
            this.tbConnectionString.Name = "tbConnectionString";
            this.tbConnectionString.Size = new System.Drawing.Size(665, 20);
            this.tbConnectionString.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pasta Alvo";
            // 
            // tbDirectory
            // 
            this.tbDirectory.Location = new System.Drawing.Point(13, 105);
            this.tbDirectory.Name = "tbDirectory";
            this.tbDirectory.Size = new System.Drawing.Size(665, 20);
            this.tbDirectory.TabIndex = 4;
            this.tbDirectory.Text = "D:\\Lixo\\SP Migplus";
            // 
            // radMSSQL
            // 
            this.radMSSQL.AutoSize = true;
            this.radMSSQL.Location = new System.Drawing.Point(13, 13);
            this.radMSSQL.Name = "radMSSQL";
            this.radMSSQL.Size = new System.Drawing.Size(62, 17);
            this.radMSSQL.TabIndex = 5;
            this.radMSSQL.TabStop = true;
            this.radMSSQL.Text = "MSSQL";
            this.radMSSQL.UseVisualStyleBackColor = true;
            // 
            // radOracle
            // 
            this.radOracle.AutoSize = true;
            this.radOracle.Enabled = false;
            this.radOracle.Location = new System.Drawing.Point(105, 13);
            this.radOracle.Name = "radOracle";
            this.radOracle.Size = new System.Drawing.Size(56, 17);
            this.radOracle.TabIndex = 6;
            this.radOracle.TabStop = true;
            this.radOracle.Text = "Oracle";
            this.radOracle.UseVisualStyleBackColor = true;
            this.radOracle.CheckedChanged += new System.EventHandler(this.radOracle_CheckedChanged);
            // 
            // tbOwner
            // 
            this.tbOwner.Location = new System.Drawing.Point(42, 10);
            this.tbOwner.Name = "tbOwner";
            this.tbOwner.Size = new System.Drawing.Size(100, 20);
            this.tbOwner.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Owner";
            // 
            // pnlOwner
            // 
            this.pnlOwner.Controls.Add(this.label3);
            this.pnlOwner.Controls.Add(this.tbOwner);
            this.pnlOwner.Location = new System.Drawing.Point(167, 1);
            this.pnlOwner.Name = "pnlOwner";
            this.pnlOwner.Size = new System.Drawing.Size(145, 40);
            this.pnlOwner.TabIndex = 9;
            this.pnlOwner.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 165);
            this.Controls.Add(this.pnlOwner);
            this.Controls.Add(this.radOracle);
            this.Controls.Add(this.radMSSQL);
            this.Controls.Add(this.tbDirectory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbConnectionString);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExport);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.pnlOwner.ResumeLayout(false);
            this.pnlOwner.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbConnectionString;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDirectory;
        private System.Windows.Forms.RadioButton radMSSQL;
        private System.Windows.Forms.RadioButton radOracle;
        private System.Windows.Forms.TextBox tbOwner;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlOwner;
    }
}


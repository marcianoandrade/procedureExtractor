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
            this.SuspendLayout();
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(308, 100);
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
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Connection String";
            // 
            // tbConnectionString
            // 
            this.tbConnectionString.Location = new System.Drawing.Point(13, 30);
            this.tbConnectionString.Name = "tbConnectionString";
            this.tbConnectionString.Size = new System.Drawing.Size(665, 20);
            this.tbConnectionString.TabIndex = 2;
            this.tbConnectionString.Text = "Data Source=192.168.1.45\\SqlServer2008;Initial Catalog=Mig2;user=sa;pwd=4ut0L1br@" +
    "c0m;Application Name=MES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pasta Alvo";
            // 
            // tbDirectory
            // 
            this.tbDirectory.Location = new System.Drawing.Point(13, 74);
            this.tbDirectory.Name = "tbDirectory";
            this.tbDirectory.Size = new System.Drawing.Size(665, 20);
            this.tbDirectory.TabIndex = 4;
            this.tbDirectory.Text = "D:\\Lixo\\SP Migplus";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 135);
            this.Controls.Add(this.tbDirectory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbConnectionString);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExport);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbConnectionString;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDirectory;
    }
}


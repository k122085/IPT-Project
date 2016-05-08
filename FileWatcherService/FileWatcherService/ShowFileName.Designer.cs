namespace FileWatcherService
{
    partial class ShowFileName
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
            this.nameing = new System.Windows.Forms.TextBox();
            this.kianama = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // nameing
            // 
            this.nameing.Location = new System.Drawing.Point(55, 58);
            this.nameing.Name = "nameing";
            this.nameing.Size = new System.Drawing.Size(187, 20);
            this.nameing.TabIndex = 0;
            // 
            // kianama
            // 
            this.kianama.Location = new System.Drawing.Point(94, 156);
            this.kianama.Name = "kianama";
            this.kianama.Size = new System.Drawing.Size(100, 20);
            this.kianama.TabIndex = 1;
            // 
            // ShowFileName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.kianama);
            this.Controls.Add(this.nameing);
            this.Name = "ShowFileName";
            this.Text = "ShowFileName";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameing;
        private System.Windows.Forms.TextBox kianama;


    }
}
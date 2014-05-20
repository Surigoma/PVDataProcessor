namespace PVDataProcessor
{
    partial class ProcessPrev
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
            this.components = new System.ComponentModel.Container();
            this.ProcessTitle = new System.Windows.Forms.Label();
            this.Bar1 = new System.Windows.Forms.ProgressBar();
            this.Bar2 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // ProcessTitle
            // 
            this.ProcessTitle.AutoSize = true;
            this.ProcessTitle.Location = new System.Drawing.Point(12, 9);
            this.ProcessTitle.Name = "ProcessTitle";
            this.ProcessTitle.Size = new System.Drawing.Size(0, 12);
            this.ProcessTitle.TabIndex = 0;
            // 
            // Bar1
            // 
            this.Bar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Bar1.Location = new System.Drawing.Point(12, 24);
            this.Bar1.Name = "Bar1";
            this.Bar1.Size = new System.Drawing.Size(430, 23);
            this.Bar1.TabIndex = 1;
            // 
            // Bar2
            // 
            this.Bar2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Bar2.Location = new System.Drawing.Point(12, 53);
            this.Bar2.Name = "Bar2";
            this.Bar2.Size = new System.Drawing.Size(430, 23);
            this.Bar2.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ProcessPrev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 87);
            this.Controls.Add(this.Bar2);
            this.Controls.Add(this.Bar1);
            this.Controls.Add(this.ProcessTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ProcessPrev";
            this.Text = "PVDataProcesser - Processing...";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ProcessPrev_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ProcessTitle;
        private System.Windows.Forms.ProgressBar Bar1;
        private System.Windows.Forms.ProgressBar Bar2;
        private System.Windows.Forms.Timer timer1;
    }
}
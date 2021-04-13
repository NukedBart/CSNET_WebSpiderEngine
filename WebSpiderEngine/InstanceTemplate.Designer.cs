namespace WebSpiderEngine
{
    partial class InstanceTemplate
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
            this.label1 = new System.Windows.Forms.Label();
            this.InstanceLog = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 269);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your controls here";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Visible = false;
            // 
            // InstanceLog
            // 
            this.InstanceLog.AcceptsReturn = true;
            this.InstanceLog.AcceptsTab = true;
            this.InstanceLog.BackColor = System.Drawing.SystemColors.MenuText;
            this.InstanceLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InstanceLog.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.InstanceLog.Location = new System.Drawing.Point(180, 0);
            this.InstanceLog.Multiline = true;
            this.InstanceLog.Name = "InstanceLog";
            this.InstanceLog.ReadOnly = true;
            this.InstanceLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.InstanceLog.Size = new System.Drawing.Size(398, 269);
            this.InstanceLog.TabIndex = 1;
            // 
            // InstanceTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 269);
            this.Controls.Add(this.InstanceLog);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InstanceTemplate";
            this.Text = "InstanceTemplate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox InstanceLog;
    }
}
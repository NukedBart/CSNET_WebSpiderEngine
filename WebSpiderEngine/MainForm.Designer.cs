namespace WebSpiderEngine
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
            this.JustALabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // JustALabel
            // 
            this.JustALabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.JustALabel.Location = new System.Drawing.Point(0, 0);
            this.JustALabel.Name = "JustALabel";
            this.JustALabel.Size = new System.Drawing.Size(800, 450);
            this.JustALabel.TabIndex = 0;
            this.JustALabel.Text = "Your controls here";
            this.JustALabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.JustALabel.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.JustALabel);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label JustALabel;
    }
}


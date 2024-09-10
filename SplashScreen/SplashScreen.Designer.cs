namespace SplashScreen
{
    partial class SplashScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
            this.splashTimer = new System.Windows.Forms.Timer(this.components);
            this.statusLabel = new System.Windows.Forms.Label();
            this.statusPanel = new System.Windows.Forms.Panel();
            this.runningPictureBox = new System.Windows.Forms.PictureBox();
            this.statusPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.runningPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // splashTimer
            // 
            this.splashTimer.Tick += new System.EventHandler(this.SplashTimer_Tick);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.BackColor = System.Drawing.Color.Transparent;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.Location = new System.Drawing.Point(8, 11);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(51, 20);
            this.statusLabel.TabIndex = 0;
            this.statusLabel.Text = "label1";
            // 
            // statusPanel
            // 
            this.statusPanel.BackColor = System.Drawing.Color.Transparent;
            this.statusPanel.Controls.Add(this.runningPictureBox);
            this.statusPanel.Location = new System.Drawing.Point(12, 34);
            this.statusPanel.Name = "statusPanel";
            this.statusPanel.Size = new System.Drawing.Size(714, 32);
            this.statusPanel.TabIndex = 1;
            // 
            // runningPictureBox
            // 
            this.runningPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.runningPictureBox.Image = global::SplashScreen.Properties.Resources.pixel_cat;
            this.runningPictureBox.InitialImage = global::SplashScreen.Properties.Resources.pixel_cat;
            this.runningPictureBox.Location = new System.Drawing.Point(525, -33);
            this.runningPictureBox.Name = "runningPictureBox";
            this.runningPictureBox.Size = new System.Drawing.Size(193, 78);
            this.runningPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.runningPictureBox.TabIndex = 2;
            this.runningPictureBox.TabStop = false;
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(742, 79);
            this.Controls.Add(this.statusPanel);
            this.Controls.Add(this.statusLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashScreen";
            this.statusPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.runningPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer splashTimer;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Panel statusPanel;
        private System.Windows.Forms.PictureBox runningPictureBox;
    }
}
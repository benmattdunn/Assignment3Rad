namespace Assignment3RAD
{
    /// <summary>
    /// Created by Ben M. Dunn 
    /// Student #100098171
    /// Final Version 11, novemeber 2016
    /// 
    /// see splashScreen.cs for more information. 
    /// </summary>
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
            this.SplashScreenProgressBar = new System.Windows.Forms.ProgressBar();
            this.SplashScreenTimer = new System.Windows.Forms.Timer(this.components);
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SplashScreenProgressBar
            // 
            this.SplashScreenProgressBar.Location = new System.Drawing.Point(13, 395);
            this.SplashScreenProgressBar.MarqueeAnimationSpeed = 1;
            this.SplashScreenProgressBar.Maximum = 320;
            this.SplashScreenProgressBar.Name = "SplashScreenProgressBar";
            this.SplashScreenProgressBar.Size = new System.Drawing.Size(795, 23);
            this.SplashScreenProgressBar.Step = 2;
            this.SplashScreenProgressBar.TabIndex = 0;
            // 
            // SplashScreenTimer
            // 
            this.SplashScreenTimer.Interval = 1;
            this.SplashScreenTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.BackgroundImage = global::Assignment3RAD.Properties.Resources.Logo;
            this.LogoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LogoPictureBox.Location = new System.Drawing.Point(13, 13);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.Size = new System.Drawing.Size(795, 405);
            this.LogoPictureBox.TabIndex = 1;
            this.LogoPictureBox.TabStop = false;
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 430);
            this.ControlBox = false;
            this.Controls.Add(this.SplashScreenProgressBar);
            this.Controls.Add(this.LogoPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movie Bonnanza";
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar SplashScreenProgressBar;
        private System.Windows.Forms.PictureBox LogoPictureBox;
        private System.Windows.Forms.Timer SplashScreenTimer;
    }
}


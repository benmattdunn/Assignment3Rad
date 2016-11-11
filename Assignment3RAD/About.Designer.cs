namespace Assignment3RAD
{
    /// <summary>
    /// Created by Ben M. Dunn 
    /// Student #100098171
    /// Final Version 11, novemeber 2016
    /// See about.cs for further details. 
    /// 
    /// </summary>
    partial class About
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
            this.MainLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.CreatedByLabel = new System.Windows.Forms.Label();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.MovieBanzaiLinkLabel = new System.Windows.Forms.LinkLabel();
            this.MainLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainLayoutPanel
            // 
            this.MainLayoutPanel.ColumnCount = 1;
            this.MainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainLayoutPanel.Controls.Add(this.TitleLabel, 0, 0);
            this.MainLayoutPanel.Controls.Add(this.CreatedByLabel, 0, 1);
            this.MainLayoutPanel.Controls.Add(this.VersionLabel, 0, 2);
            this.MainLayoutPanel.Controls.Add(this.MovieBanzaiLinkLabel, 0, 3);
            this.MainLayoutPanel.Location = new System.Drawing.Point(12, 12);
            this.MainLayoutPanel.Name = "MainLayoutPanel";
            this.MainLayoutPanel.RowCount = 5;
            this.MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.62069F));
            this.MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.37931F));
            this.MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 147F));
            this.MainLayoutPanel.Size = new System.Drawing.Size(160, 238);
            this.MainLayoutPanel.TabIndex = 0;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(3, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(153, 15);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Movie Banzai Software";
            // 
            // CreatedByLabel
            // 
            this.CreatedByLabel.AutoSize = true;
            this.CreatedByLabel.Location = new System.Drawing.Point(3, 29);
            this.CreatedByLabel.Name = "CreatedByLabel";
            this.CreatedByLabel.Size = new System.Drawing.Size(110, 13);
            this.CreatedByLabel.TabIndex = 1;
            this.CreatedByLabel.Text = "Created By Ben Dunn";
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.Location = new System.Drawing.Point(3, 49);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(60, 13);
            this.VersionLabel.TabIndex = 2;
            this.VersionLabel.Text = "Version 1.0";
            // 
            // MovieBanzaiLinkLabel
            // 
            this.MovieBanzaiLinkLabel.AutoSize = true;
            this.MovieBanzaiLinkLabel.Location = new System.Drawing.Point(3, 66);
            this.MovieBanzaiLinkLabel.Name = "MovieBanzaiLinkLabel";
            this.MovieBanzaiLinkLabel.Size = new System.Drawing.Size(94, 13);
            this.MovieBanzaiLinkLabel.TabIndex = 3;
            this.MovieBanzaiLinkLabel.TabStop = true;
            this.MovieBanzaiLinkLabel.Text = "Movie Banzai Link";
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 108);
            this.Controls.Add(this.MainLayoutPanel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "About";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            this.MainLayoutPanel.ResumeLayout(false);
            this.MainLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainLayoutPanel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label CreatedByLabel;
        private System.Windows.Forms.Label VersionLabel;
        private System.Windows.Forms.LinkLabel MovieBanzaiLinkLabel;
    }
}
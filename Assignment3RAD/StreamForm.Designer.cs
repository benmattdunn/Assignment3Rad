namespace Assignment3RAD
{
    partial class StreamForm
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
            this.MessageLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.CenterOkBttnLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.OKButton = new System.Windows.Forms.Button();
            this.FinalMessageLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.TitleMessagelabel = new System.Windows.Forms.Label();
            this.ChargeLabel = new System.Windows.Forms.Label();
            this.MovieLabel = new System.Windows.Forms.Label();
            this.MessageLayoutPanel.SuspendLayout();
            this.CenterOkBttnLayoutPanel.SuspendLayout();
            this.FinalMessageLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MessageLayoutPanel
            // 
            this.MessageLayoutPanel.ColumnCount = 1;
            this.MessageLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MessageLayoutPanel.Controls.Add(this.CenterOkBttnLayoutPanel, 0, 1);
            this.MessageLayoutPanel.Controls.Add(this.FinalMessageLayoutPanel, 0, 0);
            this.MessageLayoutPanel.Location = new System.Drawing.Point(13, 13);
            this.MessageLayoutPanel.Name = "MessageLayoutPanel";
            this.MessageLayoutPanel.RowCount = 2;
            this.MessageLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.91241F));
            this.MessageLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.08759F));
            this.MessageLayoutPanel.Size = new System.Drawing.Size(259, 137);
            this.MessageLayoutPanel.TabIndex = 0;
            // 
            // CenterOkBttnLayoutPanel
            // 
            this.CenterOkBttnLayoutPanel.ColumnCount = 3;
            this.CenterOkBttnLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CenterOkBttnLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.CenterOkBttnLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CenterOkBttnLayoutPanel.Controls.Add(this.OKButton, 1, 0);
            this.CenterOkBttnLayoutPanel.Location = new System.Drawing.Point(3, 106);
            this.CenterOkBttnLayoutPanel.Name = "CenterOkBttnLayoutPanel";
            this.CenterOkBttnLayoutPanel.RowCount = 1;
            this.CenterOkBttnLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.CenterOkBttnLayoutPanel.Size = new System.Drawing.Size(253, 28);
            this.CenterOkBttnLayoutPanel.TabIndex = 0;
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(96, 3);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(60, 22);
            this.OKButton.TabIndex = 0;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // FinalMessageLayoutPanel
            // 
            this.FinalMessageLayoutPanel.ColumnCount = 1;
            this.FinalMessageLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.FinalMessageLayoutPanel.Controls.Add(this.TitleMessagelabel, 0, 0);
            this.FinalMessageLayoutPanel.Controls.Add(this.ChargeLabel, 0, 1);
            this.FinalMessageLayoutPanel.Controls.Add(this.MovieLabel, 0, 2);
            this.FinalMessageLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.FinalMessageLayoutPanel.Name = "FinalMessageLayoutPanel";
            this.FinalMessageLayoutPanel.RowCount = 3;
            this.FinalMessageLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.FinalMessageLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.FinalMessageLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.FinalMessageLayoutPanel.Size = new System.Drawing.Size(253, 97);
            this.FinalMessageLayoutPanel.TabIndex = 1;
            // 
            // TitleMessagelabel
            // 
            this.TitleMessagelabel.AutoSize = true;
            this.TitleMessagelabel.Location = new System.Drawing.Point(3, 0);
            this.TitleMessagelabel.Name = "TitleMessagelabel";
            this.TitleMessagelabel.Size = new System.Drawing.Size(35, 13);
            this.TitleMessagelabel.TabIndex = 0;
            this.TitleMessagelabel.Text = "label1";
            // 
            // ChargeLabel
            // 
            this.ChargeLabel.AutoSize = true;
            this.ChargeLabel.Location = new System.Drawing.Point(3, 32);
            this.ChargeLabel.Name = "ChargeLabel";
            this.ChargeLabel.Size = new System.Drawing.Size(35, 13);
            this.ChargeLabel.TabIndex = 1;
            this.ChargeLabel.Text = "label2";
            // 
            // MovieLabel
            // 
            this.MovieLabel.AutoSize = true;
            this.MovieLabel.Location = new System.Drawing.Point(3, 64);
            this.MovieLabel.Name = "MovieLabel";
            this.MovieLabel.Size = new System.Drawing.Size(35, 13);
            this.MovieLabel.TabIndex = 2;
            this.MovieLabel.Text = "label3";
            // 
            // StreamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(284, 162);
            this.ControlBox = false;
            this.Controls.Add(this.MessageLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StreamForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Your Movie Is about to start!";
            this.MessageLayoutPanel.ResumeLayout(false);
            this.CenterOkBttnLayoutPanel.ResumeLayout(false);
            this.FinalMessageLayoutPanel.ResumeLayout(false);
            this.FinalMessageLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MessageLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel CenterOkBttnLayoutPanel;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.TableLayoutPanel FinalMessageLayoutPanel;
        private System.Windows.Forms.Label TitleMessagelabel;
        private System.Windows.Forms.Label ChargeLabel;
        private System.Windows.Forms.Label MovieLabel;
    }
}
using System.Threading;

namespace Assignment3RAD
{
    partial class OrderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        public SelectionForm _previousForm;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            //disposing of threads to prevent errors in forms movement. 
            this._running = false;
            this._smartAbortThread(this._movieCostCalculator);
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// Saftly aborts a thread by making sure it's finished it's scope, then killing
        /// it to prevent multithreading handups do to access on use of the abort method.
        /// because of the blocking of code. Copied from previous assignment for ease
        /// of use. 
        /// 
        /// copied from assignment 1.
        /// </summary>
        /// <param name="abortThisThread">Thread to safely abort</param>
        private void _smartAbortThread(Thread abortThisThread)
        {
            bool threadNotAborted = true;
            do
            {
                try
                {
                    abortThisThread.Abort();
                    threadNotAborted = false; // will be blocked if failed.
                }
                catch (System.Exception)
                {
                    //do nothing, try again, because of the blocking nature of 
                    // code execution of try/catch I can be sure that it will
                    // keep attempting until the thread is successfully aborted.
                }

            } while (threadNotAborted);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.OrderFormMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.streamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OrderFormMainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.MovieSelectedGroupBox = new System.Windows.Forms.GroupBox();
            this.MovieSelectedTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.MovieTitleLabel = new System.Windows.Forms.Label();
            this.CatagoryLabel = new System.Windows.Forms.Label();
            this.MovieTitleTextBox = new System.Windows.Forms.TextBox();
            this.CatagoryTextBox = new System.Windows.Forms.TextBox();
            this.OrderButtonsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.YourSelectionGroupBox = new System.Windows.Forms.GroupBox();
            this.OrderTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.CostTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.CostTextBox = new System.Windows.Forms.TextBox();
            this.Costlabel = new System.Windows.Forms.Label();
            this.SubTotalTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.SubTotalTextBox = new System.Windows.Forms.TextBox();
            this.SubTotalLabel = new System.Windows.Forms.Label();
            this.SalesTaxTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.SalesTaxTextBox = new System.Windows.Forms.TextBox();
            this.SalesTaxLabel = new System.Windows.Forms.Label();
            this.GrandTotalTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.GrandTotalTextBox = new System.Windows.Forms.TextBox();
            this.GrandTotalLabel = new System.Windows.Forms.Label();
            this.OwnMovieCheckBox = new System.Windows.Forms.CheckBox();
            this.ButtonsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.CancelButton = new System.Windows.Forms.Button();
            this.StreamButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.MoviePictureBox = new System.Windows.Forms.PictureBox();
            this.OrderFormMenuStrip.SuspendLayout();
            this.OrderFormMainTableLayoutPanel.SuspendLayout();
            this.MovieSelectedGroupBox.SuspendLayout();
            this.MovieSelectedTableLayout.SuspendLayout();
            this.OrderButtonsTableLayoutPanel.SuspendLayout();
            this.YourSelectionGroupBox.SuspendLayout();
            this.OrderTableLayoutPanel.SuspendLayout();
            this.CostTableLayoutPanel.SuspendLayout();
            this.SubTotalTableLayoutPanel.SuspendLayout();
            this.SalesTaxTableLayoutPanel.SuspendLayout();
            this.GrandTotalTableLayoutPanel.SuspendLayout();
            this.ButtonsTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MoviePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // OrderFormMenuStrip
            // 
            this.OrderFormMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.OrderFormMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.OrderFormMenuStrip.Name = "OrderFormMenuStrip";
            this.OrderFormMenuStrip.Size = new System.Drawing.Size(639, 24);
            this.OrderFormMenuStrip.TabIndex = 0;
            this.OrderFormMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem,
            this.streamToolStripMenuItem,
            this.cancelToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printClick);
            // 
            // streamToolStripMenuItem
            // 
            this.streamToolStripMenuItem.Name = "streamToolStripMenuItem";
            this.streamToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.streamToolStripMenuItem.Text = "Stream";
            this.streamToolStripMenuItem.Click += new System.EventHandler(this.StreamClick);
            // 
            // cancelToolStripMenuItem
            // 
            this.cancelToolStripMenuItem.Name = "cancelToolStripMenuItem";
            this.cancelToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.cancelToolStripMenuItem.Text = "Cancel";
            this.cancelToolStripMenuItem.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // OrderFormMainTableLayoutPanel
            // 
            this.OrderFormMainTableLayoutPanel.ColumnCount = 2;
            this.OrderFormMainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.OrderFormMainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.OrderFormMainTableLayoutPanel.Controls.Add(this.MovieSelectedGroupBox, 0, 0);
            this.OrderFormMainTableLayoutPanel.Controls.Add(this.OrderButtonsTableLayoutPanel, 1, 0);
            this.OrderFormMainTableLayoutPanel.Location = new System.Drawing.Point(13, 28);
            this.OrderFormMainTableLayoutPanel.Name = "OrderFormMainTableLayoutPanel";
            this.OrderFormMainTableLayoutPanel.RowCount = 1;
            this.OrderFormMainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.OrderFormMainTableLayoutPanel.Size = new System.Drawing.Size(614, 431);
            this.OrderFormMainTableLayoutPanel.TabIndex = 1;
            // 
            // MovieSelectedGroupBox
            // 
            this.MovieSelectedGroupBox.Controls.Add(this.MovieSelectedTableLayout);
            this.MovieSelectedGroupBox.Location = new System.Drawing.Point(3, 3);
            this.MovieSelectedGroupBox.Name = "MovieSelectedGroupBox";
            this.MovieSelectedGroupBox.Size = new System.Drawing.Size(301, 425);
            this.MovieSelectedGroupBox.TabIndex = 1;
            this.MovieSelectedGroupBox.TabStop = false;
            this.MovieSelectedGroupBox.Text = "Movie Selected";
            // 
            // MovieSelectedTableLayout
            // 
            this.MovieSelectedTableLayout.ColumnCount = 1;
            this.MovieSelectedTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MovieSelectedTableLayout.Controls.Add(this.MovieTitleLabel, 0, 0);
            this.MovieSelectedTableLayout.Controls.Add(this.CatagoryLabel, 0, 2);
            this.MovieSelectedTableLayout.Controls.Add(this.MovieTitleTextBox, 0, 1);
            this.MovieSelectedTableLayout.Controls.Add(this.CatagoryTextBox, 0, 3);
            this.MovieSelectedTableLayout.Controls.Add(this.MoviePictureBox, 0, 4);
            this.MovieSelectedTableLayout.Location = new System.Drawing.Point(6, 19);
            this.MovieSelectedTableLayout.Name = "MovieSelectedTableLayout";
            this.MovieSelectedTableLayout.RowCount = 5;
            this.MovieSelectedTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.299061F));
            this.MovieSelectedTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.299061F));
            this.MovieSelectedTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.299061F));
            this.MovieSelectedTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.299061F));
            this.MovieSelectedTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.80376F));
            this.MovieSelectedTableLayout.Size = new System.Drawing.Size(289, 400);
            this.MovieSelectedTableLayout.TabIndex = 0;
            // 
            // MovieTitleLabel
            // 
            this.MovieTitleLabel.AutoSize = true;
            this.MovieTitleLabel.Location = new System.Drawing.Point(3, 10);
            this.MovieTitleLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.MovieTitleLabel.Name = "MovieTitleLabel";
            this.MovieTitleLabel.Size = new System.Drawing.Size(65, 13);
            this.MovieTitleLabel.TabIndex = 0;
            this.MovieTitleLabel.Text = "Movie Title :";
            // 
            // CatagoryLabel
            // 
            this.CatagoryLabel.AutoSize = true;
            this.CatagoryLabel.Location = new System.Drawing.Point(3, 68);
            this.CatagoryLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.CatagoryLabel.Name = "CatagoryLabel";
            this.CatagoryLabel.Size = new System.Drawing.Size(58, 13);
            this.CatagoryLabel.TabIndex = 1;
            this.CatagoryLabel.Text = "Catagory : ";
            // 
            // MovieTitleTextBox
            // 
            this.MovieTitleTextBox.Location = new System.Drawing.Point(3, 32);
            this.MovieTitleTextBox.Name = "MovieTitleTextBox";
            this.MovieTitleTextBox.ReadOnly = true;
            this.MovieTitleTextBox.Size = new System.Drawing.Size(283, 20);
            this.MovieTitleTextBox.TabIndex = 2;
            // 
            // CatagoryTextBox
            // 
            this.CatagoryTextBox.Location = new System.Drawing.Point(3, 90);
            this.CatagoryTextBox.Name = "CatagoryTextBox";
            this.CatagoryTextBox.ReadOnly = true;
            this.CatagoryTextBox.Size = new System.Drawing.Size(283, 20);
            this.CatagoryTextBox.TabIndex = 3;
            // 
            // OrderButtonsTableLayoutPanel
            // 
            this.OrderButtonsTableLayoutPanel.ColumnCount = 1;
            this.OrderButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.OrderButtonsTableLayoutPanel.Controls.Add(this.YourSelectionGroupBox, 0, 0);
            this.OrderButtonsTableLayoutPanel.Controls.Add(this.ButtonsTableLayoutPanel, 0, 1);
            this.OrderButtonsTableLayoutPanel.Location = new System.Drawing.Point(310, 3);
            this.OrderButtonsTableLayoutPanel.Name = "OrderButtonsTableLayoutPanel";
            this.OrderButtonsTableLayoutPanel.RowCount = 2;
            this.OrderButtonsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.82353F));
            this.OrderButtonsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.17647F));
            this.OrderButtonsTableLayoutPanel.Size = new System.Drawing.Size(301, 425);
            this.OrderButtonsTableLayoutPanel.TabIndex = 2;
            // 
            // YourSelectionGroupBox
            // 
            this.YourSelectionGroupBox.Controls.Add(this.OrderTableLayoutPanel);
            this.YourSelectionGroupBox.Location = new System.Drawing.Point(3, 3);
            this.YourSelectionGroupBox.Name = "YourSelectionGroupBox";
            this.YourSelectionGroupBox.Size = new System.Drawing.Size(295, 363);
            this.YourSelectionGroupBox.TabIndex = 0;
            this.YourSelectionGroupBox.TabStop = false;
            this.YourSelectionGroupBox.Text = "Your Selection";
            // 
            // OrderTableLayoutPanel
            // 
            this.OrderTableLayoutPanel.ColumnCount = 1;
            this.OrderTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.OrderTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.OrderTableLayoutPanel.Controls.Add(this.CostTableLayoutPanel, 0, 1);
            this.OrderTableLayoutPanel.Controls.Add(this.SubTotalTableLayoutPanel, 0, 3);
            this.OrderTableLayoutPanel.Controls.Add(this.SalesTaxTableLayoutPanel, 0, 4);
            this.OrderTableLayoutPanel.Controls.Add(this.GrandTotalTableLayoutPanel, 0, 5);
            this.OrderTableLayoutPanel.Controls.Add(this.OwnMovieCheckBox, 0, 6);
            this.OrderTableLayoutPanel.Location = new System.Drawing.Point(7, 19);
            this.OrderTableLayoutPanel.Name = "OrderTableLayoutPanel";
            this.OrderTableLayoutPanel.RowCount = 7;
            this.OrderTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.OrderTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.OrderTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.OrderTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.OrderTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.OrderTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.OrderTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.OrderTableLayoutPanel.Size = new System.Drawing.Size(282, 343);
            this.OrderTableLayoutPanel.TabIndex = 0;
            // 
            // CostTableLayoutPanel
            // 
            this.CostTableLayoutPanel.ColumnCount = 4;
            this.CostTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.695652F));
            this.CostTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.94203F));
            this.CostTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.49275F));
            this.CostTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.5942F));
            this.CostTableLayoutPanel.Controls.Add(this.CostTextBox, 2, 0);
            this.CostTableLayoutPanel.Controls.Add(this.Costlabel, 1, 0);
            this.CostTableLayoutPanel.Location = new System.Drawing.Point(3, 51);
            this.CostTableLayoutPanel.Name = "CostTableLayoutPanel";
            this.CostTableLayoutPanel.RowCount = 1;
            this.CostTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.CostTableLayoutPanel.Size = new System.Drawing.Size(276, 42);
            this.CostTableLayoutPanel.TabIndex = 0;
            // 
            // CostTextBox
            // 
            this.CostTextBox.Location = new System.Drawing.Point(138, 3);
            this.CostTextBox.Name = "CostTextBox";
            this.CostTextBox.ReadOnly = true;
            this.CostTextBox.Size = new System.Drawing.Size(100, 20);
            this.CostTextBox.TabIndex = 0;
            // 
            // Costlabel
            // 
            this.Costlabel.AutoSize = true;
            this.Costlabel.Location = new System.Drawing.Point(26, 0);
            this.Costlabel.Name = "Costlabel";
            this.Costlabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.Costlabel.Size = new System.Drawing.Size(34, 18);
            this.Costlabel.TabIndex = 1;
            this.Costlabel.Text = "Cost: ";
            // 
            // SubTotalTableLayoutPanel
            // 
            this.SubTotalTableLayoutPanel.ColumnCount = 4;
            this.SubTotalTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.695652F));
            this.SubTotalTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.94203F));
            this.SubTotalTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.49275F));
            this.SubTotalTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.5942F));
            this.SubTotalTableLayoutPanel.Controls.Add(this.SubTotalTextBox, 2, 0);
            this.SubTotalTableLayoutPanel.Controls.Add(this.SubTotalLabel, 1, 0);
            this.SubTotalTableLayoutPanel.Location = new System.Drawing.Point(3, 147);
            this.SubTotalTableLayoutPanel.Name = "SubTotalTableLayoutPanel";
            this.SubTotalTableLayoutPanel.RowCount = 1;
            this.SubTotalTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SubTotalTableLayoutPanel.Size = new System.Drawing.Size(276, 42);
            this.SubTotalTableLayoutPanel.TabIndex = 0;
            // 
            // SubTotalTextBox
            // 
            this.SubTotalTextBox.Location = new System.Drawing.Point(138, 3);
            this.SubTotalTextBox.Name = "SubTotalTextBox";
            this.SubTotalTextBox.ReadOnly = true;
            this.SubTotalTextBox.Size = new System.Drawing.Size(100, 20);
            this.SubTotalTextBox.TabIndex = 0;
            // 
            // SubTotalLabel
            // 
            this.SubTotalLabel.AutoSize = true;
            this.SubTotalLabel.Location = new System.Drawing.Point(26, 0);
            this.SubTotalLabel.Name = "SubTotalLabel";
            this.SubTotalLabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.SubTotalLabel.Size = new System.Drawing.Size(59, 18);
            this.SubTotalLabel.TabIndex = 1;
            this.SubTotalLabel.Text = "Sub Total: ";
            // 
            // SalesTaxTableLayoutPanel
            // 
            this.SalesTaxTableLayoutPanel.ColumnCount = 4;
            this.SalesTaxTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.695652F));
            this.SalesTaxTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.94203F));
            this.SalesTaxTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.49275F));
            this.SalesTaxTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.5942F));
            this.SalesTaxTableLayoutPanel.Controls.Add(this.SalesTaxTextBox, 2, 0);
            this.SalesTaxTableLayoutPanel.Controls.Add(this.SalesTaxLabel, 1, 0);
            this.SalesTaxTableLayoutPanel.Location = new System.Drawing.Point(3, 195);
            this.SalesTaxTableLayoutPanel.Name = "SalesTaxTableLayoutPanel";
            this.SalesTaxTableLayoutPanel.RowCount = 1;
            this.SalesTaxTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SalesTaxTableLayoutPanel.Size = new System.Drawing.Size(276, 42);
            this.SalesTaxTableLayoutPanel.TabIndex = 0;
            // 
            // SalesTaxTextBox
            // 
            this.SalesTaxTextBox.Location = new System.Drawing.Point(138, 3);
            this.SalesTaxTextBox.Name = "SalesTaxTextBox";
            this.SalesTaxTextBox.ReadOnly = true;
            this.SalesTaxTextBox.Size = new System.Drawing.Size(100, 20);
            this.SalesTaxTextBox.TabIndex = 0;
            // 
            // SalesTaxLabel
            // 
            this.SalesTaxLabel.AutoSize = true;
            this.SalesTaxLabel.Location = new System.Drawing.Point(26, 0);
            this.SalesTaxLabel.Name = "SalesTaxLabel";
            this.SalesTaxLabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.SalesTaxLabel.Size = new System.Drawing.Size(86, 18);
            this.SalesTaxLabel.TabIndex = 1;
            this.SalesTaxLabel.Text = "Sales Tax 13% : ";
            // 
            // GrandTotalTableLayoutPanel
            // 
            this.GrandTotalTableLayoutPanel.ColumnCount = 4;
            this.GrandTotalTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.695652F));
            this.GrandTotalTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.94203F));
            this.GrandTotalTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.49275F));
            this.GrandTotalTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.5942F));
            this.GrandTotalTableLayoutPanel.Controls.Add(this.GrandTotalTextBox, 2, 0);
            this.GrandTotalTableLayoutPanel.Controls.Add(this.GrandTotalLabel, 1, 0);
            this.GrandTotalTableLayoutPanel.Location = new System.Drawing.Point(3, 243);
            this.GrandTotalTableLayoutPanel.Name = "GrandTotalTableLayoutPanel";
            this.GrandTotalTableLayoutPanel.RowCount = 1;
            this.GrandTotalTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.GrandTotalTableLayoutPanel.Size = new System.Drawing.Size(276, 42);
            this.GrandTotalTableLayoutPanel.TabIndex = 0;
            // 
            // GrandTotalTextBox
            // 
            this.GrandTotalTextBox.Location = new System.Drawing.Point(138, 3);
            this.GrandTotalTextBox.Name = "GrandTotalTextBox";
            this.GrandTotalTextBox.ReadOnly = true;
            this.GrandTotalTextBox.Size = new System.Drawing.Size(100, 20);
            this.GrandTotalTextBox.TabIndex = 0;
            // 
            // GrandTotalLabel
            // 
            this.GrandTotalLabel.AutoSize = true;
            this.GrandTotalLabel.Location = new System.Drawing.Point(26, 0);
            this.GrandTotalLabel.Name = "GrandTotalLabel";
            this.GrandTotalLabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.GrandTotalLabel.Size = new System.Drawing.Size(69, 18);
            this.GrandTotalLabel.TabIndex = 1;
            this.GrandTotalLabel.Text = "Grand Total: ";
            // 
            // OwnMovieCheckBox
            // 
            this.OwnMovieCheckBox.AutoSize = true;
            this.OwnMovieCheckBox.Location = new System.Drawing.Point(3, 291);
            this.OwnMovieCheckBox.Name = "OwnMovieCheckBox";
            this.OwnMovieCheckBox.Size = new System.Drawing.Size(210, 17);
            this.OwnMovieCheckBox.TabIndex = 1;
            this.OwnMovieCheckBox.Text = "Order the Movie as DVD (10.00$ extra)";
            this.OwnMovieCheckBox.UseVisualStyleBackColor = true;
            // 
            // ButtonsTableLayoutPanel
            // 
            this.ButtonsTableLayoutPanel.ColumnCount = 4;
            this.ButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.2994F));
            this.ButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.7006F));
            this.ButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.ButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.ButtonsTableLayoutPanel.Controls.Add(this.CancelButton, 2, 1);
            this.ButtonsTableLayoutPanel.Controls.Add(this.StreamButton, 3, 1);
            this.ButtonsTableLayoutPanel.Controls.Add(this.BackButton, 0, 1);
            this.ButtonsTableLayoutPanel.Location = new System.Drawing.Point(3, 372);
            this.ButtonsTableLayoutPanel.Name = "ButtonsTableLayoutPanel";
            this.ButtonsTableLayoutPanel.RowCount = 2;
            this.ButtonsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ButtonsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.ButtonsTableLayoutPanel.Size = new System.Drawing.Size(295, 50);
            this.ButtonsTableLayoutPanel.TabIndex = 1;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(140, 22);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(74, 23);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // StreamButton
            // 
            this.StreamButton.Location = new System.Drawing.Point(220, 22);
            this.StreamButton.Name = "StreamButton";
            this.StreamButton.Size = new System.Drawing.Size(71, 23);
            this.StreamButton.TabIndex = 2;
            this.StreamButton.Text = "Stream";
            this.StreamButton.UseVisualStyleBackColor = true;
            this.StreamButton.Click += new System.EventHandler(this.StreamClick);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(3, 22);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(63, 23);
            this.BackButton.TabIndex = 0;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // MoviePictureBox
            // 
            this.MoviePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MoviePictureBox.Location = new System.Drawing.Point(3, 119);
            this.MoviePictureBox.Name = "MoviePictureBox";
            this.MoviePictureBox.Size = new System.Drawing.Size(283, 278);
            this.MoviePictureBox.TabIndex = 4;
            this.MoviePictureBox.TabStop = false;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 471);
            this.ControlBox = false;
            this.Controls.Add(this.OrderFormMainTableLayoutPanel);
            this.Controls.Add(this.OrderFormMenuStrip);
            this.MainMenuStrip = this.OrderFormMenuStrip;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OrderForm";
            this.ShowIcon = false;
            this.Text = "Order Form";
            this.OrderFormMenuStrip.ResumeLayout(false);
            this.OrderFormMenuStrip.PerformLayout();
            this.OrderFormMainTableLayoutPanel.ResumeLayout(false);
            this.MovieSelectedGroupBox.ResumeLayout(false);
            this.MovieSelectedTableLayout.ResumeLayout(false);
            this.MovieSelectedTableLayout.PerformLayout();
            this.OrderButtonsTableLayoutPanel.ResumeLayout(false);
            this.YourSelectionGroupBox.ResumeLayout(false);
            this.OrderTableLayoutPanel.ResumeLayout(false);
            this.OrderTableLayoutPanel.PerformLayout();
            this.CostTableLayoutPanel.ResumeLayout(false);
            this.CostTableLayoutPanel.PerformLayout();
            this.SubTotalTableLayoutPanel.ResumeLayout(false);
            this.SubTotalTableLayoutPanel.PerformLayout();
            this.SalesTaxTableLayoutPanel.ResumeLayout(false);
            this.SalesTaxTableLayoutPanel.PerformLayout();
            this.GrandTotalTableLayoutPanel.ResumeLayout(false);
            this.GrandTotalTableLayoutPanel.PerformLayout();
            this.ButtonsTableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MoviePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip OrderFormMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem streamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel OrderFormMainTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel MovieSelectedTableLayout;
        private System.Windows.Forms.GroupBox MovieSelectedGroupBox;
        private System.Windows.Forms.Label MovieTitleLabel;
        private System.Windows.Forms.Label CatagoryLabel;
        private System.Windows.Forms.TextBox MovieTitleTextBox;
        private System.Windows.Forms.TextBox CatagoryTextBox;
        private System.Windows.Forms.PictureBox MoviePictureBox;
        private System.Windows.Forms.TableLayoutPanel OrderButtonsTableLayoutPanel;
        private System.Windows.Forms.GroupBox YourSelectionGroupBox;
        private System.Windows.Forms.TableLayoutPanel ButtonsTableLayoutPanel;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button StreamButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.TableLayoutPanel OrderTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel CostTableLayoutPanel;
        private System.Windows.Forms.TextBox CostTextBox;
        private System.Windows.Forms.Label Costlabel;
        private System.Windows.Forms.TableLayoutPanel SubTotalTableLayoutPanel;
        private System.Windows.Forms.Label SubTotalLabel;
        private System.Windows.Forms.TableLayoutPanel SalesTaxTableLayoutPanel;
        private System.Windows.Forms.Label SalesTaxLabel;
        private System.Windows.Forms.TableLayoutPanel GrandTotalTableLayoutPanel;
        private System.Windows.Forms.Label GrandTotalLabel;
        private System.Windows.Forms.TextBox SubTotalTextBox;
        private System.Windows.Forms.TextBox SalesTaxTextBox;
        private System.Windows.Forms.TextBox GrandTotalTextBox;
        private System.Windows.Forms.CheckBox OwnMovieCheckBox;
    }
}
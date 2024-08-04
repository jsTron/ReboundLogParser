using System;

namespace ReboundLogParser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.LoadLogsButton = new System.Windows.Forms.Button();
            this.LogFileName = new System.Windows.Forms.TextBox();
            this.homeDataGrid = new System.Windows.Forms.DataGridView();
            this.HomeTeam = new System.Windows.Forms.Label();
            this.awayDataGrid = new System.Windows.Forms.DataGridView();
            this.AwayTeam = new System.Windows.Forms.Label();
            this.HomeOT = new System.Windows.Forms.Label();
            this.AwayOT = new System.Windows.Forms.Label();
            this.MultipleFiles = new System.Windows.Forms.Label();
            this.periodTextLabel = new System.Windows.Forms.Label();
            this.periodLabel = new System.Windows.Forms.Label();
            this.cefPanel1 = new System.Windows.Forms.Panel();
            this.loadHomePlayersButton = new System.Windows.Forms.Button();
            this.homePlayerBox1 = new System.Windows.Forms.ComboBox();
            this.homePlayerBox2 = new System.Windows.Forms.ComboBox();
            this.homePlayerBox3 = new System.Windows.Forms.ComboBox();
            this.homePlayerBox4 = new System.Windows.Forms.ComboBox();
            this.homePlayerBox5 = new System.Windows.Forms.ComboBox();
            this.awayPlayerBox1 = new System.Windows.Forms.ComboBox();
            this.awayPlayerBox2 = new System.Windows.Forms.ComboBox();
            this.awayPlayerBox3 = new System.Windows.Forms.ComboBox();
            this.awayPlayerBox4 = new System.Windows.Forms.ComboBox();
            this.awayPlayerBox5 = new System.Windows.Forms.ComboBox();
            this.loadAwayPlayersButton = new System.Windows.Forms.Button();
            this.SendHomeStatsButton = new System.Windows.Forms.Button();
            this.SendAwayStatsButton = new System.Windows.Forms.Button();
            this.DragDropPanel = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.homePlayerBox10 = new System.Windows.Forms.ComboBox();
            this.homePlayerBox9 = new System.Windows.Forms.ComboBox();
            this.homePlayerBox8 = new System.Windows.Forms.ComboBox();
            this.homePlayerBox7 = new System.Windows.Forms.ComboBox();
            this.homePlayerBox6 = new System.Windows.Forms.ComboBox();
            this.awayPlayerBox10 = new System.Windows.Forms.ComboBox();
            this.awayPlayerBox9 = new System.Windows.Forms.ComboBox();
            this.awayPlayerBox8 = new System.Windows.Forms.ComboBox();
            this.awayPlayerBox7 = new System.Windows.Forms.ComboBox();
            this.awayPlayerBox6 = new System.Windows.Forms.ComboBox();
            this.ClearLogsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.homeDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.awayDataGrid)).BeginInit();
            this.DragDropPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoadLogsButton
            // 
            this.LoadLogsButton.Location = new System.Drawing.Point(78, 3);
            this.LoadLogsButton.Name = "LoadLogsButton";
            this.LoadLogsButton.Size = new System.Drawing.Size(70, 31);
            this.LoadLogsButton.TabIndex = 0;
            this.LoadLogsButton.Text = "Open Logs";
            this.LoadLogsButton.UseVisualStyleBackColor = true;
            this.LoadLogsButton.Click += new System.EventHandler(this.LoadLogsButton_Click);
            // 
            // LogFileName
            // 
            this.LogFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogFileName.Location = new System.Drawing.Point(150, 6);
            this.LogFileName.Name = "LogFileName";
            this.LogFileName.ReadOnly = true;
            this.LogFileName.Size = new System.Drawing.Size(777, 20);
            this.LogFileName.TabIndex = 1;
            // 
            // homeDataGrid
            // 
            this.homeDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.homeDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.homeDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.homeDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.homeDataGrid.Location = new System.Drawing.Point(128, 45);
            this.homeDataGrid.Name = "homeDataGrid";
            this.homeDataGrid.RowHeadersVisible = false;
            this.homeDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.homeDataGrid.Size = new System.Drawing.Size(481, 301);
            this.homeDataGrid.TabIndex = 2;
            // 
            // HomeTeam
            // 
            this.HomeTeam.AutoSize = true;
            this.HomeTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeTeam.Location = new System.Drawing.Point(128, 10);
            this.HomeTeam.Name = "HomeTeam";
            this.HomeTeam.Size = new System.Drawing.Size(162, 31);
            this.HomeTeam.TabIndex = 5;
            this.HomeTeam.Text = "Home Team";
            // 
            // awayDataGrid
            // 
            this.awayDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.awayDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.awayDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.awayDataGrid.Location = new System.Drawing.Point(126, 42);
            this.awayDataGrid.Name = "awayDataGrid";
            this.awayDataGrid.RowHeadersVisible = false;
            this.awayDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.awayDataGrid.Size = new System.Drawing.Size(480, 301);
            this.awayDataGrid.TabIndex = 7;
            // 
            // AwayTeam
            // 
            this.AwayTeam.AutoSize = true;
            this.AwayTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AwayTeam.Location = new System.Drawing.Point(128, 10);
            this.AwayTeam.Name = "AwayTeam";
            this.AwayTeam.Size = new System.Drawing.Size(157, 31);
            this.AwayTeam.TabIndex = 8;
            this.AwayTeam.Text = "Away Team";
            // 
            // HomeOT
            // 
            this.HomeOT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HomeOT.AutoSize = true;
            this.HomeOT.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeOT.ForeColor = System.Drawing.Color.Red;
            this.HomeOT.Location = new System.Drawing.Point(417, 13);
            this.HomeOT.Name = "HomeOT";
            this.HomeOT.Size = new System.Drawing.Size(190, 29);
            this.HomeOT.TabIndex = 9;
            this.HomeOT.Text = "OVERTIME WIN";
            this.HomeOT.Visible = false;
            // 
            // AwayOT
            // 
            this.AwayOT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AwayOT.AutoSize = true;
            this.AwayOT.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AwayOT.ForeColor = System.Drawing.Color.Red;
            this.AwayOT.Location = new System.Drawing.Point(414, 13);
            this.AwayOT.Name = "AwayOT";
            this.AwayOT.Size = new System.Drawing.Size(190, 29);
            this.AwayOT.TabIndex = 10;
            this.AwayOT.Text = "OVERTIME WIN";
            this.AwayOT.Visible = false;
            // 
            // MultipleFiles
            // 
            this.MultipleFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MultipleFiles.AutoSize = true;
            this.MultipleFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MultipleFiles.ForeColor = System.Drawing.Color.Red;
            this.MultipleFiles.Location = new System.Drawing.Point(933, 6);
            this.MultipleFiles.Name = "MultipleFiles";
            this.MultipleFiles.Size = new System.Drawing.Size(170, 25);
            this.MultipleFiles.TabIndex = 11;
            this.MultipleFiles.Text = "Multi-files found!";
            this.MultipleFiles.Visible = false;
            // 
            // periodTextLabel
            // 
            this.periodTextLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.periodTextLabel.AutoSize = true;
            this.periodTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.periodTextLabel.Location = new System.Drawing.Point(1114, 6);
            this.periodTextLabel.Name = "periodTextLabel";
            this.periodTextLabel.Size = new System.Drawing.Size(74, 25);
            this.periodTextLabel.TabIndex = 12;
            this.periodTextLabel.Text = "Period:";
            // 
            // periodLabel
            // 
            this.periodLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.periodLabel.AutoSize = true;
            this.periodLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.periodLabel.Location = new System.Drawing.Point(1194, 6);
            this.periodLabel.Name = "periodLabel";
            this.periodLabel.Size = new System.Drawing.Size(23, 25);
            this.periodLabel.TabIndex = 13;
            this.periodLabel.Text = "0";
            // 
            // cefPanel1
            // 
            this.cefPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cefPanel1.Location = new System.Drawing.Point(4, 393);
            this.cefPanel1.Name = "cefPanel1";
            this.cefPanel1.Size = new System.Drawing.Size(1221, 259);
            this.cefPanel1.TabIndex = 14;
            // 
            // loadHomePlayersButton
            // 
            this.loadHomePlayersButton.Location = new System.Drawing.Point(3, 2);
            this.loadHomePlayersButton.Name = "loadHomePlayersButton";
            this.loadHomePlayersButton.Size = new System.Drawing.Size(119, 34);
            this.loadHomePlayersButton.TabIndex = 15;
            this.loadHomePlayersButton.Text = "Load Home Players";
            this.loadHomePlayersButton.UseVisualStyleBackColor = true;
            this.loadHomePlayersButton.Click += new System.EventHandler(this.TeamPlayersLoadButton_Click);
            // 
            // homePlayerBox1
            // 
            this.homePlayerBox1.FormattingEnabled = true;
            this.homePlayerBox1.Location = new System.Drawing.Point(3, 42);
            this.homePlayerBox1.Name = "homePlayerBox1";
            this.homePlayerBox1.Size = new System.Drawing.Size(119, 21);
            this.homePlayerBox1.TabIndex = 16;
            this.homePlayerBox1.SelectedIndexChanged += new System.EventHandler(this.TeamComboBox_SelectedIndexChanged);
            this.homePlayerBox1.TextChanged += new System.EventHandler(this.TeamComboBox_SelectedIndexChanged);
            // 
            // homePlayerBox2
            // 
            this.homePlayerBox2.FormattingEnabled = true;
            this.homePlayerBox2.Location = new System.Drawing.Point(3, 69);
            this.homePlayerBox2.Name = "homePlayerBox2";
            this.homePlayerBox2.Size = new System.Drawing.Size(119, 21);
            this.homePlayerBox2.TabIndex = 16;
            this.homePlayerBox2.SelectedIndexChanged += new System.EventHandler(this.TeamComboBox_SelectedIndexChanged);
            this.homePlayerBox2.TextChanged += new System.EventHandler(this.TeamComboBox_SelectedIndexChanged);
            // 
            // homePlayerBox3
            // 
            this.homePlayerBox3.FormattingEnabled = true;
            this.homePlayerBox3.Location = new System.Drawing.Point(3, 96);
            this.homePlayerBox3.Name = "homePlayerBox3";
            this.homePlayerBox3.Size = new System.Drawing.Size(119, 21);
            this.homePlayerBox3.TabIndex = 16;
            this.homePlayerBox3.SelectedIndexChanged += new System.EventHandler(this.TeamComboBox_SelectedIndexChanged);
            this.homePlayerBox3.TextChanged += new System.EventHandler(this.TeamComboBox_SelectedIndexChanged);
            // 
            // homePlayerBox4
            // 
            this.homePlayerBox4.FormattingEnabled = true;
            this.homePlayerBox4.Location = new System.Drawing.Point(3, 123);
            this.homePlayerBox4.Name = "homePlayerBox4";
            this.homePlayerBox4.Size = new System.Drawing.Size(119, 21);
            this.homePlayerBox4.TabIndex = 16;
            this.homePlayerBox4.SelectedIndexChanged += new System.EventHandler(this.TeamComboBox_SelectedIndexChanged);
            this.homePlayerBox4.TextChanged += new System.EventHandler(this.TeamComboBox_SelectedIndexChanged);
            // 
            // homePlayerBox5
            // 
            this.homePlayerBox5.FormattingEnabled = true;
            this.homePlayerBox5.Location = new System.Drawing.Point(3, 150);
            this.homePlayerBox5.Name = "homePlayerBox5";
            this.homePlayerBox5.Size = new System.Drawing.Size(119, 21);
            this.homePlayerBox5.TabIndex = 16;
            this.homePlayerBox5.SelectedIndexChanged += new System.EventHandler(this.TeamComboBox_SelectedIndexChanged);
            this.homePlayerBox5.TextChanged += new System.EventHandler(this.TeamComboBox_SelectedIndexChanged);
            // 
            // awayPlayerBox1
            // 
            this.awayPlayerBox1.FormattingEnabled = true;
            this.awayPlayerBox1.Location = new System.Drawing.Point(3, 42);
            this.awayPlayerBox1.Name = "awayPlayerBox1";
            this.awayPlayerBox1.Size = new System.Drawing.Size(119, 21);
            this.awayPlayerBox1.TabIndex = 16;
            this.awayPlayerBox1.SelectedIndexChanged += new System.EventHandler(this.TeamComboBox_SelectedIndexChanged);
            this.awayPlayerBox1.TextChanged += new System.EventHandler(this.TeamComboBox_SelectedIndexChanged);
            // 
            // awayPlayerBox2
            // 
            this.awayPlayerBox2.FormattingEnabled = true;
            this.awayPlayerBox2.Location = new System.Drawing.Point(3, 69);
            this.awayPlayerBox2.Name = "awayPlayerBox2";
            this.awayPlayerBox2.Size = new System.Drawing.Size(119, 21);
            this.awayPlayerBox2.TabIndex = 16;
            this.awayPlayerBox2.SelectedIndexChanged += new System.EventHandler(this.TeamComboBox_SelectedIndexChanged);
            this.awayPlayerBox2.TextChanged += new System.EventHandler(this.TeamComboBox_SelectedIndexChanged);
            // 
            // awayPlayerBox3
            // 
            this.awayPlayerBox3.FormattingEnabled = true;
            this.awayPlayerBox3.Location = new System.Drawing.Point(3, 96);
            this.awayPlayerBox3.Name = "awayPlayerBox3";
            this.awayPlayerBox3.Size = new System.Drawing.Size(119, 21);
            this.awayPlayerBox3.TabIndex = 16;
            this.awayPlayerBox3.SelectedIndexChanged += new System.EventHandler(this.TeamComboBox_SelectedIndexChanged);
            this.awayPlayerBox3.TextChanged += new System.EventHandler(this.TeamComboBox_SelectedIndexChanged);
            // 
            // awayPlayerBox4
            // 
            this.awayPlayerBox4.FormattingEnabled = true;
            this.awayPlayerBox4.Location = new System.Drawing.Point(2, 123);
            this.awayPlayerBox4.Name = "awayPlayerBox4";
            this.awayPlayerBox4.Size = new System.Drawing.Size(119, 21);
            this.awayPlayerBox4.TabIndex = 16;
            this.awayPlayerBox4.SelectedIndexChanged += new System.EventHandler(this.TeamComboBox_SelectedIndexChanged);
            this.awayPlayerBox4.TextChanged += new System.EventHandler(this.TeamComboBox_SelectedIndexChanged);
            // 
            // awayPlayerBox5
            // 
            this.awayPlayerBox5.FormattingEnabled = true;
            this.awayPlayerBox5.Location = new System.Drawing.Point(2, 150);
            this.awayPlayerBox5.Name = "awayPlayerBox5";
            this.awayPlayerBox5.Size = new System.Drawing.Size(119, 21);
            this.awayPlayerBox5.TabIndex = 16;
            this.awayPlayerBox5.SelectedIndexChanged += new System.EventHandler(this.TeamComboBox_SelectedIndexChanged);
            this.awayPlayerBox5.TextChanged += new System.EventHandler(this.TeamComboBox_SelectedIndexChanged);
            // 
            // loadAwayPlayersButton
            // 
            this.loadAwayPlayersButton.Location = new System.Drawing.Point(3, 2);
            this.loadAwayPlayersButton.Name = "loadAwayPlayersButton";
            this.loadAwayPlayersButton.Size = new System.Drawing.Size(119, 34);
            this.loadAwayPlayersButton.TabIndex = 15;
            this.loadAwayPlayersButton.Text = "Load Away Players";
            this.loadAwayPlayersButton.UseVisualStyleBackColor = true;
            this.loadAwayPlayersButton.Click += new System.EventHandler(this.TeamPlayersLoadButton_Click);
            // 
            // SendHomeStatsButton
            // 
            this.SendHomeStatsButton.Location = new System.Drawing.Point(3, 312);
            this.SendHomeStatsButton.Name = "SendHomeStatsButton";
            this.SendHomeStatsButton.Size = new System.Drawing.Size(119, 35);
            this.SendHomeStatsButton.TabIndex = 17;
            this.SendHomeStatsButton.Text = "Send Home Stats";
            this.SendHomeStatsButton.UseVisualStyleBackColor = true;
            this.SendHomeStatsButton.Click += new System.EventHandler(this.SendStatsButton_Click);
            // 
            // SendAwayStatsButton
            // 
            this.SendAwayStatsButton.Location = new System.Drawing.Point(1, 312);
            this.SendAwayStatsButton.Name = "SendAwayStatsButton";
            this.SendAwayStatsButton.Size = new System.Drawing.Size(119, 35);
            this.SendAwayStatsButton.TabIndex = 17;
            this.SendAwayStatsButton.Text = "Send Away Stats";
            this.SendAwayStatsButton.UseVisualStyleBackColor = true;
            this.SendAwayStatsButton.Click += new System.EventHandler(this.SendStatsButton_Click);
            // 
            // DragDropPanel
            // 
            this.DragDropPanel.AllowDrop = true;
            this.DragDropPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DragDropPanel.BackColor = System.Drawing.SystemColors.Control;
            this.DragDropPanel.Controls.Add(this.periodTextLabel);
            this.DragDropPanel.Controls.Add(this.periodLabel);
            this.DragDropPanel.Controls.Add(this.MultipleFiles);
            this.DragDropPanel.Controls.Add(this.LogFileName);
            this.DragDropPanel.Controls.Add(this.splitContainer1);
            this.DragDropPanel.Location = new System.Drawing.Point(4, 3);
            this.DragDropPanel.Name = "DragDropPanel";
            this.DragDropPanel.Size = new System.Drawing.Size(1221, 384);
            this.DragDropPanel.TabIndex = 18;
            this.DragDropPanel.DragDrop += new System.Windows.Forms.DragEventHandler(this.DragDropPanel_DragDrop);
            this.DragDropPanel.DragOver += new System.Windows.Forms.DragEventHandler(this.DragDropPanel_DragOver);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 32);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.homeDataGrid);
            this.splitContainer1.Panel1.Controls.Add(this.homePlayerBox1);
            this.splitContainer1.Panel1.Controls.Add(this.loadHomePlayersButton);
            this.splitContainer1.Panel1.Controls.Add(this.homePlayerBox2);
            this.splitContainer1.Panel1.Controls.Add(this.homePlayerBox3);
            this.splitContainer1.Panel1.Controls.Add(this.HomeTeam);
            this.splitContainer1.Panel1.Controls.Add(this.homePlayerBox10);
            this.splitContainer1.Panel1.Controls.Add(this.HomeOT);
            this.splitContainer1.Panel1.Controls.Add(this.homePlayerBox4);
            this.splitContainer1.Panel1.Controls.Add(this.homePlayerBox9);
            this.splitContainer1.Panel1.Controls.Add(this.homePlayerBox5);
            this.splitContainer1.Panel1.Controls.Add(this.homePlayerBox8);
            this.splitContainer1.Panel1.Controls.Add(this.SendHomeStatsButton);
            this.splitContainer1.Panel1.Controls.Add(this.homePlayerBox7);
            this.splitContainer1.Panel1.Controls.Add(this.homePlayerBox6);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.awayPlayerBox10);
            this.splitContainer1.Panel2.Controls.Add(this.awayDataGrid);
            this.splitContainer1.Panel2.Controls.Add(this.awayPlayerBox9);
            this.splitContainer1.Panel2.Controls.Add(this.loadAwayPlayersButton);
            this.splitContainer1.Panel2.Controls.Add(this.AwayTeam);
            this.splitContainer1.Panel2.Controls.Add(this.AwayOT);
            this.splitContainer1.Panel2.Controls.Add(this.awayPlayerBox8);
            this.splitContainer1.Panel2.Controls.Add(this.awayPlayerBox1);
            this.splitContainer1.Panel2.Controls.Add(this.awayPlayerBox7);
            this.splitContainer1.Panel2.Controls.Add(this.awayPlayerBox2);
            this.splitContainer1.Panel2.Controls.Add(this.awayPlayerBox6);
            this.splitContainer1.Panel2.Controls.Add(this.awayPlayerBox3);
            this.splitContainer1.Panel2.Controls.Add(this.awayPlayerBox4);
            this.splitContainer1.Panel2.Controls.Add(this.awayPlayerBox5);
            this.splitContainer1.Panel2.Controls.Add(this.SendAwayStatsButton);
            this.splitContainer1.Size = new System.Drawing.Size(1221, 352);
            this.splitContainer1.SplitterDistance = 610;
            this.splitContainer1.TabIndex = 28;
            // 
            // homePlayerBox10
            // 
            this.homePlayerBox10.FormattingEnabled = true;
            this.homePlayerBox10.Location = new System.Drawing.Point(3, 285);
            this.homePlayerBox10.Name = "homePlayerBox10";
            this.homePlayerBox10.Size = new System.Drawing.Size(119, 21);
            this.homePlayerBox10.TabIndex = 18;
            this.homePlayerBox10.SelectedIndexChanged += new System.EventHandler(this.TeamComboBox_SelectedIndexChanged);
            this.homePlayerBox10.TextChanged += new System.EventHandler(this.TeamComboBox_SelectedIndexChanged);
            // 
            // homePlayerBox9
            // 
            this.homePlayerBox9.FormattingEnabled = true;
            this.homePlayerBox9.Location = new System.Drawing.Point(3, 258);
            this.homePlayerBox9.Name = "homePlayerBox9";
            this.homePlayerBox9.Size = new System.Drawing.Size(119, 21);
            this.homePlayerBox9.TabIndex = 19;
            this.homePlayerBox9.SelectedIndexChanged += new System.EventHandler(this.TeamComboBox_SelectedIndexChanged);
            this.homePlayerBox9.TextChanged += new System.EventHandler(this.TeamComboBox_SelectedIndexChanged);
            // 
            // homePlayerBox8
            // 
            this.homePlayerBox8.FormattingEnabled = true;
            this.homePlayerBox8.Location = new System.Drawing.Point(3, 231);
            this.homePlayerBox8.Name = "homePlayerBox8";
            this.homePlayerBox8.Size = new System.Drawing.Size(119, 21);
            this.homePlayerBox8.TabIndex = 20;
            this.homePlayerBox8.SelectedIndexChanged += new System.EventHandler(this.TeamComboBox_SelectedIndexChanged);
            this.homePlayerBox8.TextChanged += new System.EventHandler(this.TeamComboBox_SelectedIndexChanged);
            // 
            // homePlayerBox7
            // 
            this.homePlayerBox7.FormattingEnabled = true;
            this.homePlayerBox7.Location = new System.Drawing.Point(3, 204);
            this.homePlayerBox7.Name = "homePlayerBox7";
            this.homePlayerBox7.Size = new System.Drawing.Size(119, 21);
            this.homePlayerBox7.TabIndex = 21;
            this.homePlayerBox7.SelectedIndexChanged += new System.EventHandler(this.TeamComboBox_SelectedIndexChanged);
            this.homePlayerBox7.TextChanged += new System.EventHandler(this.TeamComboBox_SelectedIndexChanged);
            // 
            // homePlayerBox6
            // 
            this.homePlayerBox6.FormattingEnabled = true;
            this.homePlayerBox6.Location = new System.Drawing.Point(3, 177);
            this.homePlayerBox6.Name = "homePlayerBox6";
            this.homePlayerBox6.Size = new System.Drawing.Size(119, 21);
            this.homePlayerBox6.TabIndex = 22;
            this.homePlayerBox6.SelectedIndexChanged += new System.EventHandler(this.TeamComboBox_SelectedIndexChanged);
            this.homePlayerBox6.TextChanged += new System.EventHandler(this.TeamComboBox_SelectedIndexChanged);
            // 
            // awayPlayerBox10
            // 
            this.awayPlayerBox10.FormattingEnabled = true;
            this.awayPlayerBox10.Location = new System.Drawing.Point(1, 285);
            this.awayPlayerBox10.Name = "awayPlayerBox10";
            this.awayPlayerBox10.Size = new System.Drawing.Size(119, 21);
            this.awayPlayerBox10.TabIndex = 23;
            this.awayPlayerBox10.SelectedIndexChanged += new System.EventHandler(this.TeamComboBox_SelectedIndexChanged);
            this.awayPlayerBox10.TextChanged += new System.EventHandler(this.TeamComboBox_SelectedIndexChanged);
            // 
            // awayPlayerBox9
            // 
            this.awayPlayerBox9.FormattingEnabled = true;
            this.awayPlayerBox9.Location = new System.Drawing.Point(1, 258);
            this.awayPlayerBox9.Name = "awayPlayerBox9";
            this.awayPlayerBox9.Size = new System.Drawing.Size(119, 21);
            this.awayPlayerBox9.TabIndex = 24;
            this.awayPlayerBox9.SelectedIndexChanged += new System.EventHandler(this.TeamComboBox_SelectedIndexChanged);
            this.awayPlayerBox9.TextChanged += new System.EventHandler(this.TeamComboBox_SelectedIndexChanged);
            // 
            // awayPlayerBox8
            // 
            this.awayPlayerBox8.FormattingEnabled = true;
            this.awayPlayerBox8.Location = new System.Drawing.Point(2, 231);
            this.awayPlayerBox8.Name = "awayPlayerBox8";
            this.awayPlayerBox8.Size = new System.Drawing.Size(119, 21);
            this.awayPlayerBox8.TabIndex = 25;
            this.awayPlayerBox8.SelectedIndexChanged += new System.EventHandler(this.TeamComboBox_SelectedIndexChanged);
            this.awayPlayerBox8.TextChanged += new System.EventHandler(this.TeamComboBox_SelectedIndexChanged);
            // 
            // awayPlayerBox7
            // 
            this.awayPlayerBox7.FormattingEnabled = true;
            this.awayPlayerBox7.Location = new System.Drawing.Point(2, 204);
            this.awayPlayerBox7.Name = "awayPlayerBox7";
            this.awayPlayerBox7.Size = new System.Drawing.Size(119, 21);
            this.awayPlayerBox7.TabIndex = 26;
            this.awayPlayerBox7.SelectedIndexChanged += new System.EventHandler(this.TeamComboBox_SelectedIndexChanged);
            this.awayPlayerBox7.TextChanged += new System.EventHandler(this.TeamComboBox_SelectedIndexChanged);
            // 
            // awayPlayerBox6
            // 
            this.awayPlayerBox6.FormattingEnabled = true;
            this.awayPlayerBox6.Location = new System.Drawing.Point(2, 177);
            this.awayPlayerBox6.Name = "awayPlayerBox6";
            this.awayPlayerBox6.Size = new System.Drawing.Size(119, 21);
            this.awayPlayerBox6.TabIndex = 27;
            this.awayPlayerBox6.SelectedIndexChanged += new System.EventHandler(this.TeamComboBox_SelectedIndexChanged);
            this.awayPlayerBox6.TextChanged += new System.EventHandler(this.TeamComboBox_SelectedIndexChanged);
            // 
            // ClearLogsButton
            // 
            this.ClearLogsButton.Location = new System.Drawing.Point(4, 3);
            this.ClearLogsButton.Name = "ClearLogsButton";
            this.ClearLogsButton.Size = new System.Drawing.Size(68, 31);
            this.ClearLogsButton.TabIndex = 19;
            this.ClearLogsButton.Text = "Clear Logs";
            this.ClearLogsButton.UseVisualStyleBackColor = true;
            this.ClearLogsButton.Click += new System.EventHandler(this.ClearLogsButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 656);
            this.Controls.Add(this.LoadLogsButton);
            this.Controls.Add(this.ClearLogsButton);
            this.Controls.Add(this.cefPanel1);
            this.Controls.Add(this.DragDropPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(960, 695);
            this.Name = "MainForm";
            this.Text = "Rebound Log Parser 6.4.1";
            ((System.ComponentModel.ISupportInitialize)(this.homeDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.awayDataGrid)).EndInit();
            this.DragDropPanel.ResumeLayout(false);
            this.DragDropPanel.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LoadLogsButton;
        private System.Windows.Forms.TextBox LogFileName;
        private System.Windows.Forms.DataGridView homeDataGrid;
        private System.Windows.Forms.Label HomeTeam;
        private System.Windows.Forms.DataGridView awayDataGrid;
        private System.Windows.Forms.Label AwayTeam;
        private System.Windows.Forms.Label HomeOT;
        private System.Windows.Forms.Label AwayOT;
        private System.Windows.Forms.Label MultipleFiles;
        private System.Windows.Forms.Label periodTextLabel;
        private System.Windows.Forms.Label periodLabel;
        private System.Windows.Forms.Panel cefPanel1;
        private System.Windows.Forms.Button loadHomePlayersButton;
        private System.Windows.Forms.ComboBox homePlayerBox1;
        private System.Windows.Forms.ComboBox homePlayerBox2;
        private System.Windows.Forms.ComboBox homePlayerBox3;
        private System.Windows.Forms.ComboBox homePlayerBox4;
        private System.Windows.Forms.ComboBox homePlayerBox5;
        private System.Windows.Forms.ComboBox awayPlayerBox1;
        private System.Windows.Forms.ComboBox awayPlayerBox2;
        private System.Windows.Forms.ComboBox awayPlayerBox3;
        private System.Windows.Forms.ComboBox awayPlayerBox4;
        private System.Windows.Forms.ComboBox awayPlayerBox5;
        private System.Windows.Forms.Button loadAwayPlayersButton;
        private System.Windows.Forms.Button SendHomeStatsButton;
        private System.Windows.Forms.Button SendAwayStatsButton;
        private System.Windows.Forms.Panel DragDropPanel;
        private System.Windows.Forms.Button ClearLogsButton;
        private System.Windows.Forms.ComboBox awayPlayerBox10;
        private System.Windows.Forms.ComboBox awayPlayerBox9;
        private System.Windows.Forms.ComboBox awayPlayerBox8;
        private System.Windows.Forms.ComboBox awayPlayerBox7;
        private System.Windows.Forms.ComboBox awayPlayerBox6;
        private System.Windows.Forms.ComboBox homePlayerBox10;
        private System.Windows.Forms.ComboBox homePlayerBox9;
        private System.Windows.Forms.ComboBox homePlayerBox8;
        private System.Windows.Forms.ComboBox homePlayerBox7;
        private System.Windows.Forms.ComboBox homePlayerBox6;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}


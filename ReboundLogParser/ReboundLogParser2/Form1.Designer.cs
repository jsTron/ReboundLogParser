using System;

namespace ReboundLogParser2 {
  partial class Form1 {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LoadLogsButton = new System.Windows.Forms.Button();
            this.LogFileName = new System.Windows.Forms.TextBox();
            this.homeDataGrid = new System.Windows.Forms.DataGridView();
            this.HomeTeam = new System.Windows.Forms.Label();
            this.awayDataGrid = new System.Windows.Forms.DataGridView();
            this.AwayTeam = new System.Windows.Forms.Label();
            this.HomeOT = new System.Windows.Forms.Label();
            this.AwayOT = new System.Windows.Forms.Label();
            this.MultipleFiles = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.periodLabel = new System.Windows.Forms.Label();
            this.cefPanel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.comboBox9 = new System.Windows.Forms.ComboBox();
            this.comboBox10 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SendHomeStatsButton = new System.Windows.Forms.Button();
            this.SendAwayStatsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.homeDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.awayDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // LoadLogsButton
            // 
            this.LoadLogsButton.Location = new System.Drawing.Point(1470, 53);
            this.LoadLogsButton.Name = "LoadLogsButton";
            this.LoadLogsButton.Size = new System.Drawing.Size(102, 42);
            this.LoadLogsButton.TabIndex = 0;
            this.LoadLogsButton.Text = "Load Logs";
            this.LoadLogsButton.UseVisualStyleBackColor = true;
            this.LoadLogsButton.Click += new System.EventHandler(this.LoadLogsButton_Click);
            // 
            // LogFileName
            // 
            this.LogFileName.Location = new System.Drawing.Point(129, 14);
            this.LogFileName.Name = "LogFileName";
            this.LogFileName.ReadOnly = true;
            this.LogFileName.Size = new System.Drawing.Size(919, 20);
            this.LogFileName.TabIndex = 1;
            // 
            // homeDataGrid
            // 
            this.homeDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.homeDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.homeDataGrid.Location = new System.Drawing.Point(129, 111);
            this.homeDataGrid.Name = "homeDataGrid";
            this.homeDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.homeDataGrid.Size = new System.Drawing.Size(1444, 164);
            this.homeDataGrid.TabIndex = 2;
            // 
            // HomeTeam
            // 
            this.HomeTeam.AutoSize = true;
            this.HomeTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeTeam.Location = new System.Drawing.Point(122, 53);
            this.HomeTeam.Name = "HomeTeam";
            this.HomeTeam.Size = new System.Drawing.Size(222, 42);
            this.HomeTeam.TabIndex = 5;
            this.HomeTeam.Text = "Home Team";
            // 
            // awayDataGrid
            // 
            this.awayDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.awayDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.awayDataGrid.Location = new System.Drawing.Point(128, 359);
            this.awayDataGrid.Name = "awayDataGrid";
            this.awayDataGrid.Size = new System.Drawing.Size(1444, 164);
            this.awayDataGrid.TabIndex = 7;
            // 
            // AwayTeam
            // 
            this.AwayTeam.AutoSize = true;
            this.AwayTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AwayTeam.Location = new System.Drawing.Point(125, 299);
            this.AwayTeam.Name = "AwayTeam";
            this.AwayTeam.Size = new System.Drawing.Size(215, 42);
            this.AwayTeam.TabIndex = 8;
            this.AwayTeam.Text = "Away Team";
            // 
            // HomeOT
            // 
            this.HomeOT.AutoSize = true;
            this.HomeOT.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeOT.Location = new System.Drawing.Point(755, 53);
            this.HomeOT.Name = "HomeOT";
            this.HomeOT.Size = new System.Drawing.Size(293, 42);
            this.HomeOT.TabIndex = 9;
            this.HomeOT.Text = "OVERTIME WIN";
            this.HomeOT.Visible = false;
            // 
            // AwayOT
            // 
            this.AwayOT.AutoSize = true;
            this.AwayOT.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AwayOT.Location = new System.Drawing.Point(755, 299);
            this.AwayOT.Name = "AwayOT";
            this.AwayOT.Size = new System.Drawing.Size(293, 42);
            this.AwayOT.TabIndex = 10;
            this.AwayOT.Text = "OVERTIME WIN";
            this.AwayOT.Visible = false;
            // 
            // MultipleFiles
            // 
            this.MultipleFiles.AutoSize = true;
            this.MultipleFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MultipleFiles.Location = new System.Drawing.Point(1054, 13);
            this.MultipleFiles.Name = "MultipleFiles";
            this.MultipleFiles.Size = new System.Drawing.Size(285, 25);
            this.MultipleFiles.TabIndex = 11;
            this.MultipleFiles.Text = "Multiple log files in log folder";
            this.MultipleFiles.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(1470, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Period:";
            // 
            // periodLabel
            // 
            this.periodLabel.AutoSize = true;
            this.periodLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.periodLabel.Location = new System.Drawing.Point(1549, 14);
            this.periodLabel.Name = "periodLabel";
            this.periodLabel.Size = new System.Drawing.Size(23, 25);
            this.periodLabel.TabIndex = 13;
            this.periodLabel.Text = "3";
            // 
            // cefPanel1
            // 
            this.cefPanel1.Location = new System.Drawing.Point(12, 529);
            this.cefPanel1.Name = "cefPanel1";
            this.cefPanel1.Size = new System.Drawing.Size(1558, 326);
            this.cefPanel1.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(4, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 34);
            this.button1.TabIndex = 15;
            this.button1.Text = "Load Home Players";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.TeamPlayersLoadButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(4, 106);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(119, 21);
            this.comboBox1.TabIndex = 16;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(4, 133);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(119, 21);
            this.comboBox2.TabIndex = 16;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(4, 160);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(119, 21);
            this.comboBox3.TabIndex = 16;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(4, 187);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(119, 21);
            this.comboBox4.TabIndex = 16;
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(4, 214);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(119, 21);
            this.comboBox5.TabIndex = 16;
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(4, 352);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(119, 21);
            this.comboBox6.TabIndex = 16;
            // 
            // comboBox7
            // 
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Location = new System.Drawing.Point(4, 379);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(119, 21);
            this.comboBox7.TabIndex = 16;
            // 
            // comboBox8
            // 
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.Location = new System.Drawing.Point(4, 406);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(119, 21);
            this.comboBox8.TabIndex = 16;
            // 
            // comboBox9
            // 
            this.comboBox9.FormattingEnabled = true;
            this.comboBox9.Location = new System.Drawing.Point(3, 433);
            this.comboBox9.Name = "comboBox9";
            this.comboBox9.Size = new System.Drawing.Size(119, 21);
            this.comboBox9.TabIndex = 16;
            // 
            // comboBox10
            // 
            this.comboBox10.FormattingEnabled = true;
            this.comboBox10.Location = new System.Drawing.Point(3, 460);
            this.comboBox10.Name = "comboBox10";
            this.comboBox10.Size = new System.Drawing.Size(119, 21);
            this.comboBox10.TabIndex = 16;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(4, 312);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 34);
            this.button2.TabIndex = 15;
            this.button2.Text = "Load Away Players";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.TeamPlayersLoadButton_Click);
            // 
            // SendHomeStatsButton
            // 
            this.SendHomeStatsButton.Location = new System.Drawing.Point(4, 241);
            this.SendHomeStatsButton.Name = "SendHomeStatsButton";
            this.SendHomeStatsButton.Size = new System.Drawing.Size(119, 35);
            this.SendHomeStatsButton.TabIndex = 17;
            this.SendHomeStatsButton.Text = "Send Home Stats";
            this.SendHomeStatsButton.UseVisualStyleBackColor = true;
            this.SendHomeStatsButton.Click += new System.EventHandler(this.SendHomeStatsButton_Click);
            // 
            // SendAwayStatsButton
            // 
            this.SendAwayStatsButton.Location = new System.Drawing.Point(4, 487);
            this.SendAwayStatsButton.Name = "SendAwayStatsButton";
            this.SendAwayStatsButton.Size = new System.Drawing.Size(119, 35);
            this.SendAwayStatsButton.TabIndex = 17;
            this.SendAwayStatsButton.Text = "Send Away Stats";
            this.SendAwayStatsButton.UseVisualStyleBackColor = true;
            this.SendAwayStatsButton.Click += new System.EventHandler(this.SendAwayStatsButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.SendAwayStatsButton);
            this.Controls.Add(this.SendHomeStatsButton);
            this.Controls.Add(this.comboBox10);
            this.Controls.Add(this.comboBox9);
            this.Controls.Add(this.comboBox8);
            this.Controls.Add(this.comboBox7);
            this.Controls.Add(this.comboBox6);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cefPanel1);
            this.Controls.Add(this.periodLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MultipleFiles);
            this.Controls.Add(this.AwayOT);
            this.Controls.Add(this.HomeOT);
            this.Controls.Add(this.AwayTeam);
            this.Controls.Add(this.awayDataGrid);
            this.Controls.Add(this.HomeTeam);
            this.Controls.Add(this.homeDataGrid);
            this.Controls.Add(this.LogFileName);
            this.Controls.Add(this.LoadLogsButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Rebound Log Parser 5.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.homeDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.awayDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label periodLabel;
        private System.Windows.Forms.Panel cefPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.ComboBox comboBox7;
        private System.Windows.Forms.ComboBox comboBox8;
        private System.Windows.Forms.ComboBox comboBox9;
        private System.Windows.Forms.ComboBox comboBox10;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button SendHomeStatsButton;
        private System.Windows.Forms.Button SendAwayStatsButton;
    }
}


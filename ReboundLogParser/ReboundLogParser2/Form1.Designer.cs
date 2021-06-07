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
      ((System.ComponentModel.ISupportInitialize)(this.homeDataGrid)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.awayDataGrid)).BeginInit();
      this.SuspendLayout();
      // 
      // LoadLogsButton
      // 
      this.LoadLogsButton.Location = new System.Drawing.Point(1354, 52);
      this.LoadLogsButton.Name = "LoadLogsButton";
      this.LoadLogsButton.Size = new System.Drawing.Size(102, 42);
      this.LoadLogsButton.TabIndex = 0;
      this.LoadLogsButton.Text = "Load Logs";
      this.LoadLogsButton.UseVisualStyleBackColor = true;
      this.LoadLogsButton.Click += new System.EventHandler(this.button1_Click);
      // 
      // LogFileName
      // 
      this.LogFileName.Location = new System.Drawing.Point(13, 13);
      this.LogFileName.Name = "LogFileName";
      this.LogFileName.ReadOnly = true;
      this.LogFileName.Size = new System.Drawing.Size(919, 20);
      this.LogFileName.TabIndex = 1;
      // 
      // homeDataGrid
      // 
      this.homeDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.homeDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.homeDataGrid.Location = new System.Drawing.Point(13, 110);
      this.homeDataGrid.Name = "homeDataGrid";
      this.homeDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
      this.homeDataGrid.Size = new System.Drawing.Size(1444, 164);
      this.homeDataGrid.TabIndex = 2;
      // 
      // HomeTeam
      // 
      this.HomeTeam.AutoSize = true;
      this.HomeTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.HomeTeam.Location = new System.Drawing.Point(6, 52);
      this.HomeTeam.Name = "HomeTeam";
      this.HomeTeam.Size = new System.Drawing.Size(222, 42);
      this.HomeTeam.TabIndex = 5;
      this.HomeTeam.Text = "Home Team";
      // 
      // awayDataGrid
      // 
      this.awayDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.awayDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.awayDataGrid.Location = new System.Drawing.Point(12, 358);
      this.awayDataGrid.Name = "awayDataGrid";
      this.awayDataGrid.Size = new System.Drawing.Size(1444, 164);
      this.awayDataGrid.TabIndex = 7;
      // 
      // AwayTeam
      // 
      this.AwayTeam.AutoSize = true;
      this.AwayTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.AwayTeam.Location = new System.Drawing.Point(9, 298);
      this.AwayTeam.Name = "AwayTeam";
      this.AwayTeam.Size = new System.Drawing.Size(215, 42);
      this.AwayTeam.TabIndex = 8;
      this.AwayTeam.Text = "Away Team";
      // 
      // HomeOT
      // 
      this.HomeOT.AutoSize = true;
      this.HomeOT.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.HomeOT.Location = new System.Drawing.Point(639, 52);
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
      this.AwayOT.Location = new System.Drawing.Point(639, 298);
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
      this.MultipleFiles.Location = new System.Drawing.Point(938, 12);
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
      this.label1.Location = new System.Drawing.Point(1354, 13);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(74, 25);
      this.label1.TabIndex = 12;
      this.label1.Text = "Period:";
      // 
      // periodLabel
      // 
      this.periodLabel.AutoSize = true;
      this.periodLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
      this.periodLabel.Location = new System.Drawing.Point(1433, 13);
      this.periodLabel.Name = "periodLabel";
      this.periodLabel.Size = new System.Drawing.Size(23, 25);
      this.periodLabel.TabIndex = 13;
      this.periodLabel.Text = "3";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1469, 535);
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
  }
}


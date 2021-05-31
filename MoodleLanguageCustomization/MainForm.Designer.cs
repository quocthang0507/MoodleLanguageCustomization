
namespace MoodleLanguageCustomization
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
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.btnExportPHP = new System.Windows.Forms.Button();
			this.btnOpenFolder = new System.Windows.Forms.Button();
			this.btnExportExcel = new System.Windows.Forms.Button();
			this.btnBrowseExcel = new System.Windows.Forms.Button();
			this.btnBrowsePHP = new System.Windows.Forms.Button();
			this.tbxExcelPath = new System.Windows.Forms.TextBox();
			this.tbxPHPPath = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.gridView = new System.Windows.Forms.DataGridView();
			this.openPHPFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.saveExcelFileDialog = new System.Windows.Forms.SaveFileDialog();
			this.openExcelFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.savePHPFileDialog = new System.Windows.Forms.SaveFileDialog();
			this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
			this.lblPercent = new System.Windows.Forms.Label();
			this.tableLayoutPanel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.gridView, 0, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.Size = new System.Drawing.Size(984, 561);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.lblPercent);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.btnExportPHP);
			this.groupBox1.Controls.Add(this.btnOpenFolder);
			this.groupBox1.Controls.Add(this.btnExportExcel);
			this.groupBox1.Controls.Add(this.btnBrowseExcel);
			this.groupBox1.Controls.Add(this.btnBrowsePHP);
			this.groupBox1.Controls.Add(this.tbxExcelPath);
			this.groupBox1.Controls.Add(this.tbxPHPPath);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox1.Location = new System.Drawing.Point(3, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(978, 194);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Input && Output file";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(139, 130);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(635, 17);
			this.label6.TabIndex = 9;
			this.label6.Text = "1.4) Move to bottom-right corner of cell B1, your cursor looks like +, drag and d" +
    "rop to the end of file!";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(139, 105);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(546, 17);
			this.label5.TabIndex = 8;
			this.label5.Text = "1.3) Type a formula looked like =GOOGLETRANSLATE(sheet1!B1;\"en\";\"vi\") in cell B1";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(139, 80);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(386, 17);
			this.label4.TabIndex = 8;
			this.label4.Text = "1.2) Edit it by Google SpreadSheet, open second worksheet";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(139, 55);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(276, 17);
			this.label3.TabIndex = 7;
			this.label3.Text = "1.1) Upload Excel file to your Google Drive";
			// 
			// btnExportPHP
			// 
			this.btnExportPHP.Location = new System.Drawing.Point(738, 149);
			this.btnExportPHP.Name = "btnExportPHP";
			this.btnExportPHP.Size = new System.Drawing.Size(126, 34);
			this.btnExportPHP.TabIndex = 7;
			this.btnExportPHP.Text = "Export PHP";
			this.btnExportPHP.UseVisualStyleBackColor = true;
			this.btnExportPHP.Click += new System.EventHandler(this.btnExportPHP_Click);
			// 
			// btnOpenFolder
			// 
			this.btnOpenFolder.Location = new System.Drawing.Point(742, 17);
			this.btnOpenFolder.Name = "btnOpenFolder";
			this.btnOpenFolder.Size = new System.Drawing.Size(103, 34);
			this.btnOpenFolder.TabIndex = 3;
			this.btnOpenFolder.Text = "Open folder...";
			this.btnOpenFolder.UseVisualStyleBackColor = true;
			this.btnOpenFolder.Click += new System.EventHandler(this.btnOpenFolder_Click);
			// 
			// btnExportExcel
			// 
			this.btnExportExcel.Location = new System.Drawing.Point(861, 17);
			this.btnExportExcel.Name = "btnExportExcel";
			this.btnExportExcel.Size = new System.Drawing.Size(108, 34);
			this.btnExportExcel.TabIndex = 4;
			this.btnExportExcel.Text = "Export Excel";
			this.btnExportExcel.UseVisualStyleBackColor = true;
			this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
			// 
			// btnBrowseExcel
			// 
			this.btnBrowseExcel.Location = new System.Drawing.Point(650, 149);
			this.btnBrowseExcel.Name = "btnBrowseExcel";
			this.btnBrowseExcel.Size = new System.Drawing.Size(75, 34);
			this.btnBrowseExcel.TabIndex = 6;
			this.btnBrowseExcel.Text = "Browse...";
			this.btnBrowseExcel.UseVisualStyleBackColor = true;
			this.btnBrowseExcel.Click += new System.EventHandler(this.btnBrowseExcel_Click);
			// 
			// btnBrowsePHP
			// 
			this.btnBrowsePHP.Location = new System.Drawing.Point(650, 17);
			this.btnBrowsePHP.Name = "btnBrowsePHP";
			this.btnBrowsePHP.Size = new System.Drawing.Size(75, 34);
			this.btnBrowsePHP.TabIndex = 2;
			this.btnBrowsePHP.Text = "Browse...";
			this.btnBrowsePHP.UseVisualStyleBackColor = true;
			this.btnBrowsePHP.Click += new System.EventHandler(this.btnBrowsePHP_Click);
			// 
			// tbxExcelPath
			// 
			this.tbxExcelPath.Location = new System.Drawing.Point(142, 155);
			this.tbxExcelPath.Name = "tbxExcelPath";
			this.tbxExcelPath.Size = new System.Drawing.Size(493, 23);
			this.tbxExcelPath.TabIndex = 5;
			// 
			// tbxPHPPath
			// 
			this.tbxPHPPath.Location = new System.Drawing.Point(142, 23);
			this.tbxPHPPath.Name = "tbxPHPPath";
			this.tbxPHPPath.ReadOnly = true;
			this.tbxPHPPath.Size = new System.Drawing.Size(493, 23);
			this.tbxPHPPath.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 158);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(129, 17);
			this.label2.TabIndex = 0;
			this.label2.Text = "2) Input file (Excel):";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(124, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "1) Input file (PHP):";
			// 
			// gridView
			// 
			this.gridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridView.Location = new System.Drawing.Point(3, 203);
			this.gridView.MultiSelect = false;
			this.gridView.Name = "gridView";
			this.gridView.ReadOnly = true;
			this.gridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gridView.Size = new System.Drawing.Size(978, 355);
			this.gridView.TabIndex = 2;
			// 
			// openPHPFileDialog
			// 
			this.openPHPFileDialog.FileName = "Select a PHP file";
			this.openPHPFileDialog.Filter = "PHP file (*.php)|*.php";
			this.openPHPFileDialog.Title = "Open PHP file";
			// 
			// saveExcelFileDialog
			// 
			this.saveExcelFileDialog.Filter = "Excel file (*.xlsx)|*.xlsx";
			this.saveExcelFileDialog.Title = "Save Excel file";
			// 
			// openExcelFileDialog
			// 
			this.openExcelFileDialog.FileName = "Select a Excel file";
			this.openExcelFileDialog.Filter = "Excel file (*.xlsx)|*.xlsx";
			this.openExcelFileDialog.Title = "Open Excel file";
			// 
			// savePHPFileDialog
			// 
			this.savePHPFileDialog.Filter = "PHP file (*.php)|*.php";
			this.savePHPFileDialog.Title = "Save PHP file";
			// 
			// lblPercent
			// 
			this.lblPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
			this.lblPercent.Location = new System.Drawing.Point(801, 76);
			this.lblPercent.Name = "lblPercent";
			this.lblPercent.Size = new System.Drawing.Size(168, 46);
			this.lblPercent.TabIndex = 10;
			this.lblPercent.Text = "0%";
			this.lblPercent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(984, 561);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.Name = "MainForm";
			this.Text = "Vietnamese Customization for Moodle";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox tbxPHPPath;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnExportExcel;
		private System.Windows.Forms.Button btnBrowsePHP;
		private System.Windows.Forms.OpenFileDialog openPHPFileDialog;
		private System.Windows.Forms.SaveFileDialog saveExcelFileDialog;
		private System.Windows.Forms.TextBox tbxExcelPath;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnBrowseExcel;
		private System.Windows.Forms.Button btnExportPHP;
		private System.Windows.Forms.OpenFileDialog openExcelFileDialog;
		private System.Windows.Forms.SaveFileDialog savePHPFileDialog;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnOpenFolder;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
		private System.Windows.Forms.DataGridView gridView;
		private System.Windows.Forms.Label lblPercent;
	}
}


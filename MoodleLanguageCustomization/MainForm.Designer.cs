
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
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.listView = new System.Windows.Forms.ListBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnExportPHP = new System.Windows.Forms.Button();
			this.btnExportExcel = new System.Windows.Forms.Button();
			this.btnBrowseExcel = new System.Windows.Forms.Button();
			this.btnBrowsePHP = new System.Windows.Forms.Button();
			this.tbxExcelPath = new System.Windows.Forms.TextBox();
			this.tbxPHPPath = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.openPHPFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.saveExcelFileDialog = new System.Windows.Forms.SaveFileDialog();
			this.openExcelFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.savePHPFileDialog = new System.Windows.Forms.SaveFileDialog();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.Size = new System.Drawing.Size(889, 561);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 1;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel2.Controls.Add(this.listView, 0, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 103);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(883, 455);
			this.tableLayoutPanel2.TabIndex = 0;
			// 
			// listView
			// 
			this.listView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listView.FormattingEnabled = true;
			this.listView.ItemHeight = 16;
			this.listView.Location = new System.Drawing.Point(3, 3);
			this.listView.Name = "listView";
			this.listView.Size = new System.Drawing.Size(877, 449);
			this.listView.Sorted = true;
			this.listView.TabIndex = 0;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnExportPHP);
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
			this.groupBox1.Size = new System.Drawing.Size(883, 94);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Input && Output file";
			// 
			// btnExportPHP
			// 
			this.btnExportPHP.Location = new System.Drawing.Point(738, 54);
			this.btnExportPHP.Name = "btnExportPHP";
			this.btnExportPHP.Size = new System.Drawing.Size(126, 34);
			this.btnExportPHP.TabIndex = 6;
			this.btnExportPHP.Text = "Export PHP";
			this.btnExportPHP.UseVisualStyleBackColor = true;
			this.btnExportPHP.Click += new System.EventHandler(this.btnExportPHP_Click);
			// 
			// btnExportExcel
			// 
			this.btnExportExcel.Location = new System.Drawing.Point(738, 17);
			this.btnExportExcel.Name = "btnExportExcel";
			this.btnExportExcel.Size = new System.Drawing.Size(126, 34);
			this.btnExportExcel.TabIndex = 3;
			this.btnExportExcel.Text = "Export Excel";
			this.btnExportExcel.UseVisualStyleBackColor = true;
			this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
			// 
			// btnBrowseExcel
			// 
			this.btnBrowseExcel.Location = new System.Drawing.Point(650, 54);
			this.btnBrowseExcel.Name = "btnBrowseExcel";
			this.btnBrowseExcel.Size = new System.Drawing.Size(75, 34);
			this.btnBrowseExcel.TabIndex = 5;
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
			this.tbxExcelPath.Location = new System.Drawing.Point(142, 60);
			this.tbxExcelPath.Name = "tbxExcelPath";
			this.tbxExcelPath.Size = new System.Drawing.Size(493, 23);
			this.tbxExcelPath.TabIndex = 4;
			// 
			// tbxPHPPath
			// 
			this.tbxPHPPath.Location = new System.Drawing.Point(142, 23);
			this.tbxPHPPath.Name = "tbxPHPPath";
			this.tbxPHPPath.Size = new System.Drawing.Size(493, 23);
			this.tbxPHPPath.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 63);
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
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(889, 561);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.Name = "MainForm";
			this.Text = "Vietnamese Customization for Moodle";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox tbxPHPPath;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnExportExcel;
		private System.Windows.Forms.Button btnBrowsePHP;
		private System.Windows.Forms.OpenFileDialog openPHPFileDialog;
		private System.Windows.Forms.ListBox listView;
		private System.Windows.Forms.SaveFileDialog saveExcelFileDialog;
		private System.Windows.Forms.TextBox tbxExcelPath;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnBrowseExcel;
		private System.Windows.Forms.Button btnExportPHP;
		private System.Windows.Forms.OpenFileDialog openExcelFileDialog;
		private System.Windows.Forms.SaveFileDialog savePHPFileDialog;
	}
}


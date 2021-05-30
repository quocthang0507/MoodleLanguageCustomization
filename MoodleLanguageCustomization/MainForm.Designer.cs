
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
			this.components = new System.ComponentModel.Container();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.lbxSource = new System.Windows.Forms.ListBox();
			this.contextMenuSource = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.copySource_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.lbxDestination = new System.Windows.Forms.ListBox();
			this.contextMenuDestination = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.copyDestination_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnDeleteAll = new System.Windows.Forms.Button();
			this.btnDeleteOne = new System.Windows.Forms.Button();
			this.btnTranslateAll = new System.Windows.Forms.Button();
			this.btnTranslateOne = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnExport = new System.Windows.Forms.Button();
			this.btnBrowse = new System.Windows.Forms.Button();
			this.tbxOutputPath = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tbxInputPath = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.contextMenuSource.SuspendLayout();
			this.contextMenuDestination.SuspendLayout();
			this.panel1.SuspendLayout();
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
			this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 561);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 3;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
			this.tableLayoutPanel2.Controls.Add(this.lbxSource, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.lbxDestination, 2, 0);
			this.tableLayoutPanel2.Controls.Add(this.panel1, 1, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 103);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(778, 455);
			this.tableLayoutPanel2.TabIndex = 0;
			// 
			// lbxSource
			// 
			this.lbxSource.ContextMenuStrip = this.contextMenuSource;
			this.lbxSource.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lbxSource.FormattingEnabled = true;
			this.lbxSource.ItemHeight = 16;
			this.lbxSource.Location = new System.Drawing.Point(3, 3);
			this.lbxSource.Name = "lbxSource";
			this.lbxSource.Size = new System.Drawing.Size(344, 449);
			this.lbxSource.Sorted = true;
			this.lbxSource.TabIndex = 0;
			// 
			// contextMenuSource
			// 
			this.contextMenuSource.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copySource_toolStripMenuItem});
			this.contextMenuSource.Name = "contextMenuSource";
			this.contextMenuSource.Size = new System.Drawing.Size(181, 48);
			// 
			// copySource_toolStripMenuItem
			// 
			this.copySource_toolStripMenuItem.Name = "copySource_toolStripMenuItem";
			this.copySource_toolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.copySource_toolStripMenuItem.Text = "Copy to clipboard";
			this.copySource_toolStripMenuItem.Click += new System.EventHandler(this.copySource_toolStripMenuItem_Click);
			// 
			// lbxDestination
			// 
			this.lbxDestination.ContextMenuStrip = this.contextMenuDestination;
			this.lbxDestination.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lbxDestination.FormattingEnabled = true;
			this.lbxDestination.ItemHeight = 16;
			this.lbxDestination.Location = new System.Drawing.Point(430, 3);
			this.lbxDestination.Name = "lbxDestination";
			this.lbxDestination.Size = new System.Drawing.Size(345, 449);
			this.lbxDestination.Sorted = true;
			this.lbxDestination.TabIndex = 1;
			// 
			// contextMenuDestination
			// 
			this.contextMenuDestination.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyDestination_toolStripMenuItem});
			this.contextMenuDestination.Name = "contextMenu";
			this.contextMenuDestination.Size = new System.Drawing.Size(170, 26);
			// 
			// copyDestination_toolStripMenuItem
			// 
			this.copyDestination_toolStripMenuItem.Name = "copyDestination_toolStripMenuItem";
			this.copyDestination_toolStripMenuItem.Size = new System.Drawing.Size(169, 22);
			this.copyDestination_toolStripMenuItem.Text = "Copy to clipboard";
			this.copyDestination_toolStripMenuItem.Click += new System.EventHandler(this.copyDestination_toolStripMenuItem_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnDeleteAll);
			this.panel1.Controls.Add(this.btnDeleteOne);
			this.panel1.Controls.Add(this.btnTranslateAll);
			this.panel1.Controls.Add(this.btnTranslateOne);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(353, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(71, 449);
			this.panel1.TabIndex = 2;
			// 
			// btnDeleteAll
			// 
			this.btnDeleteAll.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnDeleteAll.Location = new System.Drawing.Point(11, 315);
			this.btnDeleteAll.Name = "btnDeleteAll";
			this.btnDeleteAll.Size = new System.Drawing.Size(50, 50);
			this.btnDeleteAll.TabIndex = 8;
			this.btnDeleteAll.Text = "<<";
			this.btnDeleteAll.UseVisualStyleBackColor = true;
			// 
			// btnDeleteOne
			// 
			this.btnDeleteOne.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnDeleteOne.Location = new System.Drawing.Point(11, 250);
			this.btnDeleteOne.Name = "btnDeleteOne";
			this.btnDeleteOne.Size = new System.Drawing.Size(50, 50);
			this.btnDeleteOne.TabIndex = 7;
			this.btnDeleteOne.Text = "<";
			this.btnDeleteOne.UseVisualStyleBackColor = true;
			// 
			// btnTranslateAll
			// 
			this.btnTranslateAll.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnTranslateAll.Location = new System.Drawing.Point(11, 173);
			this.btnTranslateAll.Name = "btnTranslateAll";
			this.btnTranslateAll.Size = new System.Drawing.Size(50, 50);
			this.btnTranslateAll.TabIndex = 6;
			this.btnTranslateAll.Text = ">>";
			this.btnTranslateAll.UseVisualStyleBackColor = true;
			// 
			// btnTranslateOne
			// 
			this.btnTranslateOne.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnTranslateOne.Location = new System.Drawing.Point(11, 105);
			this.btnTranslateOne.Name = "btnTranslateOne";
			this.btnTranslateOne.Size = new System.Drawing.Size(50, 50);
			this.btnTranslateOne.TabIndex = 5;
			this.btnTranslateOne.Text = ">";
			this.btnTranslateOne.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnExport);
			this.groupBox1.Controls.Add(this.btnBrowse);
			this.groupBox1.Controls.Add(this.tbxOutputPath);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.tbxInputPath);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox1.Location = new System.Drawing.Point(3, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(778, 94);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Input && Output file";
			// 
			// btnExport
			// 
			this.btnExport.Location = new System.Drawing.Point(641, 57);
			this.btnExport.Name = "btnExport";
			this.btnExport.Size = new System.Drawing.Size(75, 34);
			this.btnExport.TabIndex = 4;
			this.btnExport.Text = "Export";
			this.btnExport.UseVisualStyleBackColor = true;
			// 
			// btnBrowse
			// 
			this.btnBrowse.Location = new System.Drawing.Point(641, 17);
			this.btnBrowse.Name = "btnBrowse";
			this.btnBrowse.Size = new System.Drawing.Size(75, 34);
			this.btnBrowse.TabIndex = 3;
			this.btnBrowse.Text = "Browse...";
			this.btnBrowse.UseVisualStyleBackColor = true;
			this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
			// 
			// tbxOutputPath
			// 
			this.tbxOutputPath.Location = new System.Drawing.Point(142, 63);
			this.tbxOutputPath.Name = "tbxOutputPath";
			this.tbxOutputPath.Size = new System.Drawing.Size(493, 23);
			this.tbxOutputPath.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(30, 63);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(103, 17);
			this.label2.TabIndex = 0;
			this.label2.Text = "Output file (Vi):";
			// 
			// tbxInputPath
			// 
			this.tbxInputPath.Location = new System.Drawing.Point(142, 23);
			this.tbxInputPath.Name = "tbxInputPath";
			this.tbxInputPath.Size = new System.Drawing.Size(493, 23);
			this.tbxInputPath.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(30, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(96, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Input file (En):";
			// 
			// openFileDialog
			// 
			this.openFileDialog.FileName = "Select a PHP file";
			this.openFileDialog.Filter = "PHP file (*.php)|*.php";
			this.openFileDialog.Title = "Open PHP file";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 561);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.Name = "MainForm";
			this.Text = "Vietnamese Customization for Moodle";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.contextMenuSource.ResumeLayout(false);
			this.contextMenuDestination.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox tbxOutputPath;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbxInputPath;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnExport;
		private System.Windows.Forms.Button btnBrowse;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.ListBox lbxSource;
		private System.Windows.Forms.ListBox lbxDestination;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnDeleteAll;
		private System.Windows.Forms.Button btnDeleteOne;
		private System.Windows.Forms.Button btnTranslateAll;
		private System.Windows.Forms.Button btnTranslateOne;
		private System.Windows.Forms.ContextMenuStrip contextMenuSource;
		private System.Windows.Forms.ToolStripMenuItem copySource_toolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip contextMenuDestination;
		private System.Windows.Forms.ToolStripMenuItem copyDestination_toolStripMenuItem;
	}
}


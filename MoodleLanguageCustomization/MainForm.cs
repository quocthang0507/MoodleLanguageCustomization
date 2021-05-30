using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MoodleLanguageCustomization
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void btnBrowsePHP_Click(object sender, EventArgs e)
		{
			if (openPHPFileDialog.ShowDialog() == DialogResult.OK)
			{
				try
				{
					var filePath = openPHPFileDialog.FileName;
					using (StreamReader reader = new StreamReader(filePath))
					{
						string content = reader.ReadToEnd();
						var strings = content.Split(new string[] { "$string" }, StringSplitOptions.RemoveEmptyEntries).ToList();
						strings = strings.Select(str => str.Trim()).ToList();
						if (strings[0].Contains("<?php"))
							strings.RemoveAt(0);
						listView.DataSource = strings;
					}
					tbxPHPPath.Text = filePath;
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "Error");
				}
			}
		}

		private void btnExportExcel_Click(object sender, EventArgs e)
		{
			if (listView.DataSource == null || tbxPHPPath.Text == null)
				return;

			string filename = Path.GetFileNameWithoutExtension(tbxPHPPath.Text);
			saveExcelFileDialog.FileName = filename + ".xlsx";
			List<string> strings = listView.DataSource as List<string>;
			if (saveExcelFileDialog.ShowDialog() == DialogResult.OK)
			{
				try
				{
					var filePath = saveExcelFileDialog.FileName;
					using (ExcelPackage excel = new ExcelPackage())
					{
						var workSheet = excel.Workbook.Worksheets.Add(filename + ".php");
						for (int i = 0; i < strings.Count; i++)
						{
							string line = strings[i];
							string[] arr = line.Split('=').Select(str => str.Trim()).ToArray();
							workSheet.Cells[i + 1, 1].Value = arr[0];
							workSheet.Cells[i + 1, 2].Value = arr[1];
						}
						workSheet.Column(1).AutoFit();

						if (File.Exists(filePath))
							File.Delete(filePath);

						// Create excel file on physical disk 
						FileStream objFileStrm = File.Create(filePath);
						objFileStrm.Close();

						// Write content to excel file 
						File.WriteAllBytes(filePath, excel.GetAsByteArray());
					}
					MessageBox.Show("Exported to Excel", "Successfully");
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "Error");
				}
			}
		}

		private void btnBrowseExcel_Click(object sender, EventArgs e)
		{
			if (openExcelFileDialog.ShowDialog() == DialogResult.OK)
			{
				try
				{
					var filePath = openExcelFileDialog.FileName;
					tbxExcelPath.Text = filePath;
					
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "Error");
				}
			}
		}

		private void btnExportPHP_Click(object sender, EventArgs e)
		{

		}
	}
}

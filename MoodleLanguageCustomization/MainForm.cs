﻿using MoodleLanguageCustomization.Model;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoodleLanguageCustomization
{
	public partial class MainForm : Form
	{
		private List<PhpString> dataSource;

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
					tbxPHPPath.Text = filePath;
					dataSource = new List<PhpString>();
					dataSource = ReadPhpStrings(filePath);
					gridView.DataSource = dataSource;
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "Error");
				}
			}
		}

		private void btnExportExcel_Click(object sender, EventArgs e)
		{
			if (dataSource == null || tbxPHPPath.Text == null)
				return;

			if (File.Exists(tbxPHPPath.Text))
			{
				string filename = Path.GetFileNameWithoutExtension(tbxPHPPath.Text);
				saveExcelFileDialog.FileName = filename + ".xlsx";
				if (saveExcelFileDialog.ShowDialog() == DialogResult.OK)
				{
					try
					{
						var filePath = saveExcelFileDialog.FileName;
						ExportToExcel(filePath, dataSource);
						MessageBox.Show("Exported to Excel file", "Successfully");
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message, "Error");
					}
				}
			}
			else
			{
				var files = dataSource.Select(str => str.Filename);
				if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
				{
					var folderPath = folderBrowserDialog.SelectedPath;
					foreach (var file in files)
					{
						string filename = Path.GetFileNameWithoutExtension(file);
						var strings = dataSource.Where(str => str.Filename == filename).ToList();
						string filePath = Path.Combine(folderPath, filename + ".xlsx");
						try
						{
							ExportToExcel(filePath, strings);
						}
						catch (Exception ex)
						{
							MessageBox.Show(ex.Message, "Error");
						}
					}
					MessageBox.Show("Exported to Excel files", "Successfully");
				}
			}
		}

		private static void ExportToExcel(string filePath, List<PhpString> strings)
		{
			using (ExcelPackage excel = new ExcelPackage())
			{
				var workSheet_en = excel.Workbook.Worksheets.Add("source (en)");
				var workSheet_vi = excel.Workbook.Worksheets.Add("destination (vi)");
				for (int i = 0; i < strings.Count; i++)
				{
					string line = strings[i].String;
					string[] arr = line.Split('=').Select(str => str.Trim()).ToArray();
					workSheet_en.Cells[i + 1, 1].Value = "$string" + arr[0];
					workSheet_vi.Cells[i + 1, 1].Value = "$string" + arr[0];
					workSheet_en.Cells[i + 1, 2].Value = arr[1];
				}
				workSheet_en.Column(1).AutoFit();
				workSheet_vi.Column(1).AutoFit();

				if (File.Exists(filePath))
					File.Delete(filePath);

				// Create excel file on physical disk 
				FileStream objFileStrm = File.Create(filePath);
				objFileStrm.Close();

				// Write content to excel file 
				File.WriteAllBytes(filePath, excel.GetAsByteArray());
				excel.Dispose();
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
					//...
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

		private void btnOpenFolder_Click(object sender, EventArgs e)
		{
			if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
			{
				try
				{
					var folderPath = folderBrowserDialog.SelectedPath;
					tbxPHPPath.Text = folderPath;
					Task.Run(() =>
					{
						string[] phpFiles = Directory.GetFiles(folderPath, "*.php");
						dataSource = new List<PhpString>();
						foreach (var file in phpFiles)
						{
							var strings = ReadPhpStrings(file);
							dataSource.AddRange(strings);
						}
						gridView.Invoke((MethodInvoker)(() => gridView.DataSource = dataSource));
					});
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "Error");
				}
			}
		}

		private static List<PhpString> ReadPhpStrings(string filePath)
		{
			StreamReader reader = new StreamReader(filePath);
			string content = reader.ReadToEnd();
			var strings = content.Split(new string[] { "$string" }, StringSplitOptions.RemoveEmptyEntries).ToList();
			strings = strings.Select(str => str.Trim()).ToList();
			if (strings[0].Contains("<?php"))
				strings.RemoveAt(0);
			return strings.Select(str => new PhpString { Filename = Path.GetFileNameWithoutExtension(filePath), String = str }).ToList();
		}
	}
}

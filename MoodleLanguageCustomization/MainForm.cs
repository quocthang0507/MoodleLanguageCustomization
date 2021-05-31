using MoodleLanguageCustomization.Model;
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
		private string csv = "files and folders.csv";
		private double percent = 0f;
		private List<KeyValuePair<string, string>> folders;

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
					Task.Run(() =>
					{
						var filePath = openPHPFileDialog.FileName;
						tbxPHPPath.Text = filePath;
						dataSource = new List<PhpString>();
						dataSource = ReadPhpStrings(filePath);
						gridView.Invoke((MethodInvoker)(() => gridView.DataSource = dataSource));
					});
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
						Task.Run(() =>
						{
							var filePath = saveExcelFileDialog.FileName;
							ExportToExcel(filePath, dataSource);
							MessageBox.Show("Exported to Excel file", "Successfully");
						});
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
					try
					{
						ReadCsvFile();
						Task.Run(() =>
						{
							var folderPath = folderBrowserDialog.SelectedPath;
							percent = 0f;
							double interval = 100f / files.Count();
							foreach (var filename in files)
							{
								var strings = dataSource.Where(str => str.Filename == filename).ToList();
								var found = folders.Where(f => f.Key.Equals(filename + ".php")).ToList();
								if (found != null && found.Count() > 0)
								{
									string folderName = found[0].Value;
									string newFolderPath = Path.Combine(folderPath, folderName);
									Directory.CreateDirectory(newFolderPath);
									string newFilePath = Path.Combine(newFolderPath, filename + ".xlsx");
									ExportToExcel(newFilePath, strings);
									percent += interval;
									lblPercent.Invoke((MethodInvoker)(() => lblPercent.Text = $"{percent:0.##}%"));
								}
							}
							MessageBox.Show("Exported to Excel files", "Successfully");
						});
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message, "Error");
					}
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
					string[] arr = line.Split(new string[] { " = " }, StringSplitOptions.RemoveEmptyEntries).Select(str => str.Trim()).ToArray();
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
						double interval = 100f / phpFiles.Length;
						percent = 0f;
						foreach (var file in phpFiles)
						{
							var strings = ReadPhpStrings(file);
							dataSource.AddRange(strings);
							percent += interval;
							lblPercent.Invoke((MethodInvoker)(() => lblPercent.Text = $"{percent:0.##}%"));
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

		private List<PhpString> ReadPhpStrings(string filePath)
		{
			StreamReader reader = new StreamReader(filePath);
			string content = reader.ReadToEnd();
			var strings = content.Split(new string[] { "$string" }, StringSplitOptions.RemoveEmptyEntries).ToList();
			strings = strings.Select(str => str.Trim()).ToList();
			if (strings[0].Contains("<?php"))
				strings.RemoveAt(0);
			return strings.Select(str => new PhpString { Filename = Path.GetFileNameWithoutExtension(filePath), String = str }).ToList();
		}

		private void ReadCsvFile()
		{
			folders = new List<KeyValuePair<string, string>>();
			using (StreamReader reader = new StreamReader(csv))
			{
				string line;
				while ((line = reader.ReadLine()) != null)
				{
					string[] data = line.Split(',');
					folders.Add(new KeyValuePair<string, string>(data[1], data[0]));
				}
			}
		}
	}
}

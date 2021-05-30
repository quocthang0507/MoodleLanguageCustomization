using System;
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

		private void btnBrowse_Click(object sender, EventArgs e)
		{
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				try
				{
					var filePath = openFileDialog.FileName;
					using (StreamReader reader = new StreamReader(filePath))
					{
						string content = reader.ReadToEnd();
						var strings = content.Split(new string[] { "$string" }, StringSplitOptions.RemoveEmptyEntries).ToList();
						strings = strings.Select(str => str.Trim()).ToList();
						if (strings[0].Contains("<?php"))
							strings.RemoveAt(0);
						lbxSource.DataSource = strings;
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "Error");
				}
			}
		}

		private void copyDestination_toolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (lbxDestination.SelectedItem != null)
				Clipboard.SetText(lbxDestination.SelectedItem.ToString());
		}

		private void copySource_toolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (lbxSource.SelectedItem != null)
				Clipboard.SetText(lbxSource.SelectedItem.ToString());
		}
	}
}

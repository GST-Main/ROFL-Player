using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;

namespace ROFL_Player
{
	public partial class Form1 : Form
	{
		(string language, string code)[] languages = new[] { ("English", "en_US"), ("English(UK)", "en_GB"), ("English(Australia)", "en_AU"), ("Korean", "ko_KR"), ("Chinese", "zh_CN"), ("Japanese", "ja_JP"), ("German", "de_DE"), ("Italian", "it_IT"), ("French", "fr_FR"), ("Spanish", "es_ES"), ("Spanish(Latin America)", "es_MX"), ("Russian", "ru_RU"), ("Greek", "el_GR"), ("Polish", "pl_PL"), ("Romanian", "ro_RO"), ("Portuguese", "pt_BR"), ("Taiwanese", "zh_TW"), ("Hungarian", "hu_HU"), ("Turkish", "tr_TR") };
		(string language, string code)[]? availableLangs;
		
		string? exePath;
		string? roflPath;
		string? selectedLang;

		public Form1()
		{
			InitializeComponent();
		}

		private void button_FindEXE_Click(object sender, EventArgs e)
		{
			var openFileDialog = new OpenFileDialog()
			{
				FileName = "",
				Filter = "League of Legends game file|League of Legends.exe",
				Title = "Select a League of Legends.exe"
			};
			var result = openFileDialog.ShowDialog();

			if (result == DialogResult.OK)
			{
				exePath = openFileDialog.FileName;
				textBox_exe.Text = exePath;

				UpdateAvailableLanguages(Path.GetDirectoryName(exePath));

				if (availableLangs != null)
					UpdateLangComboItems();
			}

			UpdatePlayButton();
		}

		private void button_FindROFL_Click(object sender, EventArgs e)
		{
			var openFileDialog = new OpenFileDialog()
			{
				FileName = "",
				Filter = "League of Legends replay file|*.rofl",
				Title = "Select a replay file"
			};
			var result = openFileDialog.ShowDialog();

			if (result == DialogResult.OK)
			{
				roflPath = openFileDialog.FileName;
				textBox_rofl.Text = roflPath;
			}

			UpdatePlayButton();
		}

		private void UpdateLangComboItems()
		{
			comboBox_Language.Items.Clear();
			foreach ((string langauge, string code) elem in availableLangs)
			{
				comboBox_Language.Items.Add(elem.langauge);
			}
		}

		private void UpdateAvailableLanguages(string exeDirectory)
		{
			string dataDirectory = Path.Combine(exeDirectory, "DATA", "FINAL");
			string[] filePaths = Directory.GetFiles(dataDirectory);
			string[] files = filePaths.Select(elem => Path.GetFileName(elem)).ToArray();

			List<string> codes = new();
			foreach (string file in files)
			{
				if (Regex.IsMatch(file, @"(UI\.).....(\.wad\.client)"))
				{
					var splitted = file.Split(".");
					codes.Add(splitted[1]);
				}
			}

			(string, string)[] available = Array.FindAll(languages, language => codes.Contains(language.code));
			availableLangs = available;
		}

		private void comboBox_Language_SelectedValueChanged(object sender, EventArgs e)
		{
			selectedLang = comboBox_Language.Text;

			UpdatePlayButton();
		}

		private void UpdatePlayButton()
		{
			if (exePath != null && roflPath != null && selectedLang != null)
				button_Play.Enabled = true;
			else
				button_Play.Enabled = false;
		}
	}
}
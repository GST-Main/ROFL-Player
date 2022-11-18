namespace ROFL_Player
{
	public partial class Form1 : Form
	{
		(string, string)[] languages = new[] { ("English", "en_US"), ("English(UK)", "en_GB"), ("English(Australia)", "en_AU"), ("Korean", "ko_KR"), ("Chinese", "zh_CN"), ("Japanese", "ja_JP"), ("German", "de_DE"), ("Italian", "it_IT"), ("French", "fr_FR"), ("Spanish", "es_ES"), ("Spanish(Latin America)", "es_MX"), ("Russian", "ru_RU"), ("Greek", "el_GR"), ("Polish", "pl_PL"), ("Romanian", "ro_RO"), ("Portuguese", "pt_BR"), ("Taiwanese", "zh_TW"), ("Hungarian", "hu_HU"), ("Turkish", "tr_TR") };

		public Form1()
		{
			InitializeComponent();
			InitLangComboItems();
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
				textBox_exe.Text = openFileDialog.FileName;
			}
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
				textBox_rofl.Text = openFileDialog.FileName;
			}
		}

		private void InitLangComboItems()
		{
			foreach ((string langauge, string code) elem in languages)
			{
				comboBox_Language.Items.Add(elem.langauge);
			}
		}
	}
}
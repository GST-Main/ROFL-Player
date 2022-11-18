namespace ROFL_Player
{
	public partial class Form1 : Form
	{
		(string, string)[] languages = new[] { ("English", "en_US"), ("Korean", "ko_KR") };

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
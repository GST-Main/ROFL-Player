namespace ROFL_Player
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox_exe = new System.Windows.Forms.TextBox();
			this.textBox_rofl = new System.Windows.Forms.TextBox();
			this.button_FindEXE = new System.Windows.Forms.Button();
			this.button_FindROFL = new System.Windows.Forms.Button();
			this.comboBox_Language = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.button_Play = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(136, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "League of Legends.exe :";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(96, 49);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(52, 15);
			this.label2.TabIndex = 1;
			this.label2.Text = "rofl file :";
			// 
			// textBox_exe
			// 
			this.textBox_exe.Location = new System.Drawing.Point(154, 12);
			this.textBox_exe.Name = "textBox_exe";
			this.textBox_exe.ReadOnly = true;
			this.textBox_exe.Size = new System.Drawing.Size(346, 23);
			this.textBox_exe.TabIndex = 2;
			// 
			// textBox_rofl
			// 
			this.textBox_rofl.Location = new System.Drawing.Point(154, 45);
			this.textBox_rofl.Name = "textBox_rofl";
			this.textBox_rofl.ReadOnly = true;
			this.textBox_rofl.Size = new System.Drawing.Size(346, 23);
			this.textBox_rofl.TabIndex = 3;
			// 
			// button_FindEXE
			// 
			this.button_FindEXE.Location = new System.Drawing.Point(506, 12);
			this.button_FindEXE.Name = "button_FindEXE";
			this.button_FindEXE.Size = new System.Drawing.Size(75, 23);
			this.button_FindEXE.TabIndex = 4;
			this.button_FindEXE.Text = "Find";
			this.button_FindEXE.UseVisualStyleBackColor = true;
			this.button_FindEXE.Click += new System.EventHandler(this.button_FindEXE_Click);
			// 
			// button_FindROFL
			// 
			this.button_FindROFL.Location = new System.Drawing.Point(506, 44);
			this.button_FindROFL.Name = "button_FindROFL";
			this.button_FindROFL.Size = new System.Drawing.Size(75, 23);
			this.button_FindROFL.TabIndex = 5;
			this.button_FindROFL.Text = "Find";
			this.button_FindROFL.UseVisualStyleBackColor = true;
			this.button_FindROFL.Click += new System.EventHandler(this.button_FindROFL_Click);
			// 
			// comboBox_Language
			// 
			this.comboBox_Language.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox_Language.FormattingEnabled = true;
			this.comboBox_Language.Location = new System.Drawing.Point(154, 78);
			this.comboBox_Language.Name = "comboBox_Language";
			this.comboBox_Language.Size = new System.Drawing.Size(346, 23);
			this.comboBox_Language.TabIndex = 6;
			this.comboBox_Language.SelectedValueChanged += new System.EventHandler(this.comboBox_Language_SelectedValueChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(86, 82);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(62, 15);
			this.label3.TabIndex = 7;
			this.label3.Text = "Language:";
			// 
			// button_Play
			// 
			this.button_Play.Enabled = false;
			this.button_Play.Location = new System.Drawing.Point(506, 78);
			this.button_Play.Name = "button_Play";
			this.button_Play.Size = new System.Drawing.Size(75, 23);
			this.button_Play.TabIndex = 8;
			this.button_Play.Text = "Play!";
			this.button_Play.UseVisualStyleBackColor = true;
			this.button_Play.Click += new System.EventHandler(this.button_Play_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(599, 121);
			this.Controls.Add(this.button_Play);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.comboBox_Language);
			this.Controls.Add(this.button_FindROFL);
			this.Controls.Add(this.button_FindEXE);
			this.Controls.Add(this.textBox_rofl);
			this.Controls.Add(this.textBox_exe);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.Text = "ROFL Player";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Label label1;
		private Label label2;
		private TextBox textBox_exe;
		private TextBox textBox_rofl;
		private Button button_FindEXE;
		private Button button_FindROFL;
		private ComboBox comboBox_Language;
		private Label label3;
		private Button button_Play;
	}
}
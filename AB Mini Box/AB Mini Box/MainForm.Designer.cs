/*
 * Created by XereX(codaaj)
 * SharpDevelop 5.1 -> C# NET FrameWork 4.5.2
 * Thanks forums :)
 */
namespace AB_Mini_Box
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private FastColoredTextBoxNS.FastColoredTextBox fastColoredTextBox1;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Panel commentBox;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox commentText1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Panel inputBox;
		private System.Windows.Forms.TextBox variableText1;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.TextBox textText1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem colorsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem discordServerToolStripMenuItem;
		private System.Windows.Forms.Panel ifBox1;
		private System.Windows.Forms.TextBox functionText1;
		private System.Windows.Forms.TextBox variableText2;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.ToolStripMenuItem dToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem officialYoutubeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tutorialsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem templatesToolStripMenuItem;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.fastColoredTextBox1 = new FastColoredTextBoxNS.FastColoredTextBox();
			this.commentBox = new System.Windows.Forms.Panel();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.commentText1 = new System.Windows.Forms.TextBox();
			this.inputBox = new System.Windows.Forms.Panel();
			this.variableText1 = new System.Windows.Forms.TextBox();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.textText1 = new System.Windows.Forms.TextBox();
			this.ifBox1 = new System.Windows.Forms.Panel();
			this.functionText1 = new System.Windows.Forms.TextBox();
			this.variableText2 = new System.Windows.Forms.TextBox();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.colorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.discordServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.dToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.officialYoutubeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tutorialsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.templatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox1)).BeginInit();
			this.commentBox.SuspendLayout();
			this.inputBox.SuspendLayout();
			this.ifBox1.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// listBox1
			// 
			this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.listBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.listBox1.ForeColor = System.Drawing.Color.White;
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 17;
			this.listBox1.Items.AddRange(new object[] {
			"Add comment",
			"Print text",
			"Input text",
			"Quit",
			"Set variable",
			"Set title",
			"Set colors",
			"Clear",
			"Off syscom",
			"Set encoding",
			"Copy",
			"Move",
			"Start",
			"Kill",
			"Delete",
			"Create folder",
			"Delete folder",
			"Read file text",
			"Function",
			"Run function",
			"If",
			"Pause",
			"Wait",
			"Processes",
			"Else",
			"Dir files/folders",
			"Rename"});
			this.listBox1.Location = new System.Drawing.Point(608, 25);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(135, 429);
			this.listBox1.TabIndex = 1;
			this.listBox1.DoubleClick += new System.EventHandler(this.ListBox1DoubleClick);
			// 
			// fastColoredTextBox1
			// 
			this.fastColoredTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.fastColoredTextBox1.AutoCompleteBracketsList = new char[] {
		'(',
		')',
		'{',
		'}',
		'[',
		']',
		'\"',
		'\"',
		'\'',
		'\''};
			this.fastColoredTextBox1.AutoIndentCharsPatterns = "^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;=]+);\r\n^\\s*(case|default)\\s*[^:]*" +
	"(?<range>:)\\s*(?<range>[^;]+);";
			this.fastColoredTextBox1.AutoScrollMinSize = new System.Drawing.Size(27, 14);
			this.fastColoredTextBox1.BackBrush = null;
			this.fastColoredTextBox1.BackColor = System.Drawing.Color.Black;
			this.fastColoredTextBox1.CharHeight = 14;
			this.fastColoredTextBox1.CharWidth = 8;
			this.fastColoredTextBox1.CurrentLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.fastColoredTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.fastColoredTextBox1.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.fastColoredTextBox1.ForeColor = System.Drawing.SystemColors.Window;
			this.fastColoredTextBox1.IndentBackColor = System.Drawing.Color.Black;
			this.fastColoredTextBox1.IsReplaceMode = false;
			this.fastColoredTextBox1.Location = new System.Drawing.Point(0, 25);
			this.fastColoredTextBox1.Name = "fastColoredTextBox1";
			this.fastColoredTextBox1.PaddingBackColor = System.Drawing.Color.Black;
			this.fastColoredTextBox1.Paddings = new System.Windows.Forms.Padding(0);
			this.fastColoredTextBox1.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
			this.fastColoredTextBox1.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fastColoredTextBox1.ServiceColors")));
			this.fastColoredTextBox1.Size = new System.Drawing.Size(608, 429);
			this.fastColoredTextBox1.TabIndex = 2;
			this.fastColoredTextBox1.Zoom = 100;
			// 
			// commentBox
			// 
			this.commentBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.commentBox.BackColor = System.Drawing.Color.Gray;
			this.commentBox.Controls.Add(this.button2);
			this.commentBox.Controls.Add(this.button1);
			this.commentBox.Controls.Add(this.commentText1);
			this.commentBox.Location = new System.Drawing.Point(290, 34);
			this.commentBox.Name = "commentBox";
			this.commentBox.Size = new System.Drawing.Size(299, 88);
			this.commentBox.TabIndex = 3;
			this.commentBox.Visible = false;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(3, 61);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(293, 23);
			this.button2.TabIndex = 2;
			this.button2.Text = "Add";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(3, 3);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(293, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "Cancel";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// commentText1
			// 
			this.commentText1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.commentText1.Location = new System.Drawing.Point(3, 28);
			this.commentText1.Name = "commentText1";
			this.commentText1.Size = new System.Drawing.Size(293, 27);
			this.commentText1.TabIndex = 0;
			this.commentText1.Text = "text";
			this.commentText1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CommentText1KeyDown);
			this.commentText1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CommentText1KeyPress);
			// 
			// inputBox
			// 
			this.inputBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.inputBox.BackColor = System.Drawing.Color.Gray;
			this.inputBox.Controls.Add(this.variableText1);
			this.inputBox.Controls.Add(this.button3);
			this.inputBox.Controls.Add(this.button4);
			this.inputBox.Controls.Add(this.textText1);
			this.inputBox.Location = new System.Drawing.Point(290, 31);
			this.inputBox.Name = "inputBox";
			this.inputBox.Size = new System.Drawing.Size(299, 120);
			this.inputBox.TabIndex = 4;
			this.inputBox.Visible = false;
			// 
			// variableText1
			// 
			this.variableText1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.variableText1.Location = new System.Drawing.Point(3, 61);
			this.variableText1.Name = "variableText1";
			this.variableText1.Size = new System.Drawing.Size(293, 27);
			this.variableText1.TabIndex = 3;
			this.variableText1.Text = "variable";
			this.variableText1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.VariableText1KeyDown);
			this.variableText1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.VariableText1KeyPress);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(3, 94);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(293, 23);
			this.button3.TabIndex = 2;
			this.button3.Text = "Add";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(3, 3);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(293, 23);
			this.button4.TabIndex = 1;
			this.button4.Text = "Cancel";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// textText1
			// 
			this.textText1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textText1.Location = new System.Drawing.Point(3, 28);
			this.textText1.Name = "textText1";
			this.textText1.Size = new System.Drawing.Size(293, 27);
			this.textText1.TabIndex = 0;
			this.textText1.Text = "text";
			this.textText1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextText1KeyDown);
			this.textText1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextText1KeyPress);
			// 
			// ifBox1
			// 
			this.ifBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ifBox1.BackColor = System.Drawing.Color.Gray;
			this.ifBox1.Controls.Add(this.functionText1);
			this.ifBox1.Controls.Add(this.variableText2);
			this.ifBox1.Controls.Add(this.button5);
			this.ifBox1.Controls.Add(this.button6);
			this.ifBox1.Controls.Add(this.textBox2);
			this.ifBox1.Location = new System.Drawing.Point(290, 31);
			this.ifBox1.Name = "ifBox1";
			this.ifBox1.Size = new System.Drawing.Size(299, 149);
			this.ifBox1.TabIndex = 5;
			this.ifBox1.Visible = false;
			// 
			// functionText1
			// 
			this.functionText1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.functionText1.Location = new System.Drawing.Point(3, 94);
			this.functionText1.Name = "functionText1";
			this.functionText1.Size = new System.Drawing.Size(293, 27);
			this.functionText1.TabIndex = 4;
			this.functionText1.Text = "function";
			this.functionText1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FunctionText1KeyDown);
			this.functionText1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FunctionText1KeyPress);
			// 
			// variableText2
			// 
			this.variableText2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.variableText2.Location = new System.Drawing.Point(3, 61);
			this.variableText2.Name = "variableText2";
			this.variableText2.Size = new System.Drawing.Size(293, 27);
			this.variableText2.TabIndex = 3;
			this.variableText2.Text = "variable";
			this.variableText2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.VariableText2KeyDown);
			this.variableText2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.VariableText2KeyPress);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(3, 123);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(293, 23);
			this.button5.TabIndex = 2;
			this.button5.Text = "Add";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.Button5Click);
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(3, 3);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(293, 23);
			this.button6.TabIndex = 1;
			this.button6.Text = "Cancel";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.Button6Click);
			// 
			// textBox2
			// 
			this.textBox2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox2.Location = new System.Drawing.Point(3, 28);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(293, 27);
			this.textBox2.TabIndex = 0;
			this.textBox2.Text = "text";
			this.textBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox2KeyDown);
			this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox2KeyPress);
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.fileToolStripMenuItem,
			this.runToolStripMenuItem,
			this.colorsToolStripMenuItem,
			this.discordServerToolStripMenuItem,
			this.dToolStripMenuItem,
			this.templatesToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(743, 25);
			this.menuStrip1.TabIndex = 5;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.saveToolStripMenuItem,
			this.openToolStripMenuItem});
			this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.White;
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(42, 21);
			this.fileToolStripMenuItem.Text = "File";
			this.fileToolStripMenuItem.Click += new System.EventHandler(this.FileToolStripMenuItemClick);
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
			this.saveToolStripMenuItem.Text = "Save";
			this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItemClick);
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
			this.openToolStripMenuItem.Text = "Open";
			this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItemClick);
			// 
			// runToolStripMenuItem
			// 
			this.runToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			this.runToolStripMenuItem.ForeColor = System.Drawing.Color.White;
			this.runToolStripMenuItem.Name = "runToolStripMenuItem";
			this.runToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
			this.runToolStripMenuItem.Text = "Run";
			this.runToolStripMenuItem.Click += new System.EventHandler(this.RunToolStripMenuItemClick);
			// 
			// colorsToolStripMenuItem
			// 
			this.colorsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			this.colorsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
			this.colorsToolStripMenuItem.Name = "colorsToolStripMenuItem";
			this.colorsToolStripMenuItem.Size = new System.Drawing.Size(59, 21);
			this.colorsToolStripMenuItem.Text = "Colors";
			this.colorsToolStripMenuItem.Click += new System.EventHandler(this.ColorsToolStripMenuItemClick);
			// 
			// discordServerToolStripMenuItem
			// 
			this.discordServerToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			this.discordServerToolStripMenuItem.ForeColor = System.Drawing.Color.White;
			this.discordServerToolStripMenuItem.Name = "discordServerToolStripMenuItem";
			this.discordServerToolStripMenuItem.Size = new System.Drawing.Size(110, 21);
			this.discordServerToolStripMenuItem.Text = "Discord Server";
			this.discordServerToolStripMenuItem.Click += new System.EventHandler(this.DiscordServerToolStripMenuItemClick);
			// 
			// dToolStripMenuItem
			// 
			this.dToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.aboutToolStripMenuItem,
			this.officialYoutubeToolStripMenuItem,
			this.tutorialsToolStripMenuItem});
			this.dToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			this.dToolStripMenuItem.ForeColor = System.Drawing.Color.White;
			this.dToolStripMenuItem.Name = "dToolStripMenuItem";
			this.dToolStripMenuItem.Size = new System.Drawing.Size(49, 21);
			this.dToolStripMenuItem.Text = "Help";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
			this.aboutToolStripMenuItem.Text = "About";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItemClick);
			// 
			// officialYoutubeToolStripMenuItem
			// 
			this.officialYoutubeToolStripMenuItem.Name = "officialYoutubeToolStripMenuItem";
			this.officialYoutubeToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
			this.officialYoutubeToolStripMenuItem.Text = "Official Youtube";
			this.officialYoutubeToolStripMenuItem.Click += new System.EventHandler(this.OfficialYoutubeToolStripMenuItemClick);
			// 
			// tutorialsToolStripMenuItem
			// 
			this.tutorialsToolStripMenuItem.Name = "tutorialsToolStripMenuItem";
			this.tutorialsToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
			this.tutorialsToolStripMenuItem.Text = "NONE";
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			this.openFileDialog1.Filter = "Text file(*.txt)|*.txt|Windows Shell(*.bat)|*.bat";
			this.openFileDialog1.Title = "Choose a file for open";
			this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenFileDialog1FileOk);
			// 
			// saveFileDialog1
			// 
			this.saveFileDialog1.Filter = "Text file(*.txt)|*.txt|Windows Shell(*.bat)|*.bat";
			this.saveFileDialog1.Title = "Chosee a file for save";
			this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.SaveFileDialog1FileOk);
			// 
			// templatesToolStripMenuItem
			// 
			this.templatesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			this.templatesToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
			this.templatesToolStripMenuItem.Name = "templatesToolStripMenuItem";
			this.templatesToolStripMenuItem.Size = new System.Drawing.Size(83, 21);
			this.templatesToolStripMenuItem.Text = "Templates";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(743, 454);
			this.Controls.Add(this.ifBox1);
			this.Controls.Add(this.inputBox);
			this.Controls.Add(this.commentBox);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.fastColoredTextBox1);
			this.Controls.Add(this.listBox1);
			this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "AB Mini Box Alpha dev0.8";
			((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox1)).EndInit();
			this.commentBox.ResumeLayout(false);
			this.commentBox.PerformLayout();
			this.inputBox.ResumeLayout(false);
			this.inputBox.PerformLayout();
			this.ifBox1.ResumeLayout(false);
			this.ifBox1.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}

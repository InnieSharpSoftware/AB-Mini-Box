/*
 * Created by XereX(codaaj)
 * SharpDevelop 5.1 -> C# NET FrameWork 4.5.2
 * Thanks forums :)
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Threading;

namespace AB_Mini_Box
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public string com;
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void ListBox1DoubleClick(object sender, EventArgs e)
		{
			if(listBox1.SelectedItem == "Add comment")
			{
				commentBox.Show();
				listBox1.Enabled = false;
				fastColoredTextBox1.ReadOnly = true;
				com = "comment";
				commentText1.Focus();
			}
			else if(listBox1.SelectedItem == "Print text")
			{
				commentBox.Show();
				listBox1.Enabled = false;
				fastColoredTextBox1.ReadOnly = true;
				com = "print";
				commentText1.Focus();
			}
			else if(listBox1.SelectedItem == "Input text")
			{
				inputBox.Show();
				listBox1.Enabled = false;
				fastColoredTextBox1.ReadOnly = true;
				com = "input";
				textText1.Focus();
			}
			else if(listBox1.SelectedItem == "Quit")
			{
				Clipboard.Clear();
				fastColoredTextBox1.SelectedText = "exit";
				fastColoredTextBox1.Paste();
				fastColoredTextBox1.Focus();
			}
			else if(listBox1.SelectedItem == "Function")
			{
				commentBox.Show();
				listBox1.Enabled = false;
				fastColoredTextBox1.ReadOnly = true;
				com = "func";
				commentText1.Focus();
			}
			else if(listBox1.SelectedItem == "Run function")
			{
				commentBox.Show();
				listBox1.Enabled = false;
				fastColoredTextBox1.ReadOnly = true;
				com = "runfunc";
				commentText1.Focus();
			}
			else if(listBox1.SelectedItem == "Set title")
			{
				commentBox.Show();
				listBox1.Enabled = false;
				fastColoredTextBox1.ReadOnly = true;
				com = "title";
				commentText1.Focus();
			}
			else if(listBox1.SelectedItem == "Set colors")
			{
				commentBox.Show();
				listBox1.Enabled = false;
				fastColoredTextBox1.ReadOnly = true;
				com = "colors";
				commentText1.Focus();
			}
			else if(listBox1.SelectedItem == "Set variable")
			{
				inputBox.Show();
				listBox1.Enabled = false;
				fastColoredTextBox1.ReadOnly = true;
				com = "var";
				textText1.Focus();
			}
			else if(listBox1.SelectedItem == "Off syscom")
			{
				Clipboard.Clear();
				fastColoredTextBox1.SelectedText = "echo off";
				fastColoredTextBox1.Paste();
				fastColoredTextBox1.Focus();
			}
			else if(listBox1.SelectedItem == "Pause")
			{
				Clipboard.Clear();
				fastColoredTextBox1.SelectedText = "pause";
				fastColoredTextBox1.Paste();
				fastColoredTextBox1.Focus();
			}
			else if(listBox1.SelectedItem == "Clear")
			{
				Clipboard.Clear();
				fastColoredTextBox1.SelectedText = "cls";
				fastColoredTextBox1.Paste();
				fastColoredTextBox1.Focus();
			}
			else if(listBox1.SelectedItem == "Set encoding")
			{
				commentBox.Show();
				listBox1.Enabled = false;
				fastColoredTextBox1.ReadOnly = true;
				com = "coding";
				commentText1.Focus();
			}
			else if(listBox1.SelectedItem == "Copy")
			{
				inputBox.Show();
				listBox1.Enabled = false;
				fastColoredTextBox1.ReadOnly = true;
				com = "copy";
				variableText1.Text = "to";
				textText1.Text = "source";
				textText1.Focus();
			}
			else if(listBox1.SelectedItem == "Move")
			{
				inputBox.Show();
				listBox1.Enabled = false;
				fastColoredTextBox1.ReadOnly = true;
				com = "move";
				variableText1.Text = "to";
				textText1.Text = "source";
				textText1.Focus();
			}
			else if(listBox1.SelectedItem == "Kill")
			{
				commentBox.Show();
				listBox1.Enabled = false;
				fastColoredTextBox1.ReadOnly = true;
				com = "kill";
				commentText1.Focus();
			}
			else if(listBox1.SelectedItem == "Start")
			{
				commentBox.Show();
				listBox1.Enabled = false;
				fastColoredTextBox1.ReadOnly = true;
				com = "start";
				commentText1.Focus();
			}
			else if(listBox1.SelectedItem == "Create folder")
			{
				commentBox.Show();
				listBox1.Enabled = false;
				fastColoredTextBox1.ReadOnly = true;
				com = "md";
				commentText1.Focus();
			}
			else if(listBox1.SelectedItem == "Delete folder")
			{
				commentBox.Show();
				listBox1.Enabled = false;
				fastColoredTextBox1.ReadOnly = true;
				com = "rd";
				commentText1.Focus();
			}
			else if(listBox1.SelectedItem == "Read file text")
			{
				commentBox.Show();
				listBox1.Enabled = false;
				fastColoredTextBox1.ReadOnly = true;
				com = "type";
				commentText1.Focus();
			}
			else if(listBox1.SelectedItem == "Dir files/folders")
			{
				commentBox.Show();
				listBox1.Enabled = false;
				fastColoredTextBox1.ReadOnly = true;
				com = "dir";
				commentText1.Focus();
			}
			else if(listBox1.SelectedItem == "If")
			{
				ifBox1.Show();
				listBox1.Enabled = false;
				fastColoredTextBox1.ReadOnly = true;
				textBox2.Focus();
			}
			else if(listBox1.SelectedItem == "Wait")
			{
				inputBox.Show();
				listBox1.Enabled = false;
				fastColoredTextBox1.ReadOnly = true;
				com = "wait";
				variableText1.Text = "host";
				textText1.Text = "second(s)";
				textText1.Focus();
			}
			else if(listBox1.SelectedItem == "Else")
			{
				inputBox.Show();
				listBox1.Enabled = false;
				fastColoredTextBox1.ReadOnly = true;
				com = "else";
				variableText1.Text = "function";
				textText1.Text = "variable";
				textText1.Focus();
			}
			else if(listBox1.SelectedItem == "Processes")
			{
				Clipboard.Clear();
				fastColoredTextBox1.SelectedText = "tasklist";
				fastColoredTextBox1.Paste();
				fastColoredTextBox1.Focus();
			}
			else if(listBox1.SelectedItem == "Rename")
			{
				inputBox.Show();
				listBox1.Enabled = false;
				fastColoredTextBox1.ReadOnly = true;
				com = "ren";
				variableText1.Text = "new name";
				textText1.Text = "source";
				textText1.Focus();
			}
		}
		void Button2Click(object sender, EventArgs e)
		{
			if (com == "comment")
			{
				Clipboard.Clear();
				fastColoredTextBox1.SelectedText = "::" + commentText1.Text;
				fastColoredTextBox1.Paste();
				commentBox.Hide();
				listBox1.Enabled = true;
				fastColoredTextBox1.ReadOnly = false;
				commentText1.Text = "text";
				fastColoredTextBox1.Focus();
			}
			else if (com == "print")
			{
				Clipboard.Clear();
				fastColoredTextBox1.SelectedText = "echo " + commentText1.Text;
				fastColoredTextBox1.Paste();
				commentBox.Hide();
				listBox1.Enabled = true;
				fastColoredTextBox1.ReadOnly = false;
				commentText1.Text = "text";
				fastColoredTextBox1.Focus();
			}
			else if (com == "func")
			{
				Clipboard.Clear();
				fastColoredTextBox1.SelectedText = ":" + commentText1.Text;
				fastColoredTextBox1.Paste();
				commentBox.Hide();
				listBox1.Enabled = true;
				fastColoredTextBox1.ReadOnly = false;
				commentText1.Text = "text";
				fastColoredTextBox1.Focus();
			}
			else if (com == "runfunc")
			{
				Clipboard.Clear();
				fastColoredTextBox1.SelectedText = "goto " + commentText1.Text;
				fastColoredTextBox1.Paste();
				commentBox.Hide();
				listBox1.Enabled = true;
				fastColoredTextBox1.ReadOnly = false;
				commentText1.Text = "text";
				fastColoredTextBox1.Focus();
			}
			else if (com == "title")
			{
				Clipboard.Clear();
				fastColoredTextBox1.SelectedText = "title " + commentText1.Text;
				fastColoredTextBox1.Paste();
				commentBox.Hide();
				listBox1.Enabled = true;
				fastColoredTextBox1.ReadOnly = false;
				commentText1.Text = "text";
				fastColoredTextBox1.Focus();
			}
			else if (com == "coding")
			{
				Clipboard.Clear();
				fastColoredTextBox1.SelectedText = "chcp " + commentText1.Text;
				fastColoredTextBox1.Paste();
				commentBox.Hide();
				listBox1.Enabled = true;
				fastColoredTextBox1.ReadOnly = false;
				commentText1.Text = "text";
				fastColoredTextBox1.Focus();
			}
			else if (com == "kill")
			{
				Clipboard.Clear();
				fastColoredTextBox1.SelectedText = "taskkill /f /im " + commentText1.Text;
				fastColoredTextBox1.Paste();
				commentBox.Hide();
				listBox1.Enabled = true;
				fastColoredTextBox1.ReadOnly = false;
				commentText1.Text = "text";
				fastColoredTextBox1.Focus();
			}
			else if (com == "start")
			{
				Clipboard.Clear();
				fastColoredTextBox1.SelectedText = "start /im " + commentText1.Text;
				fastColoredTextBox1.Paste();
				commentBox.Hide();
				listBox1.Enabled = true;
				fastColoredTextBox1.ReadOnly = false;
				commentText1.Text = "text";
				fastColoredTextBox1.Focus();
			}
			else if (com == "md")
			{
				Clipboard.Clear();
				fastColoredTextBox1.SelectedText = "md " + commentText1.Text;
				fastColoredTextBox1.Paste();
				commentBox.Hide();
				listBox1.Enabled = true;
				fastColoredTextBox1.ReadOnly = false;
				commentText1.Text = "text";
				fastColoredTextBox1.Focus();
			}
			else if (com == "rd")
			{
				Clipboard.Clear();
				fastColoredTextBox1.SelectedText = "rd " + commentText1.Text;
				fastColoredTextBox1.Paste();
				commentBox.Hide();
				listBox1.Enabled = true;
				fastColoredTextBox1.ReadOnly = false;
				commentText1.Text = "text";
				fastColoredTextBox1.Focus();
			}
			else if (com == "type")
			{
				Clipboard.Clear();
				fastColoredTextBox1.SelectedText = "type " + commentText1.Text;
				fastColoredTextBox1.Paste();
				commentBox.Hide();
				listBox1.Enabled = true;
				fastColoredTextBox1.ReadOnly = false;
				commentText1.Text = "text";
				fastColoredTextBox1.Focus();
			}
			else if (com == "dir")
			{
				Clipboard.Clear();
				fastColoredTextBox1.SelectedText = "dir " + commentText1.Text;
				fastColoredTextBox1.Paste();
				commentBox.Hide();
				listBox1.Enabled = true;
				fastColoredTextBox1.ReadOnly = false;
				commentText1.Text = "text";
				fastColoredTextBox1.Focus();
			}
			else if (com == "colors")
			{
				if (commentText1.Text.Length == 2)
				{
					Clipboard.Clear();
					fastColoredTextBox1.SelectedText = "color  " + commentText1.Text;
					fastColoredTextBox1.Paste();
					commentBox.Hide();
					listBox1.Enabled = true;
					fastColoredTextBox1.ReadOnly = false;
					commentText1.Text = "text";
					fastColoredTextBox1.Focus();
				}
				else
				{
					MessageBox.Show("Enter 2 numbers!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
		void Button1Click(object sender, EventArgs e)
		{
			commentBox.Hide();
			listBox1.Enabled = true;
			fastColoredTextBox1.ReadOnly = false;
			commentText1.Text = "text";
			fastColoredTextBox1.Focus();
		}
		void Button4Click(object sender, EventArgs e)
		{
			inputBox.Hide();
			listBox1.Enabled = true;
			fastColoredTextBox1.ReadOnly = false;
			variableText1.Text = "variable";
			textText1.Text = "text";
			fastColoredTextBox1.Focus();
		}
		void Button3Click(object sender, EventArgs e)
		{
			if (com == "input")
			{
				Clipboard.Clear();
				fastColoredTextBox1.SelectedText = "set /p " + variableText1.Text + "=" + textText1.Text;
				fastColoredTextBox1.Paste();
				inputBox.Hide();
				listBox1.Enabled = true;
				fastColoredTextBox1.ReadOnly = false;
				variableText1.Text = "variable";
				textText1.Text = "text";
				fastColoredTextBox1.Focus();
			}
			else if (com == "var")
			{
				Clipboard.Clear();
				fastColoredTextBox1.SelectedText = "set " + variableText1.Text + "=" + textText1.Text;
				fastColoredTextBox1.Paste();
				inputBox.Hide();
				listBox1.Enabled = true;
				fastColoredTextBox1.ReadOnly = false;
				variableText1.Text = "variable";
				textText1.Text = "text";
				fastColoredTextBox1.Focus();
			}
			else if (com == "copy")
			{
				Clipboard.Clear();
				fastColoredTextBox1.SelectedText = "copy " + textText1.Text + " " + variableText1.Text;
				fastColoredTextBox1.Paste();
				inputBox.Hide();
				listBox1.Enabled = true;
				fastColoredTextBox1.ReadOnly = false;
				variableText1.Text = "variable";
				textText1.Text = "text";
				fastColoredTextBox1.Focus();
			}
			else if (com == "move")
			{
				Clipboard.Clear();
				fastColoredTextBox1.SelectedText = "move " + textText1.Text + " " + variableText1.Text;
				fastColoredTextBox1.Paste();
				inputBox.Hide();
				listBox1.Enabled = true;
				fastColoredTextBox1.ReadOnly = false;
				variableText1.Text = "variable";
				textText1.Text = "text";
				fastColoredTextBox1.Focus();
			}
			else if (com == "wait")
			{
				Clipboard.Clear();
				fastColoredTextBox1.SelectedText = "ping -n " + textText1.Text + " " + variableText1.Text;
				fastColoredTextBox1.Paste();
				inputBox.Hide();
				listBox1.Enabled = true;
				fastColoredTextBox1.ReadOnly = false;
				variableText1.Text = "variable";
				textText1.Text = "text";
				fastColoredTextBox1.Focus();
			}
			else if (com == "else")
			{
				Clipboard.Clear();
				fastColoredTextBox1.SelectedText = "if not defined " + textText1.Text + " goto " + variableText1.Text;
				fastColoredTextBox1.Paste();
				inputBox.Hide();
				listBox1.Enabled = true;
				fastColoredTextBox1.ReadOnly = false;
				variableText1.Text = "variable";
				textText1.Text = "text";
				fastColoredTextBox1.Focus();
			}
			else if (com == "ren")
			{
				Clipboard.Clear();
				fastColoredTextBox1.SelectedText = "ren " + textText1.Text + " " + variableText1.Text;
				fastColoredTextBox1.Paste();
				inputBox.Hide();
				listBox1.Enabled = true;
				fastColoredTextBox1.ReadOnly = false;
				variableText1.Text = "variable";
				textText1.Text = "text";
				fastColoredTextBox1.Focus();
			}
		}
		void ColorsToolStripMenuItemClick(object sender, EventArgs e)
		{
			Process p = new Process();
			p.StartInfo.FileName = "cmd.exe";
			p.StartInfo.Arguments = "/c color ?";
			p.StartInfo.CreateNoWindow = true;
			p.Start();
		}
		void Button6Click(object sender, EventArgs e)
		{
			ifBox1.Hide();
			listBox1.Enabled = true;
			fastColoredTextBox1.ReadOnly = false;
			variableText2.Text = "variable";
			textBox2.Text = "text";
			functionText1.Text = "function";
			fastColoredTextBox1.Focus();
		}
		void Button5Click(object sender, EventArgs e)
		{
			Clipboard.Clear();
			fastColoredTextBox1.SelectedText = "if %" + variableText2.Text + "%==" + textBox2.Text + " goto " + functionText1.Text;
			fastColoredTextBox1.Paste();
			ifBox1.Hide();
			listBox1.Enabled = true;
			fastColoredTextBox1.ReadOnly = false;
			variableText2.Text = "variable";
			textBox2.Text = "text";
			functionText1.Text = "function";
			fastColoredTextBox1.Focus();
		}
		void FileToolStripMenuItemClick(object sender, EventArgs e)
		{
	
		}
		void SaveToolStripMenuItemClick(object sender, EventArgs e)
		{
			saveFileDialog1.ShowDialog();
		}
		void SaveFileDialog1FileOk(object sender, System.ComponentModel.CancelEventArgs e)
		{
			File.WriteAllLines(saveFileDialog1.FileName, fastColoredTextBox1.Lines);
		}
		void OpenFileDialog1FileOk(object sender, System.ComponentModel.CancelEventArgs e)
		{
			fastColoredTextBox1.Text = File.ReadAllText(openFileDialog1.FileName);
		}
		void RunToolStripMenuItemClick(object sender, EventArgs e)
		{
			File.WriteAllLines("debug.bat", fastColoredTextBox1.Lines);
			Process pa = new Process();
			pa.StartInfo.FileName = "debug.bat";
			pa.Start();
			pa.WaitForExit();
			File.Delete("debug.bat");
		}
		void AboutToolStripMenuItemClick(object sender, EventArgs e)
		{
			Form1 f = new Form1();
			f.Show();
		}
		void DiscordServerToolStripMenuItemClick(object sender, EventArgs e)
		{
			Process.Start("https://discord.gg/QTpU8t2wgv");
		}
		void TextBox2KeyPress(object sender, KeyPressEventArgs e)
		{
			
		}
		void VariableText2KeyPress(object sender, KeyPressEventArgs e)
		{
			
		}
		void FunctionText1KeyPress(object sender, KeyPressEventArgs e)
		{
			
		}
		void TextText1KeyPress(object sender, KeyPressEventArgs e)
		{
			
		}
		void VariableText1KeyPress(object sender, KeyPressEventArgs e)
		{
			
		}
		void CommentText1KeyPress(object sender, KeyPressEventArgs e)
		{
			
		}
		void OpenToolStripMenuItemClick(object sender, EventArgs e)
		{
			openFileDialog1.ShowDialog();
		}
		void CommentText1KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				if (com == "comment")
				{
					Clipboard.Clear();
					fastColoredTextBox1.SelectedText = "::" + commentText1.Text;
					fastColoredTextBox1.Paste();
					commentBox.Hide();
					listBox1.Enabled = true;
					fastColoredTextBox1.ReadOnly = false;
					commentText1.Text = "text";
					fastColoredTextBox1.Focus();
				}
				else if (com == "print")
				{
					Clipboard.Clear();
					fastColoredTextBox1.SelectedText = "echo " + commentText1.Text;
					fastColoredTextBox1.Paste();
					commentBox.Hide();
					listBox1.Enabled = true;
					fastColoredTextBox1.ReadOnly = false;
					commentText1.Text = "text";
					fastColoredTextBox1.Focus();
				}
				else if (com == "func")
				{
					Clipboard.Clear();
					fastColoredTextBox1.SelectedText = ":" + commentText1.Text;
					fastColoredTextBox1.Paste();
					commentBox.Hide();
					listBox1.Enabled = true;
					fastColoredTextBox1.ReadOnly = false;
					commentText1.Text = "text";
					fastColoredTextBox1.Focus();
				}
				else if (com == "runfunc")
				{
					Clipboard.Clear();
					fastColoredTextBox1.SelectedText = "goto " + commentText1.Text;
					fastColoredTextBox1.Paste();
					commentBox.Hide();
					listBox1.Enabled = true;
					fastColoredTextBox1.ReadOnly = false;
					commentText1.Text = "text";
					fastColoredTextBox1.Focus();
				}
				else if (com == "title")
				{
					Clipboard.Clear();
					fastColoredTextBox1.SelectedText = "title " + commentText1.Text;
					fastColoredTextBox1.Paste();
					commentBox.Hide();
					listBox1.Enabled = true;
					fastColoredTextBox1.ReadOnly = false;
					commentText1.Text = "text";
					fastColoredTextBox1.Focus();
				}
				else if (com == "coding")
				{
					Clipboard.Clear();
					fastColoredTextBox1.SelectedText = "chcp " + commentText1.Text;
					fastColoredTextBox1.Paste();
					commentBox.Hide();
					listBox1.Enabled = true;
					fastColoredTextBox1.ReadOnly = false;
					commentText1.Text = "text";
					fastColoredTextBox1.Focus();
				}
				else if (com == "kill")
				{
					Clipboard.Clear();
					fastColoredTextBox1.SelectedText = "taskkill /f /im " + commentText1.Text;
					fastColoredTextBox1.Paste();
					commentBox.Hide();
					listBox1.Enabled = true;
					fastColoredTextBox1.ReadOnly = false;
					commentText1.Text = "text";
					fastColoredTextBox1.Focus();
				}
				else if (com == "start")
				{
					Clipboard.Clear();
					fastColoredTextBox1.SelectedText = "start /im " + commentText1.Text;
					fastColoredTextBox1.Paste();
					commentBox.Hide();
					listBox1.Enabled = true;
					fastColoredTextBox1.ReadOnly = false;
					commentText1.Text = "text";
					fastColoredTextBox1.Focus();
				}
				else if (com == "md")
				{
					Clipboard.Clear();
					fastColoredTextBox1.SelectedText = "md " + commentText1.Text;
					fastColoredTextBox1.Paste();
					commentBox.Hide();
					listBox1.Enabled = true;
					fastColoredTextBox1.ReadOnly = false;
					commentText1.Text = "text";
					fastColoredTextBox1.Focus();
				}
				else if (com == "rd")
				{
					Clipboard.Clear();
					fastColoredTextBox1.SelectedText = "rd " + commentText1.Text;
					fastColoredTextBox1.Paste();
					commentBox.Hide();
					listBox1.Enabled = true;
					fastColoredTextBox1.ReadOnly = false;
					commentText1.Text = "text";
					fastColoredTextBox1.Focus();
				}
				else if (com == "type")
				{
					Clipboard.Clear();
					fastColoredTextBox1.SelectedText = "type " + commentText1.Text;
					fastColoredTextBox1.Paste();
					commentBox.Hide();
					listBox1.Enabled = true;
					fastColoredTextBox1.ReadOnly = false;
					commentText1.Text = "text";
					fastColoredTextBox1.Focus();
				}
				else if (com == "dir")
				{
					Clipboard.Clear();
					fastColoredTextBox1.SelectedText = "dir " + commentText1.Text;
					fastColoredTextBox1.Paste();
					commentBox.Hide();
					listBox1.Enabled = true;
					fastColoredTextBox1.ReadOnly = false;
					commentText1.Text = "text";
					fastColoredTextBox1.Focus();
				}
				else if (com == "colors")
				{
					if (commentText1.Text.Length == 2)
					{
						Clipboard.Clear();
						fastColoredTextBox1.SelectedText = "color  " + commentText1.Text;
						fastColoredTextBox1.Paste();
						commentBox.Hide();
						listBox1.Enabled = true;
						fastColoredTextBox1.ReadOnly = false;
						commentText1.Text = "text";
						fastColoredTextBox1.Focus();
					}
					else
					{
						MessageBox.Show("Enter 2 numbers!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
		}
		void VariableText1KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				if (com == "input")
				{
					Clipboard.Clear();
					fastColoredTextBox1.SelectedText = "set /p " + variableText1.Text + "=" + textText1.Text;
					fastColoredTextBox1.Paste();
					inputBox.Hide();
					listBox1.Enabled = true;
					fastColoredTextBox1.ReadOnly = false;
					variableText1.Text = "variable";
					textText1.Text = "text";
					fastColoredTextBox1.Focus();
				}
				else if (com == "var")
				{
					Clipboard.Clear();
					fastColoredTextBox1.SelectedText = "set " + variableText1.Text + "=" + textText1.Text;
					fastColoredTextBox1.Paste();
					inputBox.Hide();
					listBox1.Enabled = true;
					fastColoredTextBox1.ReadOnly = false;
					variableText1.Text = "variable";
					textText1.Text = "text";
					fastColoredTextBox1.Focus();
				}
				else if (com == "copy")
				{
					Clipboard.Clear();
					fastColoredTextBox1.SelectedText = "copy " + textText1.Text + " " + variableText1.Text;
					fastColoredTextBox1.Paste();
					inputBox.Hide();
					listBox1.Enabled = true;
					fastColoredTextBox1.ReadOnly = false;
					variableText1.Text = "variable";
					textText1.Text = "text";
					fastColoredTextBox1.Focus();
				}
				else if (com == "move")
				{
					Clipboard.Clear();
					fastColoredTextBox1.SelectedText = "move " + textText1.Text + " " + variableText1.Text;
					fastColoredTextBox1.Paste();
					inputBox.Hide();
					listBox1.Enabled = true;
					fastColoredTextBox1.ReadOnly = false;
					variableText1.Text = "variable";
					textText1.Text = "text";
					fastColoredTextBox1.Focus();
				}
				else if (com == "wait")
				{
					Clipboard.Clear();
					fastColoredTextBox1.SelectedText = "ping -n " + textText1.Text + " " + variableText1.Text;
					fastColoredTextBox1.Paste();
					inputBox.Hide();
					listBox1.Enabled = true;
					fastColoredTextBox1.ReadOnly = false;
					variableText1.Text = "variable";
					textText1.Text = "text";
					fastColoredTextBox1.Focus();
				}
				else if (com == "else")
				{
					Clipboard.Clear();
					fastColoredTextBox1.SelectedText = "if not defined " + textText1.Text + " goto " + variableText1.Text;
					fastColoredTextBox1.Paste();
					inputBox.Hide();
					listBox1.Enabled = true;
					fastColoredTextBox1.ReadOnly = false;
					variableText1.Text = "variable";
					textText1.Text = "text";
					fastColoredTextBox1.Focus();
				}
				else if (com == "ren")
				{
					Clipboard.Clear();
					fastColoredTextBox1.SelectedText = "ren " + textText1.Text + " " + variableText1.Text;
					fastColoredTextBox1.Paste();
					inputBox.Hide();
					listBox1.Enabled = true;
					fastColoredTextBox1.ReadOnly = false;
					variableText1.Text = "variable";
					textText1.Text = "text";
					fastColoredTextBox1.Focus();
				}
			}
		}
		void TextText1KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)	
			{
				variableText1.Focus();
			}
		}
		void FunctionText1KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)	
			{
				Clipboard.Clear();
				fastColoredTextBox1.SelectedText = "if %" + variableText2.Text + "%==" + textBox2.Text + " goto " + functionText1.Text;
				fastColoredTextBox1.Paste();
				ifBox1.Hide();
				listBox1.Enabled = true;
				fastColoredTextBox1.ReadOnly = false;
				variableText2.Text = "variable";
				textBox2.Text = "text";
				functionText1.Text = "function";
				fastColoredTextBox1.Focus();
			}
		}
		void VariableText2KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)	
			{
				functionText1.Focus();
			}
		}
		void TextBox2KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)	
			{
				variableText2.Focus();
			}
		}
		void OfficialYoutubeToolStripMenuItemClick(object sender, EventArgs e)
		{
			Process.Start("https://www.youtube.com/channel/UCOOhdIz86EI4fL44qOSOOtA");
		}
	}
}

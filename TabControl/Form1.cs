using System;
using System.Drawing;
using System.Windows.Forms;

namespace TabControl
{
    public partial class frmEditor : Form
    {

        private string _fileName = null;
        public frmEditor(frmContainer parent, int counter)
        {
            InitializeComponent();
            fontsToolStripComboBox.SelectedIndex = 0;
            MdiParent = parent;
            Text = @"Editor" + counter;
        }


        private void newToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBoxText.Text = "";
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.Filter = @"富文本文件(*.rtf)|*.rtf";
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                _fileName = this.openFileDialog1.FileName;
                // 你的 处理文件路径代码 
                try
                {
                    richTextBoxText.LoadFile(_fileName);
                }
                catch(Exception ec)
                {
                    MessageBox.Show(ec.Message);
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_fileName != null)
            {
                try
                {
                    richTextBoxText.SaveFile(_fileName);
                }
                catch (Exception ec)
                {
                    MessageBox.Show(ec.Message);
                }
                return;
            }
            saveAsToolStripMenuItem_Click(null, null);

        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.saveFileDialog1.Filter = @"富文本文件(*.rtf)|*.rtf";
            if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                _fileName = this.saveFileDialog1.FileName;
                // 你的 处理文件路径代码 
                try
                {
                    richTextBoxText.SaveFile(_fileName);
                }
                catch (Exception ec)
                {
                    MessageBox.Show(ec.Message);
                }
            }
        }

        private void boldToolStripButton_CheckedChanged(object sender, EventArgs e)
        {
            
            bool checkState = ((ToolStripButton) sender).Checked;
            var oldFont = richTextBoxText.Font;
            var newFont = !checkState ? 
                new Font(oldFont, oldFont.Style & ~FontStyle.Bold) : 
                new Font(oldFont, oldFont.Style | FontStyle.Bold);

            richTextBoxText.SelectionFont = newFont;
            richTextBoxText.Focus();

            //防止引发boldToolStripMenuItem_CheckedChanged事件，造成事件循环
            boldToolStripMenuItem.CheckedChanged -= new
                EventHandler(boldToolStripMenuItem_CheckedChanged);
            boldToolStripMenuItem.Checked = checkState;
            boldToolStripMenuItem.CheckedChanged += new
                EventHandler(boldToolStripMenuItem_CheckedChanged);
            toolStripStatusLabelBold.Enabled = checkState;
        }

        private void italicToolStripButton_CheckedChanged(object sender, EventArgs e)
        {
            bool checkState = ((ToolStripButton)sender).Checked;
            var oldFont = richTextBoxText.Font;
            var newFont = !checkState ?
                new Font(oldFont, oldFont.Style & ~FontStyle.Italic) :
                new Font(oldFont, oldFont.Style | FontStyle.Italic);

            richTextBoxText.SelectionFont = newFont;
            richTextBoxText.Focus();

            //防止引发italicToolStripMenuItem_CheckedChanged事件，造成事件循环
            italicToolStripMenuItem.CheckedChanged -= new
                EventHandler(italicToolStripMenuItem_CheckedChanged);
            italicToolStripMenuItem.Checked = checkState;
            italicToolStripMenuItem.CheckedChanged += new
                EventHandler(italicToolStripMenuItem_CheckedChanged);
            toolStripStatusLabelItalic.Enabled = checkState;
        }
    

        private void underLineToolStripButton_CheckedChanged(object sender, EventArgs e)
        {
            bool checkState = ((ToolStripButton)sender).Checked;
            var oldFont = richTextBoxText.Font;
            var newFont = !checkState ?
                new Font(oldFont, oldFont.Style & ~FontStyle.Underline) :
                new Font(oldFont, oldFont.Style | FontStyle.Underline);

            richTextBoxText.SelectionFont = newFont;
            richTextBoxText.Focus();

            //防止引发italicToolStripMenuItem_CheckedChanged事件，造成事件循环
            underLineToolStripMenuItem.CheckedChanged -= new
                EventHandler(underLineToolStripMenuItem_CheckedChanged);
            underLineToolStripMenuItem.Checked = checkState;
            underLineToolStripMenuItem.CheckedChanged += new
                EventHandler(underLineToolStripMenuItem_CheckedChanged);
            toolStripStatusLabelUnderline.Enabled = checkState;
        }

        private void boldToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            boldToolStripButton.Checked = boldToolStripMenuItem.Checked;
        }

        private void italicToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            italicToolStripButton.Checked = italicToolStripMenuItem.Checked;
        }

        private void underLineToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            underLineToolStripButton.Checked = underLineToolStripMenuItem.Checked;
        }

        private void 帮助LToolStripButton_Click(object sender, EventArgs e)
        {
            
        }

        private void richTextBoxText_TextChanged(object sender, EventArgs e)
        {
            toolStripStatusLabelText.Text = richTextBoxText.Text.Length +"个字符";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

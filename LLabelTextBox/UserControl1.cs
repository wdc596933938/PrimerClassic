using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LLabelTextBox
{
    
    public partial class CtlLabelTextBox: UserControl
    {
        public event EventHandler PositionChanged;
        public enum PositionEnum
        {
            Right,
            Below
        }
        public CtlLabelTextBox()
        {
            InitializeComponent();
        }

       
        private PositionEnum position = PositionEnum.Right;

        public PositionEnum Position
        {
            get
            {
                return position;
            }

            set
            {
                position = value;
                MoveControls();
                PositionChanged?.Invoke(this, new EventArgs());
            }
        }

        public int TextBoxMargin
        {
            get
            {
                return textBoxMargin;
            }

            set
            {
                textBoxMargin = value;
                MoveControls();
            }
        }

        public string LabelText
        {
            get
            {
                return labelCaption.Text;
            }

            set
            {
                labelCaption.Text = labelText = value;
                MoveControls();
            }
        }

        public string TextBoxText
        {
            get
            {
                return textBoxText.Text;
            }

            set
            {
                textBoxText.Text = value;
            }
        }


        private int textBoxMargin;

        private string labelText = "";


        private void MoveControls()
        {
            switch (position)
            {
                case PositionEnum.Below:
                    textBoxText.Top = labelCaption.Bottom;
                    textBoxText.Left = labelCaption.Left;
                    textBoxText.Width = Width - 3;
                    Height = textBoxText.Height + labelCaption.Height;
                    break;
                case PositionEnum.Right:
                    textBoxText.Top = labelCaption.Top;
                    if (textBoxMargin == 0)
                    {
                        int width = Width - labelCaption.Width - 3;
                        textBoxText.Left = labelCaption.Right + 3;
                        textBoxText.Width = width;

                    }
                    else
                    {
                        textBoxText.Left = textBoxMargin + labelCaption.Width;
                        textBoxText.Width = Width - textBoxText.Left;
                    }
                    Height = textBoxText.Height > labelCaption.Height ?
                    textBoxText.Height : labelCaption.Height;
                    break;
            }

        }

        private void CtlLabelTextBox_Load(object sender, EventArgs e)
        {
            labelCaption.Text = labelText;
            Height = textBoxText.Height > labelCaption.Height ? textBoxText.Height : labelCaption.Height;
            MoveControls();
        }

        private void CtlLabelTextBox_SizeChanged(object sender, EventArgs e)
        {
            MoveControls();
        }

        private void textBoxText_KeyDown(object sender, KeyEventArgs e)
        {
            OnKeyDown(e);
        }

        private void textBoxText_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnKeyPress(e);
        }

        private void textBoxText_KeyUp(object sender, KeyEventArgs e)
        {
            OnKeyUp(e);
        }
    }

}

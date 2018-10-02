﻿using System;
using System.Text;
using System.Windows.Forms;

namespace Common
{
    public partial class ReceiveTextBox : UserControl
    {
        public ReceiveTextBox()
        {
            InitializeComponent();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            outputText.Clear();
        }

        /// <summary>
        /// Appends data to text box.
        /// </summary>
        /// <param name="data">Zero indexed array of bytes.</param>
        /// <param name="length">Length of data to append, starting at index 0.</param>
        public void Append(byte [] data, int length)
        {
            if (viewInHex.Checked)
            {
                StringBuilder sb = new StringBuilder(length);
                for (int i = 0; i < length; i++)
                {
                    sb.Append(string.Format("{0:X2} ", data[i]));
                }
                outputText.AppendText(sb.ToString());
            }
            else
            {
                for (int i = 0; i < length; i++)
                {
                    // remove special chars
                    if (data[i] < (byte)' ' || data[i] > (byte)'~')
                    {
                        data[i] = (byte)'.';
                    }
                }

                outputText.AppendText(ASCIIEncoding.UTF8.GetString(data, 0, length));
            }
        }

        public void AppendText(string text)
        {
            outputText.AppendText(text);
        }

        public void AppendText(string text, bool inHexadecimalMode)
        {
            if (inHexadecimalMode && viewInHex.Checked)
                AppendText(text);
            else if (!inHexadecimalMode && !viewInHex.Checked)
                AppendText(text);
        }

        public void Clear()
        {
            outputText.Clear();
        }
    }
}

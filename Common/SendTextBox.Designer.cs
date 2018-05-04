﻿namespace Common
{
    partial class SendTextBox
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.inputInHex = new System.Windows.Forms.CheckBox();
            this.inputTextLabel = new System.Windows.Forms.Label();
            this.endOfLine = new System.Windows.Forms.GroupBox();
            this.endOfLineUnix = new System.Windows.Forms.RadioButton();
            this.endOfLineDos = new System.Windows.Forms.RadioButton();
            this.endOfLineMac = new System.Windows.Forms.RadioButton();
            this.inputText = new System.Windows.Forms.TextBox();
            this.endOfLine.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputInHex
            // 
            this.inputInHex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.inputInHex.AutoSize = true;
            this.inputInHex.Location = new System.Drawing.Point(3, 312);
            this.inputInHex.MinimumSize = new System.Drawing.Size(272, 17);
            this.inputInHex.Name = "inputInHex";
            this.inputInHex.Size = new System.Drawing.Size(277, 17);
            this.inputInHex.TabIndex = 1;
            this.inputInHex.Text = "Send binary, text is hexadecimal ASCII (e.g. BE 0xad)";
            this.inputInHex.UseVisualStyleBackColor = true;
            this.inputInHex.CheckedChanged += new System.EventHandler(this.inputInHex_CheckedChanged);
            // 
            // inputTextLabel
            // 
            this.inputTextLabel.AutoSize = true;
            this.inputTextLabel.Location = new System.Drawing.Point(3, 0);
            this.inputTextLabel.Name = "inputTextLabel";
            this.inputTextLabel.Size = new System.Drawing.Size(105, 13);
            this.inputTextLabel.TabIndex = 21;
            this.inputTextLabel.Text = "Text to send (UTF-8)";
            // 
            // endOfLine
            // 
            this.endOfLine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.endOfLine.Controls.Add(this.endOfLineUnix);
            this.endOfLine.Controls.Add(this.endOfLineDos);
            this.endOfLine.Controls.Add(this.endOfLineMac);
            this.endOfLine.Location = new System.Drawing.Point(3, 335);
            this.endOfLine.MinimumSize = new System.Drawing.Size(247, 45);
            this.endOfLine.Name = "endOfLine";
            this.endOfLine.Size = new System.Drawing.Size(247, 45);
            this.endOfLine.TabIndex = 2;
            this.endOfLine.TabStop = false;
            this.endOfLine.Text = "End of Line";
            // 
            // endOfLineUnix
            // 
            this.endOfLineUnix.AutoSize = true;
            this.endOfLineUnix.Location = new System.Drawing.Point(174, 19);
            this.endOfLineUnix.Name = "endOfLineUnix";
            this.endOfLineUnix.Size = new System.Drawing.Size(67, 17);
            this.endOfLineUnix.TabIndex = 2;
            this.endOfLineUnix.Text = "Unix (LF)";
            this.endOfLineUnix.UseVisualStyleBackColor = true;
            // 
            // endOfLineDos
            // 
            this.endOfLineDos.AutoSize = true;
            this.endOfLineDos.Checked = true;
            this.endOfLineDos.Location = new System.Drawing.Point(6, 19);
            this.endOfLineDos.Name = "endOfLineDos";
            this.endOfLineDos.Size = new System.Drawing.Size(87, 17);
            this.endOfLineDos.TabIndex = 2;
            this.endOfLineDos.TabStop = true;
            this.endOfLineDos.Text = "DOS (CR-LF)";
            this.endOfLineDos.UseVisualStyleBackColor = true;
            // 
            // endOfLineMac
            // 
            this.endOfLineMac.AutoSize = true;
            this.endOfLineMac.Location = new System.Drawing.Point(96, 19);
            this.endOfLineMac.Name = "endOfLineMac";
            this.endOfLineMac.Size = new System.Drawing.Size(72, 17);
            this.endOfLineMac.TabIndex = 2;
            this.endOfLineMac.Text = "MAC (CR)";
            this.endOfLineMac.UseVisualStyleBackColor = true;
            // 
            // inputText
            // 
            this.inputText.AcceptsReturn = true;
            this.inputText.AcceptsTab = true;
            this.inputText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputText.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputText.HideSelection = false;
            this.inputText.Location = new System.Drawing.Point(3, 16);
            this.inputText.MaxLength = 1000000;
            this.inputText.Multiline = true;
            this.inputText.Name = "inputText";
            this.inputText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.inputText.Size = new System.Drawing.Size(402, 290);
            this.inputText.TabIndex = 0;
            this.inputText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputText_KeyPress);
            // 
            // SendTextBox
            // 
            this.Controls.Add(this.inputTextLabel);
            this.Controls.Add(this.inputText);
            this.Controls.Add(this.inputInHex);
            this.Controls.Add(this.endOfLine);
            this.Name = "SendTextBox";
            this.Size = new System.Drawing.Size(407, 382);
            this.endOfLine.ResumeLayout(false);
            this.endOfLine.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox inputInHex;
        private System.Windows.Forms.Label inputTextLabel;
        private System.Windows.Forms.GroupBox endOfLine;
        private System.Windows.Forms.RadioButton endOfLineUnix;
        private System.Windows.Forms.RadioButton endOfLineDos;
        private System.Windows.Forms.RadioButton endOfLineMac;
        private System.Windows.Forms.TextBox inputText;
    }
}

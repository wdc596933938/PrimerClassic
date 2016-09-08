namespace WindowsForms
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelName = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.labelOutput = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.Help = new System.Windows.Forms.Button();
            this.checkBoxProgrammer = new System.Windows.Forms.CheckBox();
            this.groupBoxSex = new System.Windows.Forms.GroupBox();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.groupBoxSex.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(45, 42);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(55, 20);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name:";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddress.Location = new System.Drawing.Point(45, 89);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(72, 20);
            this.labelAddress.TabIndex = 1;
            this.labelAddress.Text = "Address:";
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAge.Location = new System.Drawing.Point(45, 326);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(42, 20);
            this.labelAge.TabIndex = 3;
            this.labelAge.Text = "Age:";
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOutput.Location = new System.Drawing.Point(46, 402);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(58, 20);
            this.labelOutput.TabIndex = 4;
            this.labelOutput.Text = "Output";
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(154, 41);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(365, 24);
            this.textBoxName.TabIndex = 5;
            this.textBoxName.Text = "TextBox Name";
            this.textBoxName.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxEmpty_Validating);
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAddress.Location = new System.Drawing.Point(154, 89);
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxAddress.Size = new System.Drawing.Size(365, 93);
            this.textBoxAddress.TabIndex = 6;
            this.textBoxAddress.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxEmpty_Validating);
            // 
            // textBoxAge
            // 
            this.textBoxAge.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAge.Location = new System.Drawing.Point(154, 320);
            this.textBoxAge.MaxLength = 3;
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(95, 26);
            this.textBoxAge.TabIndex = 8;
            this.textBoxAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAge_KeyPress);
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOutput.Location = new System.Drawing.Point(154, 374);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.ReadOnly = true;
            this.textBoxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOutput.Size = new System.Drawing.Size(365, 217);
            this.textBoxOutput.TabIndex = 9;
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.CausesValidation = false;
            this.buttonOK.Location = new System.Drawing.Point(560, 42);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 10;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // Help
            // 
            this.Help.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Help.CausesValidation = false;
            this.Help.Location = new System.Drawing.Point(560, 89);
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(75, 23);
            this.Help.TabIndex = 11;
            this.Help.Text = "Help";
            this.Help.UseVisualStyleBackColor = true;
            this.Help.Click += new System.EventHandler(this.Help_Click);
            // 
            // checkBoxProgrammer
            // 
            this.checkBoxProgrammer.AutoSize = true;
            this.checkBoxProgrammer.Checked = true;
            this.checkBoxProgrammer.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxProgrammer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxProgrammer.Location = new System.Drawing.Point(49, 200);
            this.checkBoxProgrammer.Name = "checkBoxProgrammer";
            this.checkBoxProgrammer.Size = new System.Drawing.Size(115, 24);
            this.checkBoxProgrammer.TabIndex = 12;
            this.checkBoxProgrammer.Text = "Programmer";
            this.checkBoxProgrammer.UseVisualStyleBackColor = true;
            // 
            // groupBoxSex
            // 
            this.groupBoxSex.Controls.Add(this.radioButtonMale);
            this.groupBoxSex.Controls.Add(this.radioButtonFemale);
            this.groupBoxSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSex.Location = new System.Drawing.Point(50, 240);
            this.groupBoxSex.Name = "groupBoxSex";
            this.groupBoxSex.Size = new System.Drawing.Size(514, 65);
            this.groupBoxSex.TabIndex = 13;
            this.groupBoxSex.TabStop = false;
            this.groupBoxSex.Text = "Sex";
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Checked = true;
            this.radioButtonFemale.Location = new System.Drawing.Point(104, 32);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(80, 24);
            this.radioButtonFemale.TabIndex = 0;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "Female";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Location = new System.Drawing.Point(277, 32);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(61, 24);
            this.radioButtonMale.TabIndex = 1;
            this.radioButtonMale.Text = "Male";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 615);
            this.Controls.Add(this.groupBoxSex);
            this.Controls.Add(this.checkBoxProgrammer);
            this.Controls.Add(this.Help);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(676, 442);
            this.Name = "Form1";
            this.Text = "Do you speak english?";
            this.groupBoxSex.ResumeLayout(false);
            this.groupBoxSex.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button Help;
        private System.Windows.Forms.CheckBox checkBoxProgrammer;
        private System.Windows.Forms.GroupBox groupBoxSex;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private System.Windows.Forms.RadioButton radioButtonFemale;
    }
}


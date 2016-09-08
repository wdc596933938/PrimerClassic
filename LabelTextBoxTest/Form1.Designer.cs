namespace LabelTextBoxTest
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
            this.ctlLabelTextBox1 = new LLabelTextBox.CtlLabelTextBox();
            this.ctlLabelTextBox2 = new LLabelTextBox.CtlLabelTextBox();
            this.SuspendLayout();
            // 
            // ctlLabelTextBox1
            // 
            this.ctlLabelTextBox1.LabelText = "";
            this.ctlLabelTextBox1.Location = new System.Drawing.Point(86, 122);
            this.ctlLabelTextBox1.Name = "ctlLabelTextBox1";
            this.ctlLabelTextBox1.Position = LLabelTextBox.CtlLabelTextBox.PositionEnum.Right;
            this.ctlLabelTextBox1.Size = new System.Drawing.Size(150, 20);
            this.ctlLabelTextBox1.TabIndex = 0;
            this.ctlLabelTextBox1.TextBoxMargin = 0;
            this.ctlLabelTextBox1.TextBoxText = "";
            // 
            // ctlLabelTextBox2
            // 
            this.ctlLabelTextBox2.LabelText = "hello";
            this.ctlLabelTextBox2.Location = new System.Drawing.Point(54, 106);
            this.ctlLabelTextBox2.Name = "ctlLabelTextBox2";
            this.ctlLabelTextBox2.Position = LLabelTextBox.CtlLabelTextBox.PositionEnum.Right;
            this.ctlLabelTextBox2.Size = new System.Drawing.Size(150, 20);
            this.ctlLabelTextBox2.TabIndex = 1;
            this.ctlLabelTextBox2.TextBoxMargin = 0;
            this.ctlLabelTextBox2.TextBoxText = "World";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.ctlLabelTextBox2);
            this.Controls.Add(this.ctlLabelTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private LLabelTextBox.CtlLabelTextBox ctlLabelTextBox1;
        private LLabelTextBox.CtlLabelTextBox ctlLabelTextBox2;
    }
}


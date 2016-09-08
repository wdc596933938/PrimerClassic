namespace LLabelTextBox
{
    partial class CtlLabelTextBox
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

        #region 组件设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.labelCaption = new System.Windows.Forms.Label();
            this.textBoxText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelCaption
            // 
            this.labelCaption.AutoSize = true;
            this.labelCaption.Location = new System.Drawing.Point(20, 40);
            this.labelCaption.Name = "labelCaption";
            this.labelCaption.Size = new System.Drawing.Size(35, 13);
            this.labelCaption.TabIndex = 0;
            this.labelCaption.Text = "label1";
            // 
            // textBoxText
            // 
            this.textBoxText.Location = new System.Drawing.Point(23, 83);
            this.textBoxText.Name = "textBoxText";
            this.textBoxText.Size = new System.Drawing.Size(100, 20);
            this.textBoxText.TabIndex = 1;
            this.textBoxText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxText_KeyDown);
            this.textBoxText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxText_KeyPress);
            this.textBoxText.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxText_KeyUp);
            // 
            // CtlLabelTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxText);
            this.Controls.Add(this.labelCaption);
            this.Name = "CtlLabelTextBox";
            this.Load += new System.EventHandler(this.CtlLabelTextBox_Load);
            this.SizeChanged += new System.EventHandler(this.CtlLabelTextBox_SizeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCaption;
        private System.Windows.Forms.TextBox textBoxText;
    }
}

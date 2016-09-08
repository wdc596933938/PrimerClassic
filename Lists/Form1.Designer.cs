namespace Lists
{
    partial class ListsView
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListsView));
            this.labelCurrentPath = new System.Windows.Forms.Label();
            this.listViewFilesAndFolders = new System.Windows.Forms.ListView();
            this.col_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_Size = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_Access = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageListLarge = new System.Windows.Forms.ImageList(this.components);
            this.imageListSmall = new System.Windows.Forms.ImageList(this.components);
            this.buttonBack = new System.Windows.Forms.Button();
            this.groupBoxMode = new System.Windows.Forms.GroupBox();
            this.radioButtonTitle = new System.Windows.Forms.RadioButton();
            this.radioButtonDetail = new System.Windows.Forms.RadioButton();
            this.radioButtonList = new System.Windows.Forms.RadioButton();
            this.radioButtonSmall = new System.Windows.Forms.RadioButton();
            this.radioButtonLarge = new System.Windows.Forms.RadioButton();
            this.groupBoxMode.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelCurrentPath
            // 
            this.labelCurrentPath.AutoSize = true;
            this.labelCurrentPath.Location = new System.Drawing.Point(12, 9);
            this.labelCurrentPath.Name = "labelCurrentPath";
            this.labelCurrentPath.Size = new System.Drawing.Size(0, 13);
            this.labelCurrentPath.TabIndex = 0;
            // 
            // listViewFilesAndFolders
            // 
            this.listViewFilesAndFolders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewFilesAndFolders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_Name,
            this.col_Size,
            this.col_Access,
            this.col_Type});
            this.listViewFilesAndFolders.LargeImageList = this.imageListLarge;
            this.listViewFilesAndFolders.Location = new System.Drawing.Point(12, 25);
            this.listViewFilesAndFolders.Name = "listViewFilesAndFolders";
            this.listViewFilesAndFolders.Size = new System.Drawing.Size(578, 229);
            this.listViewFilesAndFolders.SmallImageList = this.imageListSmall;
            this.listViewFilesAndFolders.TabIndex = 1;
            this.listViewFilesAndFolders.UseCompatibleStateImageBehavior = false;
            this.listViewFilesAndFolders.View = System.Windows.Forms.View.Details;
            this.listViewFilesAndFolders.ItemActivate += new System.EventHandler(this.listViewFilesAndFolders_ItemActivate);
            // 
            // col_Name
            // 
            this.col_Name.Text = "FileName";
            this.col_Name.Width = 160;
            // 
            // col_Size
            // 
            this.col_Size.Text = "Size";
            this.col_Size.Width = 80;
            // 
            // col_Access
            // 
            this.col_Access.Text = "Acess";
            this.col_Access.Width = 140;
            // 
            // col_Type
            // 
            this.col_Type.Text = "Type";
            this.col_Type.Width = 80;
            // 
            // imageListLarge
            // 
            this.imageListLarge.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListLarge.ImageStream")));
            this.imageListLarge.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListLarge.Images.SetKeyName(0, "folder_32px.ico");
            this.imageListLarge.Images.SetKeyName(1, "File_TXT_32.png");
            // 
            // imageListSmall
            // 
            this.imageListSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListSmall.ImageStream")));
            this.imageListSmall.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListSmall.Images.SetKeyName(0, "folder_16px_1084455_easyicon.net.ico");
            this.imageListSmall.Images.SetKeyName(1, "File_TXT.png");
            // 
            // buttonBack
            // 
            this.buttonBack.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonBack.Enabled = false;
            this.buttonBack.Location = new System.Drawing.Point(341, 285);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 2;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // groupBoxMode
            // 
            this.groupBoxMode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxMode.Controls.Add(this.radioButtonTitle);
            this.groupBoxMode.Controls.Add(this.radioButtonDetail);
            this.groupBoxMode.Controls.Add(this.radioButtonList);
            this.groupBoxMode.Controls.Add(this.radioButtonSmall);
            this.groupBoxMode.Controls.Add(this.radioButtonLarge);
            this.groupBoxMode.Location = new System.Drawing.Point(596, 25);
            this.groupBoxMode.Name = "groupBoxMode";
            this.groupBoxMode.Size = new System.Drawing.Size(124, 229);
            this.groupBoxMode.TabIndex = 3;
            this.groupBoxMode.TabStop = false;
            this.groupBoxMode.Text = "View Mode";
            // 
            // radioButtonTitle
            // 
            this.radioButtonTitle.AutoSize = true;
            this.radioButtonTitle.Location = new System.Drawing.Point(26, 126);
            this.radioButtonTitle.Name = "radioButtonTitle";
            this.radioButtonTitle.Size = new System.Drawing.Size(45, 17);
            this.radioButtonTitle.TabIndex = 4;
            this.radioButtonTitle.Text = "Title";
            this.radioButtonTitle.UseVisualStyleBackColor = true;
            this.radioButtonTitle.CheckedChanged += new System.EventHandler(this.radioButtonTitle_CheckedChanged);
            // 
            // radioButtonDetail
            // 
            this.radioButtonDetail.AutoSize = true;
            this.radioButtonDetail.Checked = true;
            this.radioButtonDetail.Location = new System.Drawing.Point(26, 103);
            this.radioButtonDetail.Name = "radioButtonDetail";
            this.radioButtonDetail.Size = new System.Drawing.Size(57, 17);
            this.radioButtonDetail.TabIndex = 3;
            this.radioButtonDetail.TabStop = true;
            this.radioButtonDetail.Text = "Details";
            this.radioButtonDetail.UseVisualStyleBackColor = true;
            this.radioButtonDetail.CheckedChanged += new System.EventHandler(this.radioButtonDetail_CheckedChanged);
            // 
            // radioButtonList
            // 
            this.radioButtonList.AutoSize = true;
            this.radioButtonList.Location = new System.Drawing.Point(26, 80);
            this.radioButtonList.Name = "radioButtonList";
            this.radioButtonList.Size = new System.Drawing.Size(41, 17);
            this.radioButtonList.TabIndex = 2;
            this.radioButtonList.Text = "List";
            this.radioButtonList.UseVisualStyleBackColor = true;
            this.radioButtonList.CheckedChanged += new System.EventHandler(this.radioButtonList_CheckedChanged);
            // 
            // radioButtonSmall
            // 
            this.radioButtonSmall.AutoSize = true;
            this.radioButtonSmall.Location = new System.Drawing.Point(26, 57);
            this.radioButtonSmall.Name = "radioButtonSmall";
            this.radioButtonSmall.Size = new System.Drawing.Size(74, 17);
            this.radioButtonSmall.TabIndex = 1;
            this.radioButtonSmall.Text = "Small Icon";
            this.radioButtonSmall.UseVisualStyleBackColor = true;
            this.radioButtonSmall.CheckedChanged += new System.EventHandler(this.radioButtonSmall_CheckedChanged);
            // 
            // radioButtonLarge
            // 
            this.radioButtonLarge.AutoSize = true;
            this.radioButtonLarge.Location = new System.Drawing.Point(26, 34);
            this.radioButtonLarge.Name = "radioButtonLarge";
            this.radioButtonLarge.Size = new System.Drawing.Size(76, 17);
            this.radioButtonLarge.TabIndex = 0;
            this.radioButtonLarge.Text = "Large Icon";
            this.radioButtonLarge.UseVisualStyleBackColor = true;
            this.radioButtonLarge.CheckedChanged += new System.EventHandler(this.radioButtonLarge_CheckedChanged);
            // 
            // ListsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 320);
            this.Controls.Add(this.groupBoxMode);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.listViewFilesAndFolders);
            this.Controls.Add(this.labelCurrentPath);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ListsView";
            this.Text = "ListsView";
            this.groupBoxMode.ResumeLayout(false);
            this.groupBoxMode.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCurrentPath;
        private System.Windows.Forms.ListView listViewFilesAndFolders;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.GroupBox groupBoxMode;
        private System.Windows.Forms.RadioButton radioButtonTitle;
        private System.Windows.Forms.RadioButton radioButtonDetail;
        private System.Windows.Forms.RadioButton radioButtonList;
        private System.Windows.Forms.RadioButton radioButtonSmall;
        private System.Windows.Forms.RadioButton radioButtonLarge;
        private System.Windows.Forms.ImageList imageListLarge;
        private System.Windows.Forms.ImageList imageListSmall;
        private System.Windows.Forms.ColumnHeader col_Size;
        private System.Windows.Forms.ColumnHeader col_Name;
        private System.Windows.Forms.ColumnHeader col_Type;
        private System.Windows.Forms.ColumnHeader col_Access;
    }
}


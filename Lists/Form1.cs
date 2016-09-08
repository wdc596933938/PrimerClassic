using System;
using System.Collections.Specialized;
using System.IO;
using System.Windows.Forms;
using Lists.Properties;

namespace Lists
{
    public partial class ListsView : Form
    {
        private StringCollection folderCol;
        public ListsView()
        {
            InitializeComponent();
            folderCol = new StringCollection();
            CreateHeadersAndFillListView();
            PaintListView(@"D:\");
            folderCol.Add(@"D:\");
        }
        private void CreateHeadersAndFillListView()
        {
            //ColumnHeader colHead;
            //colHead = new ColumnHeader();        
            //colHead.Text = Resources.ListsView_CreateHeadersAndFillListView_Filename;          
            //listViewFilesAndFolders.Columns.Add(colHead); // Insert the header
            //colHead = new ColumnHeader();
            //colHead.Text = Resources.ListsView_CreateHeadersAndFillListView_Size;
            //listViewFilesAndFolders.Columns.Add(colHead); // Insert the header
            //colHead = new ColumnHeader();
            //colHead.Text = Resources.ListsView_CreateHeadersAndFillListView_Last_accessed;
            //listViewFilesAndFolders.Columns.Add(colHead); // Insert the header
            //colHead = new ColumnHeader();
            //colHead.Text = Resources.ListsView_CreateHeadersAndFillListView_Type;
            //listViewFilesAndFolders.Columns.Add(colHead); // Insert the header
        }

        private void PaintListView(string root)
        {
            try
            {
                ListViewItem lvi;
                ListViewItem.ListViewSubItem lvsi;
                long length;
                if (string.IsNullOrEmpty(root))
                    return;
                DirectoryInfo dir = new DirectoryInfo(root);
                DirectoryInfo[] dirs = dir.GetDirectories(); // Folders
                FileInfo[] files = dir.GetFiles(); // Files

                listViewFilesAndFolders.Items.Clear();
                labelCurrentPath.Text = root;
                //listViewFilesAndFolders.BeginUpdate();
                foreach (DirectoryInfo di in dirs)
                {
                    lvi = new ListViewItem
                    {
                        Text = di.Name,
                        ImageIndex = 0,
                        Tag = di.FullName
                    };
                    // Folder name
                    // The folder icon has index 0
                    // Set the tag to the qualified path of the folder
                    lvsi = new ListViewItem.ListViewSubItem();
                    lvsi.Text = ""; // Size—a folder has no size and so this column is empty
                    lvi.SubItems.Add(lvsi); // Add the subitem to the ListViewItem
                    lvsi = new ListViewItem.ListViewSubItem();
                    lvsi.Text = di.LastAccessTime.ToString(); // Last accessed column
                    lvi.SubItems.Add(lvsi); // Add the subitem to the ListViewItem.
                    lvsi = new ListViewItem.ListViewSubItem();
                    lvsi.Text = Resources.ListsView_PaintListView_Directory;
                    lvi.SubItems.Add(lvsi);
                    listViewFilesAndFolders.Items.Add(lvi);
                }
                foreach (FileInfo fi in files)
                {
                    lvi = new ListViewItem();
                    lvi.Text = fi.Name; // Filename
                    lvi.ImageIndex = 1; // The icon we use to represent a folder has index 1.
                    lvi.Tag = fi.FullName; // Set the tag to the qualified path of the file.
                    lvsi = new ListViewItem.ListViewSubItem();
                    length = fi.Length;
                    if (length >= 1024)
                    {
                        length /= 1024;
                        if (length >= 1024)
                        {
                            length /= 1024;
                            lvsi.Text = length + Resources.ListsView_PaintListView__MByte;
                        }
                        else
                        {
                            lvsi.Text = length + " KByte";
                        }
                    }      
                    else
                        lvsi.Text = length + " Byte";
                    // Length of the file
                    lvi.SubItems.Add(lvsi); // Add to the SubItems collection
                    lvsi = new ListViewItem.ListViewSubItem();
                    lvsi.Text = fi.LastAccessTime.ToString(); // Last Accessed Column
                    lvi.SubItems.Add(lvsi); // Add to the SubItems collection
                    lvsi = new ListViewItem.ListViewSubItem();
                    lvsi.Text = fi.Name.Substring(fi.Name.LastIndexOf(".")+1); // Last Accessed Column
                    lvi.SubItems.Add(lvsi); // Add to the SubItems collection
                    listViewFilesAndFolders.Items.Add(lvi);
                }
                listViewFilesAndFolders.EndUpdate();
                if (folderCol.Count < 2)
                    buttonBack.Enabled = false;

            }
            catch (Exception err)
            {
                MessageBox.Show(Resources.ListsView_PaintListView_Error__ + err.Message);
            }
        }

        private void listViewFilesAndFolders_ItemActivate(object sender, EventArgs e)
        {
            ListView lw = (ListView)sender;
            string filename = lw.SelectedItems[0].Tag.ToString();
            if (lw.SelectedItems[0].ImageIndex != 0)
            {
                try
                {
                    System.Diagnostics.Process.Start(filename);
                }
                catch { return; }
            }
            else
            {
                PaintListView(filename);
                folderCol.Add(filename);
                if (folderCol.Count > 1)
                    buttonBack.Enabled = true;
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
          
            if (folderCol.Count > 1)
            {
                folderCol.RemoveAt(folderCol.Count - 1);
                PaintListView(folderCol[folderCol.Count - 1]);
                
            }          
        }

        private void radioButtonLarge_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rbl = (RadioButton)sender;
            if (rbl.Checked)
                this.listViewFilesAndFolders.View = View.LargeIcon;
        }

        private void radioButtonSmall_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rbs = (RadioButton)sender;
            if (rbs.Checked)
                listViewFilesAndFolders.View = View.SmallIcon;
        }

        private void radioButtonList_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rbl = (RadioButton)sender;
            if (rbl.Checked)
                listViewFilesAndFolders.View = View.List;
        }

        private void radioButtonDetail_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rbd = (RadioButton)sender;
            if (rbd.Checked)
                listViewFilesAndFolders.View = View.Details;

        }

        private void radioButtonTitle_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rbt = (RadioButton)sender;
            if (rbt.Checked)
                listViewFilesAndFolders.View = View.Tile;
        }
    }
}

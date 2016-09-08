using System;
using System.Windows.Forms;

namespace TabControl
{
    public partial class frmContainer : Form
    {
        private int counter = 1;
        public frmContainer()
        {
            InitializeComponent();
            frmEditor child = new frmEditor(this, counter++);
            child.Show();
        }

        private void newNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditor child = new frmEditor(this, counter++);
            child.Show();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void titleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

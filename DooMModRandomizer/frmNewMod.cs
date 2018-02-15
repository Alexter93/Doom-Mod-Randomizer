using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmNewMod : Form
    {
        private List<Mod> editedModList = new List<Mod>();

        public frmNewMod()
        {
            InitializeComponent();
        }

        public frmNewMod(ref List<Mod> importedModList)
        {
            InitializeComponent();
            editedModList = importedModList;
        }

        private void btnBrowseIWAD_Click(object sender, EventArgs e)
        {
            OpenFileDialog modFile = new OpenFileDialog();
            modFile.Filter = "Wad files (*.wad)|*wad|PK3 files (*.pk3)|*.pk3|Zip files (*.zip)|*.zip|Rar files (*.rar)|*.rar|All files (*.*)|*.*";
            if (modFile.ShowDialog() == DialogResult.OK)
            {
                txtIWad.Text = modFile.FileName;
            }
        }

        private void btnBrowsePWAD_Click(object sender, EventArgs e)
        {
            OpenFileDialog IWADFile = new OpenFileDialog();
            IWADFile.Filter = "PWad files (*.wad)|*wad|All files (*.*)|*.*";
            if (IWADFile.ShowDialog() == DialogResult.OK)
            {
                txtWad.Text = IWADFile.FileName;
            }
        }

        private void btnBrowseEXE_Click(object sender, EventArgs e)
        {
            OpenFileDialog EXEFile = new OpenFileDialog();
            EXEFile.Filter = "Executable files (*.exe)|*exe|All files (*.*)|*.*";
            if (EXEFile.ShowDialog() == DialogResult.OK)
            {
                txtExe.Text = EXEFile.FileName;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            editedModList.Add(new Mod(txtExe.Text, txtIWad.Text, txtWad.Text));
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

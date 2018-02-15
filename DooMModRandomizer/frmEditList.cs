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
    public partial class frmEditList : Form
    {
        private List<Mod> editedModList = new List<Mod>();

        /*public frmEditList()
        {
            InitializeComponent();
            cboMods.DataSource = null;

        }*/

        public frmEditList(ref List<Mod> importedModList)
        {
            InitializeComponent();
            editedModList = importedModList;
            cboMods.DataSource = null;
            cboMods.DataSource = editedModList;

        }

        // user clicks delete
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete " + cboMods.SelectedValue.ToString() + " from the list of mods?", "DooM Mod Randomizer", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                editedModList.Remove(editedModList.ElementAt(cboMods.SelectedIndex));
                cboMods.DataSource = null;
                cboMods.DataSource = editedModList;
            }
        }

        // updates the textboxes with the mod's PWAD and Source Port
        private void cboMods_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMods.DataSource == null)
            {
                txtIWad.Text = string.Empty;
                txtExe.Text = string.Empty;
            }
            else
            {
                txtIWad.Text = editedModList.ElementAt(cboMods.SelectedIndex).getIWadFile();
                txtExe.Text = editedModList.ElementAt(cboMods.SelectedIndex).getExeFile();
            }
        }

        // updates the PWAD and the Sourceport of a mod
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            editedModList.ElementAt(cboMods.SelectedIndex).setIWadFile(txtIWad.Text);
            editedModList.ElementAt(cboMods.SelectedIndex).setExeFile(txtExe.Text);
        }

        // closes the form, saves nothing
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        // opens a broswer window for a mod's PWAD
        private void btnBrowsePWAD_Click(object sender, EventArgs e)
        {
            OpenFileDialog IWADFile = new OpenFileDialog();
            IWADFile.Filter = "PWad files (*.wad)|*wad|All files (*.*)|*.*";
            if (IWADFile.ShowDialog() == DialogResult.OK)
            {
                txtIWad.Text = IWADFile.FileName;
            }
        }

        // opens a broswer window for a mod's Source Port
        private void btnBrowseEXE_Click(object sender, EventArgs e)
        {
            OpenFileDialog EXEFile = new OpenFileDialog();
            EXEFile.Filter = "Executable files (*.exe)|*exe|All files (*.*)|*.*";
            if (EXEFile.ShowDialog() == DialogResult.OK)
            {
                txtExe.Text = EXEFile.FileName;
            }
        }
    }
}

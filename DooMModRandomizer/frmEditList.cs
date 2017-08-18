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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete " + cboMods.SelectedValue.ToString() + " from the list of mods?", "DooM Mod Randomizer", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                editedModList.Remove(editedModList.ElementAt(cboMods.SelectedIndex));
                cboMods.DataSource = null;
                cboMods.DataSource = editedModList;
            }
        }
    }
}

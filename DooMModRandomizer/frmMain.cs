﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class frmMain : Form
    {
        private Random rando = new Random();
        public List<Mod> modList = new List<Mod>();
        //TextWriter dataSaver;
        //TextReader dataReader;
        //private static class File;

        public frmMain()
        {
            InitializeComponent();

            if(!File.Exists("modData.txt"))
            {
                File.CreateText("modData.txt");
            }

            using(StreamReader dataReader = File.OpenText("modData.txt"))
            {
                string fileString;
                string EXEString;
                string IWADString;
                while (!dataReader.EndOfStream)
                {
                    fileString = dataReader.ReadLine().ToString();
                    EXEString = dataReader.ReadLine().ToString();
                    IWADString = dataReader.ReadLine().ToString();
                    //MessageBox.Show("Found: \"" + fileString + "\" found in ./modData.txt");
                    modList.Add(new Mod(EXEString, fileString, IWADString));
                }
            }
                     
            lstMods.DataSource = modList;
            
        }

        // ready to fight hell's forces
        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (!modList.Any()) // if no mods selected
                MessageBox.Show("There are no mods loaded onto the list. Please load at least one mod (If you're uncreative).", "DooM Mod Randomizer", MessageBoxButtons.OK);
            else // randomly choose a mod
            {
                Mod selectedMod = modList.ElementAt(rando.Next(modList.Count));
                ProcessStartInfo launchInfo = new ProcessStartInfo();
                launchInfo.FileName = selectedMod.getExeFile();
                launchInfo.Arguments = selectedMod.GetArgument();

                try
                {
                    using (Process launchProcess = Process.Start(launchInfo))
                    {
                        MessageBox.Show(launchInfo.ToString());
                        launchProcess.WaitForExit();
                    }
                }

                catch
                {
                    MessageBox.Show("Something went wrong when opening DooM!", "DooM Mod Randomizer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // opens a file browser to select a mod to add to the list
        private void btnAdd_Click(object sender, EventArgs e)
        {
            /*OpenFileDialog modFile = new OpenFileDialog();
            modFile.Filter = "Wad files (*.wad)|*wad|PK3 files (*.pk3)|*.pk3|Zip files (*.zip)|*.zip|Rar files (*.rar)|*.rar|All files (*.*)|*.*";
            if (modFile.ShowDialog() == DialogResult.OK)
            {
                modList.Add(new Mod(modFile.FileName));

                using (StreamWriter dataSaver = File.CreateText("modData.txt"))
                {
                    for (int i = 0; i < modList.Count(); i++)
                    {
                        dataSaver.WriteLine(modList.ElementAt(i).getModFile());
                    }
                }

                    //dataSaver = new StreamWriter("modData.txt");
                    //dataSaver.WriteLine(modFile.FileName);
                    lstMods.DataSource = null;
                lstMods.DataSource = modList;
                //dataSaver.Close();
            }*/

            // save the mod to the txt file
            frmNewMod addModForm = new frmNewMod(ref modList);
            addModForm.ShowDialog();

            using (StreamWriter dataSaver = File.CreateText("modData.txt"))
            {
                for (int i = 0; i < modList.Count(); i++)
                {
                    dataSaver.WriteLine(modList.ElementAt(i).getModFile());
                    dataSaver.WriteLine(modList.ElementAt(i).getExeFile());
                    dataSaver.WriteLine(modList.ElementAt(i).getIWadFile());
                }
            }

            lstMods.DataSource = null;
            lstMods.DataSource = modList;
        }

        // opens the edit window
        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmEditList editModForm = new frmEditList(ref modList);
            editModForm.ShowDialog();

            /* dataSaver = new StreamWriter("modData.txt", false);

             for (int i = 0; i < modList.Count(); i++)
             {
                 dataSaver.WriteLine(modList.ElementAt(i));
             }*/

            using (StreamWriter dataSaver = File.CreateText("modData.txt"))
            {
                if (!File.Exists("modData.txt"))
                    File.WriteAllText("modData.txt", String.Empty);

                for (int i = 0; i < modList.Count(); i++)
                {
                    dataSaver.WriteLine(modList.ElementAt(i).getModFile());
                    dataSaver.WriteLine(modList.ElementAt(i).getExeFile());
                    dataSaver.WriteLine(modList.ElementAt(i).getIWadFile());
                }
            }

            lstMods.DataSource = null;
            lstMods.DataSource = modList;
        }
    }
}

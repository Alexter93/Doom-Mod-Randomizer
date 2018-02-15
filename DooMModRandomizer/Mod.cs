using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Mod
    {
        private string modFile;
        private string exe;
        private string iwad;

        public Mod(string one)
        {
            exe = "C:\\Games\\DooM\\zdoom-2.8.1\\zdoom.exe"; // CHANGE THIS APPROPRIATELY
            modFile = one;
            iwad = "C:\\Games\\DooM\\Doom2.wad"; // CHANGE THIS APPROPRIATELY
        }

        public Mod(string orig, string mod, string game)
        {
            exe = orig;
            modFile = mod;
            iwad = game;
        }

        // used in to load the source port with the mod
        public string GetArgument()
        {
            return " -iWad " + iwad + " -file " + modFile;
        }

        // when the mod is used as a string, it only refers to the filename and not the full path
        public override string ToString()
        {
            return modFile.Remove(0, (modFile.LastIndexOf('\\') + 1));
        }

        public string getModFile()
        { return modFile; }
        public string getExeFile()
        { return exe; }
        public string getIWadFile()
        { return iwad; }

        public void setExeFile(string executable)
        { exe = executable; }
        public void setIWadFile(string gameFile)
        { iwad = gameFile; }
    }
}

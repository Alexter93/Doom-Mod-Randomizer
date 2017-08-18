using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Mod
    {
        protected string exe;
        protected string modFile;
        protected string iwad;

        public Mod(string one)
        {
            exe = "C:\\Games\\DooM\\zdoom-2.8.1\\zdoom.exe"; // CHANGE THIS APPROPRIATELY
            modFile = one;
            iwad = "C:\\Games\\DooM\\Doom2.wad"; // CHANGE THIS APPROPRIATELY
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

        public string getExe()
        { return exe; }
        public string getModFile()
        { return modFile; }
        
    }
}

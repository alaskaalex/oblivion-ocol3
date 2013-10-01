using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OCOL {
    public class OCOLOptions {
        public String oblivionLauncherPath = Main.oblivionFolder + "obse_loader.exe";
        public String oblivionLauncherArgs = "";
        public String CSPath = Main.oblivionFolder + "obse_loader.exe";
        public String CSArgs = "-editor";

        public String oblivionFolder = "C:\\Program Files (x86)\\Bethesda Softworks\\Oblivion\\";

        public String oblivionMyGames = Main.oblivionMyGames;

        public bool checkForOCOLUpdates = true;
    }
}

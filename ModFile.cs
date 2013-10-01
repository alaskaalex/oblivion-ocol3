using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace OCOL
{
    public class ModFile : IComparable
    {
        public String name;
        public DateTime modified;
        public DateTime created;
        public Boolean active = false;
        private String author;
        private String description;
        private List<String> masters;

        public ModFile() { }

        public ModFile(String Name, DateTime Modified, DateTime Created, Boolean Active) {
            name = Name;
            modified = Modified;
            created = Created;
            active = Active;
        }

        public String getAuthor()
        {
            if (author != null)
                return author;
            else
            {
                getDetailedInfo();
                return author;
            }
        }

        public List<String> getMasters()
        {
            if (masters != null)
                return masters;
            else
            {
                getDetailedInfo();
                return masters;
            }
        }

        public String getDescription()
        {
            if (description != null)
                return description;
            else
            {
                getDetailedInfo();
                return description;
            }
        }

        public void getDetailedInfo()
        {
            StreamReader fss = File.OpenText(Main.dataFolder + this.name);
            char[] buffer = new char[1000];
            fss.Read(buffer, 0, 1000);
            String fs = new  String(buffer);
            fss.Close();
            //String fs = File.ReadAllText("D:/Installations/Bethesda Softworks/Oblivion/Data/" + this.name);
            
            int cnamidx = fs.IndexOf("CNAM");
            int snamidx = fs.IndexOf("SNAM");
            int mastidx = fs.IndexOf("MAST");
            int dataidx = fs.IndexOf("DATA");

            author = "DEFAULT";
            if (cnamidx > 0 && cnamidx < 50)
            {
                if (snamidx > 0 && snamidx < 150)
                {
                    author = fs.Substring(cnamidx + 6, (snamidx - cnamidx - 6));
                }
                else if (mastidx > 0 && mastidx < 150)
                {
                    author = fs.Substring(cnamidx + 6, (mastidx - cnamidx - 6));
                }
            }
            description = "";
            if (snamidx > 0 && snamidx < 200)
            {
                if (mastidx > 0 && mastidx < 600)
                    description = fs.Substring(snamidx + 6, (mastidx - snamidx - 6));
                else if (dataidx > 0 && dataidx < 600)
                    description = fs.Substring(snamidx + 6, (dataidx - snamidx - 6));
            }
            masters = new List<String>();
            while(mastidx > 0)
            {
                fs = fs.Substring(mastidx + 6);
                masters.Add(fs.Substring(0, fs.IndexOf("DATA")-1));
                mastidx = fs.IndexOf("MAST");
            }
        }




        public override String ToString()
        {
            return name;
        }




        #region IComparable Members

        public int CompareTo(object m)
        {
            return modified.CompareTo(((ModFile)m).modified);
        }

        #endregion
    }
}

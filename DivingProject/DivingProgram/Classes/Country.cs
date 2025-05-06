using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivingProgram
{
    internal class Country
    {
        string name;
        string linkFile;
        List<DivingSite> divingSites;

        public Country()
        {
            
        }
        public Country(string name, string linkFile, List<DivingSite> divingSites)
        {
            this.name = name;
            this.linkFile = linkFile;
            this.divingSites = divingSites;
        }

        public string GetName() {  return name; }
        public string GetLinkFile() { return linkFile; }
        public List<DivingSite> GetDivingSites() { return divingSites; }


    }
}

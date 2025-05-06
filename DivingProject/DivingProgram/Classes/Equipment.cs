using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivingProgram
{
    internal class Equipment
    {
        private string nameOfEquipment;
        private int amount;
        private string description;

        public Equipment(string nameOfEquipment, int amount, string description)
        {
            this.nameOfEquipment = nameOfEquipment;
            this.amount = amount;
            this.description = description;
        }
        
    }
}

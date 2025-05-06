    using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivingProgram
{
    internal class DivingSession
    {
        private DivingClub club;
        private DateTime date;
        private DateTime startTime;
        private DateTime endTime;
        
        private double temperature;
        private bool tide;
        private DivingSite site;
        private Instructor instructor;
        private List <Diver> divers;
        private Dictionary<int, (string, DateTime)> endSessionSign = new Dictionary <int, (string, DateTime)>();

        public DivingSession(DivingClub club, DateTime date, DateTime startTime, DateTime endTime, double temperature, bool tide, DivingSite site, Instructor instructor, List<Diver> divers)
        {
            this.club = club;
            this.date = date;
            this.startTime = startTime;
            this.endTime = endTime;
            this.temperature = temperature;
            this.tide = tide;
            this.site = site;
            this.divers = divers;
        }




    }
}

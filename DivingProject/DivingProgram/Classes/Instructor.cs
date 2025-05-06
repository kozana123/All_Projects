using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace DivingProgram
{
    internal class Instructor : Diver
    {


        Dictionary<string, (string start, string end)> workingHistory = new Dictionary<string, (string start, string end)>();

        public Instructor(string firstName, string lastName, string email, string password, DateTime birthDate, int diverIdNumber, int numOfDives, Rank rank, Dictionary<string, (string start, string end)> workingHistory) : base(firstName, lastName, email, password, birthDate, diverIdNumber, numOfDives, rank)
        {

        }

        public Instructor(string firstName, string lastName, string email, string password, DateTime birthDate, int diverIdNumber, int numOfDives, Rank rank, Dictionary<string, (string start, string end)> workingHistory, BitmapImage profileImage) : base(firstName, lastName, email, password, birthDate, diverIdNumber, numOfDives, rank, profileImage)
        {

        }
    }
}

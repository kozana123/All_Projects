using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace DivingProgram
{
    internal class Diver: Person
    {
        private int diverIdNumber;
        protected int numOfDives;
        private List<DivingSession> divingSession;
        private Rank rank;
        private BitmapImage profileImage = new BitmapImage(new Uri("C:\\Users\\Dor Mesika\\Desktop\\תכנות מונחה עצמים\\DivingProgram\\DivingProgram\\Pictures\\blank-profile-picture-973460_1280.webp"));

        //public Diver(string firatName, string lastName, string email, string password, DateTime birthDate, int diverIdNumber) : base(firatName, lastName, email, password, birthDate)
        //{
        //    this.diverIdNumber = diverIdNumber;
        //}

        public Diver(string firstName, string lastName, string email, string password, DateTime birthDate, int diverIdNumber,int numOfDives, Rank rank) :base (firstName, lastName, email, password, birthDate)
        {
            this.numOfDives = numOfDives;
            this.diverIdNumber = diverIdNumber;
            this.rank = rank;
        }

        public Diver(string firstName, string lastName, string email, string password, DateTime birthDate, int diverIdNumber, int numOfDives, Rank rank, BitmapImage profileImage) : base(firstName, lastName, email, password, birthDate)
        {
            this.numOfDives = numOfDives;
            this.diverIdNumber = diverIdNumber;
            this.rank = rank;
            this.profileImage = profileImage;
        }

        public int GetDiverIdNumber() { return diverIdNumber; }
        public int GetNumOfDives() { return numOfDives; }

        public Rank GetRank() { return rank; } 
        public BitmapImage GetProfileImage() { return profileImage; }

        public void SetProfileImage(BitmapImage profileImage) { this.profileImage = profileImage; }
        public void SetNumOfDives(int numOfDives) { this.numOfDives = numOfDives; }






    }
}

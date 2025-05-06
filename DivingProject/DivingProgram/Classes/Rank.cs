using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace DivingProgram
{
    enum Ranks
    {
        FirstStar = 30,
        SecondStar = 100,
        AssistantInstructor,
        Instructor
    }
    internal class Rank
    {
        string rankName;
        DivingClub club;
        DateTime dateOfRecipt;
        private BitmapImage RankImage;

        public Rank(string rankName, DivingClub club, DateTime dateOfRecipt)
        {
            this.rankName = rankName;
            this.club = club;
            this.dateOfRecipt = dateOfRecipt;
        }

        public Rank()
        {
            
        }

        public string GetRankName() { return rankName; }
        public DateTime GetDateOfRecipt() { return dateOfRecipt; }
        public DivingClub GetClub() { return club; }
        public BitmapImage GetRankImage() { return RankImage; }

        public void SetRankName(string rankName) { this.rankName = rankName; }
        public void SetDateOfRecipt(DateTime dateOfRecipt) { this.dateOfRecipt = dateOfRecipt; }
        public void SetClub(DivingClub club) { this.club = club; }
        public void SetRankImage(BitmapImage img) { this.RankImage = img; }





    }
}

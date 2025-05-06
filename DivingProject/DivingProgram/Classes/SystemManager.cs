//using DivingProgram.Classes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using static System.Reflection.Metadata.BlobBuilder;

namespace DivingProgram
{
    internal class SystemManager
    {
        private static Dictionary<string, Diver> dictOfDiversUsers;
        private static List<DivingClub> Clubs;
        private static Diver connectDiver;
        private static List<Country> countries;
        private static List<DivingSite> divingSites;
        private static bool once = false;

        public SystemManager()
        {
            if (once == false) 
            {
                List<DivingSite> divingSitesBonaire = new List<DivingSite>
                {
                    new DivingSite("Salt Pier", "Bonaire", "Kralendijk, Bonaire", "Famous for its pier dives with rich marine life.", 35.0, true),
                    new DivingSite("Karpata", "Bonaire", "Kralendijk, Bonaire", "A shallow reef with excellent coral formations.", 18.0, false),
                };
                List<DivingSite> divingSitesEgypt = new List<DivingSite>
                {
                    new DivingSite("Ras Mohammed National Park", "Egypt", "Sharm El Sheikh, Egypt", "A protected area with abundant marine life and beautiful coral reefs.", 50.0, true),
                    new DivingSite("Thistlegorm Wreck", "Egypt", "Red Sea, Egypt", "A famous wreck dive with intact cargo and diverse marine life.", 40.0, true),

                };
                List<DivingSite> divingSitesMexico = new List<DivingSite>
                {
                    new DivingSite("Cozumel Reefs", "Mexico", "Cozumel, Mexico", "A diverse reef system with colorful corals and rich marine life.", 30.0, true),
                    new DivingSite("Cenote Diving (Cenote Dos Ojos)", "Mexico", "Yucatán Peninsula, Mexico", "Unique freshwater cenote diving with crystal-clear waters.", 25.0, false),

                };
                List<DivingSite> divingSitesMaldives = new List<DivingSite>
                {
                    new DivingSite("North Ari Atoll", "Maldives", "North Ari Atoll, Maldives", "A top dive site with diverse coral gardens and marine life.", 40.0, true),
                    new DivingSite("Maaya Thila", "Maldives", "South Ari Atoll, Maldives", "A small pinnacle known for its abundance of sharks and fish.", 35.0, true),

                };
                List<DivingSite> divingSitesThailand = new List<DivingSite>
                {
                    new DivingSite("Koh Tao", "Thailand", "Koh Tao, Thailand", "A famous island with many dive sites, including the popular Chumphon Pinnacle.", 25.0, false),
                    new DivingSite("Koh Samui", "Thailand", "Koh Samui, Thailand", "A tropical island with some amazing dive sites like Sail Rock.", 30.0, true),

                };
                List<DivingSite> divingSitesIndonesia = new List<DivingSite>
                {
                    new DivingSite("Manta Point", "Indonesia", "Nusa Penida, Bali, Indonesia", "A popular site for manta ray sightings.", 30.0, true),
                    new DivingSite("Shark Point", "Indonesia", "Komodo, Indonesia", "Famous for its shark population and crystal-clear water.", 40.0, true),

                };
                List<DivingSite> divingSitesMalaysia = new List<DivingSite>
                {
                    new DivingSite("Tunku Abdul Rahman Marine Park", "Malaysia", "Kota Kinabalu, Malaysia", "A marine park with many islands and coral reefs.", 25.0, false),
                    new DivingSite("Sipadan Island", "Malaysia", "Sabah, Malaysia", "One of the best diving spots in the world, known for its turtles and sharks.", 50.0, true),

                };
                List<DivingSite> divingSitesAustralia = new List<DivingSite>
                {
                    new DivingSite("Ningaloo Reef", "Australia", "Western Australia, Australia", "A world-renowned reef system with beautiful corals and marine life.", 40.0, true),
                    new DivingSite("HMAS Swan Wreck", "Australia", "Busselton, Western Australia", "A wreck dive with a lot of fish life surrounding the wreck.", 30.0, true),

                };

                countries = new List<Country>();
                countries.Add(new Country("Bonaire", "https://www.bonairedive.com", divingSitesBonaire));
                countries.Add(new Country("Egypt", "https://www.divingegypt.com", divingSitesEgypt));
                countries.Add(new Country("Mexico", "https://www.mexicodive.com", divingSitesMexico));
                countries.Add(new Country("Maldives", "https://www.maldivesdive.com", divingSitesMaldives));
                countries.Add(new Country("Thailand", "https://www.thailanddiving.com", divingSitesThailand));
                countries.Add(new Country("Indonesia", "https://www.indonesiadive.com", divingSitesIndonesia));
                countries.Add(new Country("Malaysia", "https://www.malaysiadive.com", divingSitesMalaysia));
                countries.Add(new Country("Australia", "https://www.australiadive.com", divingSitesAustralia));

                divingSites = new List<DivingSite>();
                foreach (var country in countries)
                {
                    foreach (var site in country.GetDivingSites())
                    {
                        divingSites.Add(site);
                    }
                }

                Clubs = new List<DivingClub>();
                Clubs.Add(new DivingClub("Buddy Dive Resort – Bonaire", "1234", "John De Graaf", "Kaya Gob. N. Debrot 85, Kralendijk, Bonaire", "+599-717-5080", new Country("Bonaire", "https://www.bonairedive.com", divingSitesBonaire), "info@buddydive.com", ""));
                Clubs.Add(new DivingClub("Emperor Divers – Egypt", "5678", "Ahmed Khalil", "Safaga Road, Hurghada, Egypt", "+20-122-3456789", new Country("Egypt", "https://www.divingegypt.com", divingSitesEgypt), "contact@emperordivers.com", "https://www.emperordivers.com"));
                Clubs.Add(new DivingClub("Pro Dive International – Mexico", "9087", "Maria Gonzalez", "Avenida Juárez 101, Playa del Carmen, Mexico", "+52-984-873-1234", new Country("Mexico", "https://www.mexicodive.com", divingSitesMexico), "booking@prodive.com", "https://www.prodive.com"));
                Clubs.Add(new DivingClub("Blue Force Fleet – Maldives", "7689", "Andrea Russo", "Haa Alifu Atoll, Maldives", "+960-777-5678", new Country("Maldives", "https://www.maldivesdive.com", divingSitesMaldives), "reservations@blueforcefleet.com", "https://www.blueforcefleet.com"));
                Clubs.Add(new DivingClub("Sub Aqua Dive Club – Thailand", "4456", "Chaiwat Somsri", "Beach Road, Pattaya, Thailand", "+66-38-555-789", new Country("Thailand", "https://www.thailanddiving.com", divingSitesThailand), "info@subaquadive.com", "https://www.subaquadive.com"));
                Clubs.Add(new DivingClub("Manta Dive Gili Air – Indonesia", "3219", "Ketut Ardi", "Gili Air Island, West Nusa Tenggara, Indonesia", "+62-370-654321", new Country("Indonesia", "https://www.indonesiadive.com", divingSitesIndonesia), "info@mantadive.com"));
                Clubs.Add(new DivingClub("Dive Downbelow – Malaysia", "5674", "Peter Chong", "Tunku Abdul Rahman Park, Kota Kinabalu, Malaysia", "+60-88-765432", new Country("Malaysia", "https://www.malaysiadive.com", divingSitesMalaysia), "contact@divedownbelow.com", "https://www.divedownbelow.com"));
                Clubs.Add(new DivingClub("Cape Dive – Australia", "1230", "Emily Watson", "22 Queen Street, Busselton, Western Australia", "+61-8-9754-9876", new Country("Australia", "https://www.australiadive.com", divingSitesAustralia), "bookings@capedive.com"));

                dictOfDiversUsers = new Dictionary<string, Diver>();
                Rank firstStarRank = new Rank("FirstStar", Clubs[3], DateTime.Now.AddYears(-5));
                Rank secondStarRank = new Rank("SecondStar", Clubs[5], DateTime.Now.AddYears(-3));
                Rank InstructorRank = new Rank("Instructor", Clubs[5], DateTime.Now.AddYears(-3));
                dictOfDiversUsers.Add("john.doe@email.com", new Diver("John", "Doe", "john.doe@email.com", "password123", new DateTime(2000, 5, 10), 12345, 100, InstructorRank));
                dictOfDiversUsers.Add("alice.smith@email.com", new Diver("Alice", "Smith", "alice.smith@email.com", "alicepass456", new DateTime(1985, 8, 15), 67890, 80, firstStarRank));
                dictOfDiversUsers.Add("bob.johnson@email.com", new Diver("Bob", "Johnson", "bob.johnson@email.com", "bobpass789", new DateTime(1988, 11, 22), 11223, 65, secondStarRank));
                dictOfDiversUsers.Add("carol.white@email.com", new Diver("Carol", "White", "carol.white@email.com", "carolpass234", new DateTime(1992, 3, 5), 44567, 22, secondStarRank));
                dictOfDiversUsers.Add("dave.brown@email.com", new Diver("Dave", "Brown", "dave.brown@email.com", "davepass890", new DateTime(1989, 7, 30), 89012, 77, secondStarRank));

                once = true;
            }
            

        }


        public void AddDiver(Diver diver)
        {
            if (!dictOfDiversUsers.ContainsKey(diver.email))
            {
                dictOfDiversUsers.Add(diver.email, diver);
                MessageBox.Show("Diver successfully registered!");
            }
            else
            {
                MessageBox.Show("Diver with this email already exists!");
            }
        }


        public bool Login(string email, string password)
        {
            if (dictOfDiversUsers.TryGetValue(email, out Diver diver))
            {
                if (diver.GetPassword() == password) 
                {
                    connectDiver = diver;
                    return true;
                }
            }
            return false;
        }

        public Diver GetConnectedDiver() { return connectDiver; }

        public List<DivingClub> GetDivingClubs() { return Clubs; }

        public List<Country> GetCountryList() { return countries; }

        public List<DivingSite> GetDivingSites() { return divingSites; }


        public void SetConnectedDiver()
        {
            var diver = dictOfDiversUsers.Values.First();
            connectDiver = diver;
        }

        public void DiversListBox(ListBox listBox)
        {
            
            ArrayList diverNameList = new ArrayList();
            foreach (var item in dictOfDiversUsers)
            {
                diverNameList.Add(item.Value.GetFirstName() + " " + item.Value.GetLasttName() + " " + item.Value.GetDiverIdNumber());
            }

            listBox.ItemsSource = diverNameList;
        }

        public void CountryListBox(ListBox listBox)
        {
            ArrayList countriesList = new ArrayList();
            foreach (Country country in countries)
            {
                countriesList.Add(country.GetName());
            }

            listBox.ItemsSource = countriesList;
            
        }

        public void DivingClubListBox(ListBox listBox)
        {
            ArrayList divingClubsList = new ArrayList();
            foreach (DivingClub divingClub in Clubs)
            {
                divingClubsList.Add(divingClub.GetName());
            }

            listBox.ItemsSource = divingClubsList;
        }

        public void DivingSitesList(ListBox listBox)
        {
            throw new NotImplementedException();
        }
    }
}

using System;

namespace HarryPotter
{
    interface IGoldenTrio
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }

        string Fullname();
    }


    class Character : IGoldenTrio
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        

        public string RecognizableFeature { get; set; }

        public string FavoriteSpell { get; set; }

        public string Fullname() => $"{FirstName} {MiddleName} {LastName}"; 

        public Character()
        {
            Id = 0;
            FirstName = string.Empty;
            MiddleName = string.Empty;
            LastName = string.Empty;
            RecognizableFeature = string.Empty;
            FavoriteSpell = string.Empty;
        }


        public Character(int id, string firstName, string middleName, string lastName, string recFeat, string favSpell)
        {
            Id = id;
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            RecognizableFeature = recFeat;
            FavoriteSpell = favSpell;
        }
        public string FullChar()
        {
            return $"{Id} {FirstName} {MiddleName} {LastName} -- Recognizable Feature: {RecognizableFeature} | Favorite Spell: {FavoriteSpell}"; 
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Character harry = new Character(1, "Harry", "James", "Potter", "Lightning Bolt Scar", "Expelliarmus");
            Console.WriteLine(harry.FullChar());

            Character hermione = new Character
            {


                Id = 2,
                FirstName = "Hermione",
                MiddleName = "Jean",
                LastName = "Granger",
                RecognizableFeature = "Bushy Hair",
                FavoriteSpell = "Oculus Reparo"
            };

            Console.WriteLine(hermione.FullChar());

            Character ron = new Character
            {


                Id = 3,
                FirstName = "Ronald",
                MiddleName = "Bilius",
                LastName = "Weasley",
                RecognizableFeature = "Red Hair",
                FavoriteSpell = "Eat Slugs!"
            };

            Console.WriteLine(ron.FullChar());
        }
    }


    
}


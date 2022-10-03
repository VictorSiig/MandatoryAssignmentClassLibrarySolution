using System.Reflection.Metadata.Ecma335;

namespace MandatoryAssignmentClassLibrary {
    public class FootballPlayer {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int ShirtNumber { get; set; }

        public FootballPlayer() { }

        public FootballPlayer(int id, string name, int age, int shirtNumber) {
            Id = id;
            Name = name;
            Age = age;
            ShirtNumber = shirtNumber;
        }

        public void ValidateId() {
            if (Id < 1) {
                throw new ArgumentOutOfRangeException("Id must be bigger than 0");
            } else return;
        }
        public void ValidateName() {
            if (Name.Length < 2) {
                throw new ArgumentOutOfRangeException("Name must be longer than 1 character");
            } else return;
        }
        public void ValidateAge() {
            if (Age < 1) {
                throw new ArgumentOutOfRangeException("Player must be older than 0 years old");
            } else return;
        }
        public void ValidateShirtNumber() {
            if (ShirtNumber < 1 || ShirtNumber > 99) {
                throw new ArgumentOutOfRangeException("Shirt number must be between 1 and 99");
            } else return;
        }
    }
}
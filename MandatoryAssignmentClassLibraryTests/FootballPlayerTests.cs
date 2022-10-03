using Microsoft.VisualStudio.TestTools.UnitTesting;
using MandatoryAssignmentClassLibrary;

namespace MandatoryAssignmentClassLibrary.Tests {
    [TestClass()]
    public class FootballPlayerTests {

        [TestMethod()]
        public void FootballPlayerTest() {
            FootballPlayer footballPlayer = new FootballPlayer(1, "Michael Laudrup", 56, 10);
        }

        [TestMethod()]
        public void ValidateIdTest() {
            FootballPlayer player = new FootballPlayer(1, "Michael Laudrup", 56, 10);
            FootballPlayer invalidIdPlayer = new FootballPlayer(0, "Rasmus Lauge", 30, 9);
            FootballPlayer negativeNrPlayer = new FootballPlayer(-10, "??", 101, 91);

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => invalidIdPlayer.ValidateId());
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => negativeNrPlayer.ValidateId());
        }

        [TestMethod()]
        public void ValidateNameTest() {
            FootballPlayer player = new FootballPlayer(1, "Ib", 56, 10);
            FootballPlayer invalidNamePlayer = new FootballPlayer(2, "Å", 30, 9);

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => invalidNamePlayer.ValidateName());
        }

        [TestMethod()]
        public void ValidateAgeTest() {
            FootballPlayer player = new FootballPlayer(1, "Michael Laudrup", 56, 10);
            FootballPlayer invalidPlayer = new FootballPlayer(2, "Rasmus Lauge", 0, 9);
            FootballPlayer negativeAgePlayer = new FootballPlayer(3, "??", -101, 91);

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => invalidPlayer.ValidateAge());
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => negativeAgePlayer.ValidateAge());
        }

        [TestMethod()]
        public void ValidateShirtNumberTest() {
            FootballPlayer player = new FootballPlayer(1, "Michael Laudrup", 56, 10);
            FootballPlayer moreThanTopNumberPlayer = new FootballPlayer(2, "Rasmus Lauge", 0, 100);
            FootballPlayer negativeNumberPlayer = new FootballPlayer(-3, "Peter", 18, -1);
            FootballPlayer lessThanLowestNumberPlayer = new FootballPlayer(4, "Hans", 19, 0);

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => moreThanTopNumberPlayer.ValidateShirtNumber());
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => lessThanLowestNumberPlayer.ValidateShirtNumber());
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => negativeNumberPlayer.ValidateShirtNumber());
        }
    }
}
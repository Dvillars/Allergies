using Xunit;

namespace Allergies
{
    public class AllergyTest
    {
        [Fact]
        public void List_ReturnUserNumberAndAllergies_Eggs()
        {
            //Arrange
            int newInput = 1;
            Allergy AllergyTest = new Allergy();

            //Act
            AllergyTest.SetInput(newInput);
            string result = AllergyTest.List();

            //Assert
            Assert.Equal("eggs", result);
        }

        [Fact]
        public void List_ReturnUserNumberAndAllergies_9ToStrawAndEggs()
        {
            //Arrange
            int newInput = 9;
            Allergy AllergyTest = new Allergy();

            //Act
            AllergyTest.SetInput(newInput);
            string result = AllergyTest.List();

            //Assert
            Assert.Equal("strawberries eggs", result);
        }

        [Fact]
        public void List_ReturnUserNumberAndAllergies_130ToCatsAndPeanuts()
        {
            //Arrange
            int newInput = 130;
            Allergy AllergyTest = new Allergy();

            //Act
            AllergyTest.SetInput(newInput);
            string result = AllergyTest.List();

            //Assert
            Assert.Equal("cats peanuts", result);
        }

        [Fact]
        public void List_ReturnUserNumberAndAllergies_255Toall()
        {
            //Arrange
            int newInput = 255;
            Allergy AllergyTest = new Allergy();

            //Act
            AllergyTest.SetInput(newInput);
            string result = AllergyTest.List();

            //Assert
            Assert.Equal("cats pollen chocolate tomatoes strawberries shellfish peanuts eggs", result);
        }

        [Fact]
        public void List_ReturnUserNumberAndAllergies_52Tochotomshell()
        {
            //Arrange
            int newInput = 52;
            Allergy AllergyTest = new Allergy();

            //Act
            AllergyTest.SetInput(newInput);
            string result = AllergyTest.List();

            //Assert
            Assert.Equal("chocolate tomatoes shellfish", result);
        }
    }
}

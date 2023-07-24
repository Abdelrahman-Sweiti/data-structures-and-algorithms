using CodeChallenge12;
using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void TestEnqueueAndDequeue()
        {
            // Arrange
            AnimalShelter shelter = new AnimalShelter();
            Animal cat1 = new Animal("cat", "Fluffy");
            Animal dog1 = new Animal("dog", "Buddy");
            Animal cat2 = new Animal("cat", "Whiskers");
            Animal dog2 = new Animal("dog", "Max");

            // Act
            shelter.Enqueue(cat1);
            shelter.Enqueue(dog1);
            shelter.Enqueue(cat2);
            shelter.Enqueue(dog2);

            Animal adoptedCat = shelter.Dequeue("cat");
            Animal adoptedDog = shelter.Dequeue("dog");

            // Assert
            Assert.Equal("Fluffy", adoptedCat.Name);
            Assert.Equal("Buddy", adoptedDog.Name);
            Assert.Equal(1, shelter.CatsCount);
            Assert.Equal(1, shelter.DogsCount);
        }

        [Fact]
        public void TestDequeueEmptyShelter()
        {
            // Arrange
            AnimalShelter shelter = new AnimalShelter();

            // Act
            Animal adoptedCat = shelter.Dequeue("cat");
            Animal adoptedDog = shelter.Dequeue("dog");

            // Assert
            Assert.Null(adoptedCat);
            Assert.Null(adoptedDog);
        }

        [Fact]
        public void TestInvalidSpecies()
        {
            // Arrange
            AnimalShelter shelter = new AnimalShelter();
            Animal invalidAnimal = new Animal("bird", "Tweety");

            // Act & Assert
            Assert.Throws<ArgumentException>(() => shelter.Enqueue(invalidAnimal));
        }
    }
}

using CodeChallenge33;
using System.Collections;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Insert_AddsKeyValuePairToHashTable()
        {
            // Arrange
            HashTable hashTable = new HashTable();
            string key = "testKey";
            string value = "testValue";

            // Act
            hashTable.Insert(key, value);

            // Assert
            Assert.True(hashTable.Contains(key));
            Assert.Equal(value, hashTable.Get(key));
        }

        [Fact]
        public void Contains_ReturnsTrueForExistingKey()
        {
            // Arrange
            HashTable hashTable = new HashTable();
            string key = "testKey";
            string value = "testValue";
            hashTable.Insert(key, value);

            // Act
            bool result = hashTable.Contains(key);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void Contains_ReturnsFalseForNonExistingKey()
        {
            // Arrange
            HashTable hashTable = new HashTable();
            string key = "testKey";

            // Act
            bool result = hashTable.Contains(key);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void Get_ReturnsValueForExistingKey()
        {
            // Arrange
            HashTable hashTable = new HashTable();
            string key = "testKey";
            string value = "testValue";
            hashTable.Insert(key, value);

            // Act
            string result = hashTable.Get(key);

            // Assert
            Assert.Equal(value, result);
        }

        [Fact]
        public void Get_ReturnsNullForNonExistingKey()
        {
            // Arrange
            HashTable hashTable = new HashTable();
            string key = "testKey";

            // Act
            string result = hashTable.Get(key);

            // Assert
            Assert.Null(result);
        }
    }
}
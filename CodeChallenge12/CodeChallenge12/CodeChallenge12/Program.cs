using System;

namespace CodeChallenge12
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // Test the AnimalShelter class
            AnimalShelter shelter = new AnimalShelter();

            Animal cat1 = new Animal("cat", "Sarah");
            Animal dog1 = new Animal("dog", "Chaos");
            Animal cat2 = new Animal("cat", "Sasha");
            Animal dog2 = new Animal("dog", "Leard");

            shelter.Enqueue(cat1);
            shelter.Enqueue(dog1);
            shelter.Enqueue(cat2);
            shelter.Enqueue(dog2);

            // Dequeue a cat
            Animal adoptedCat = shelter.Dequeue("cat");
            if (adoptedCat != null)
            {
                Console.WriteLine($"Adopted Cat: {adoptedCat.Name}");
            }
            else
            {
                Console.WriteLine("No cat available for adoption.");
            }

            // Dequeue a dog
            Animal adoptedDog = shelter.Dequeue("dog");
            if (adoptedDog != null)
            {
                Console.WriteLine($"Adopted Dog: {adoptedDog.Name}");
            }
            else
            {
                Console.WriteLine("No dog available for adoption.");
            }
        }
    }

    public class AnimalShelter
    {
        private Queue<Animal> dogs;
        private Queue<Animal> cats;

        public AnimalShelter()
        {
            dogs = new Queue<Animal>();
            cats = new Queue<Animal>();
        }

        public int CatsCount => cats.Count;
        public int DogsCount => dogs.Count;

        public void Enqueue(Animal animal)
        {
            if (animal.Species == "cat")
            {
                cats.Enqueue(animal);
            }
            else if (animal.Species == "dog")
            {
                dogs.Enqueue(animal);
            }
            else
            {
                throw new ArgumentException("Animal species must be either 'cat' or 'dog'.");
            }
        }

        public Animal Dequeue(string pref)
        {
            if (pref == "cat" && cats.Count > 0)
            {
                return cats.Dequeue();
            }
            else if (pref == "dog" && dogs.Count > 0)
            {
                return dogs.Dequeue();
            }
            else
            {
                return null;
            }
        }
    }
}

using System;

namespace Ex06Animals
{
    public abstract class Animal : ISoundProducable
    {
        private string animalType;
        private string name;
        private int? age;
        private string gender;

        public string AnimalType { get; set; }

        public string Name
        {
            get => name;

            set
            {
                if (string.IsNullOrWhiteSpace(value) || value == string.Empty)
                {
                    throw new ArgumentException("Invalid input!");
                }
                name = value;
            }
        }

        public int? Age
        {
            get => age;

            set
            {
                if (value == null || value < 0)
                {
                    throw new ArgumentException("Invalid input!");
                }
                age = value;
            }
        }

        public string Gender
        {
            get => gender;

            set
            {
                if (string.IsNullOrWhiteSpace(value) || value == string.Empty)
                {
                    throw new ArgumentException("Invalid input!");
                }
                gender = value;
            }
        }

        public Animal(string anymalType, string name, int age, string gender)
        {
            AnimalType = anymalType;
            Name = name;
            Age = age;
            Gender = gender;
        }

        public abstract void ProduceSound();

        public override string ToString()
        {
            return $"{AnimalType}\n{Name} {Age} {Gender}";
        }
    }
}

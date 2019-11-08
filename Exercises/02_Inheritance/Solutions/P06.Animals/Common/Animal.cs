namespace Animals.Common
{
    using System;
    using System.Text;

    public abstract class Animal : IProduceSound
    {
        private const string InvalidInputExceptionMessage = "Invalid input!";

        private string name;
        private int age;
        private string gender;

        public Animal(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public string Name 
        {
            get 
            {
                return this.name;
            }
            protected set
            {
                if (IsNotValid(value))
                {
                    throw new InvalidOperationException(InvalidInputExceptionMessage);
                }

                this.name = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            protected set
            {
                if (IsNotValid(value.ToString()) || value < 0)
                {
                    throw new InvalidOperationException(InvalidInputExceptionMessage);
                }

                this.age = value;
            }
        }

        public string Gender
        {
            get
            {
                return this.gender;
            }
            protected set
            {
                if (IsNotValid(value))
                {
                    throw new InvalidOperationException(InvalidInputExceptionMessage);
                }

                this.gender = value;
            }
        }

        public abstract string ProduceSound();

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"{this.GetType().Name}");
            stringBuilder.AppendLine($"{this.Name} {this.Age} {this.Gender}");

            return stringBuilder.ToString().TrimEnd();
        }

        private bool IsNotValid(string value)
        {
            if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
            {
                return true;
            }

            return false;
        }
    }
}

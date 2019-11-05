namespace Animals.Models
{
    using Common;
    using Common.Enumerations;

    public class Dog : IAnimal
    {
        public Dog(string name, int age, Gender gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public string Name { get; set; }

        public int Age { get; set; }

        public Gender Gender { get; set; }

        public string ProduceSound()
        {
            return "Woof!";
        }
    }
}

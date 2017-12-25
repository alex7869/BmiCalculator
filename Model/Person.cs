namespace Model
{
    public class Person
    {
        public Person(int age, string name, double weight, double height)
        {
            Age = age;
            Name = name;
            Weight = weight;
            Height = height;
        }

        public int Age { get; }

        public string Name { get; }

        public double Weight { get; }

        public double Height { get; }

    }
}
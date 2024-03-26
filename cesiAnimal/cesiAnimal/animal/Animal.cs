// See https://aka.ms/new-console-template for more information


namespace cesiAnimal.animal
{
    public abstract class Animal
    {
        public String Name { get; protected set; }

        public Animal()
        {
            Name = "non-existent";
        }

        public Animal(String name)
        {
            this.Name = name;
        }

        public void move()
        {
            if (Name == null)
            {
                Console.WriteLine("invisible animal move");

                return;
            }

            Console.WriteLine(Name + " move");
        }

        public void sleep()
        {
            if (Name == null)
            {
                Console.WriteLine("invisible animal sleep");

                return;
            }

            Console.WriteLine(Name + " sleep");
        }

        public abstract void cry();
    }
}
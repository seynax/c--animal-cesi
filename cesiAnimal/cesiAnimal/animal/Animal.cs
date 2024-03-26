// See https://aka.ms/new-console-template for more information


namespace cesiAnimal.animal
{
    public abstract class Animal
    {
        public String name { get; protected set; }

        public Animal()
        {
            this.name = "non-existent";
        }

        public Animal(String name)
        {
            this.name = name;
        }

        public void move()
        {
            if (name == null)
            {
                Console.WriteLine("invisible animal move");

                return;
            }

            Console.WriteLine(name + " move");
        }

        public void sleep()
        {
            if (name == null)
            {
                Console.WriteLine("invisible animal sleep");

                return;
            }

            Console.WriteLine(name + " sleep");
        }

        public abstract void cry();
    }
}
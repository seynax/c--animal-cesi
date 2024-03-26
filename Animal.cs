// See https://aka.ms/new-console-template for more information

abstract class Animal
{
    public String name;

    public Animal()
    {

    }

    public Animal(String name)
    {
        this.name = name;
    }

    public void move()
    {
        if(name == null)
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

    public class Wolf : Animal
    {
        public Wolf()
        {
            this.name = "Wolf";
        }

        public override void cry()
        {
            Console.WriteLine("Arou Arou !");
        }

        public void eat(Animal animal)
        {
            Console.WriteLine(this.name + " eat " + animal.name);
        }
    }

    public class Sheep : Animal
    {
        public Sheep()
        {
            this.name = "Sheep";
        }

        public override void cry()
        {
            Console.WriteLine("Bee Bee !");
        }
    }
}
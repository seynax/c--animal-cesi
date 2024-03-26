// See https://aka.ms/new-console-template for more information


using static Animal;

class Program
{
    static void Main(string[] args)
    {
        Wolf wolf = new Wolf();
        Sheep sheep = new Sheep();

        wolf.cry();
        wolf.move();
        sheep.move();
        wolf.eat(sheep);
        sheep.cry();
        wolf.sleep();
    }
}
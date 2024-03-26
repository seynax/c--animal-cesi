// See https://aka.ms/new-console-template for more information


using cesiAnimal.animal;

class Program
{
    static void Main(string[] args)
    {
        Wolf wolf = new Wolf();
        Sheep sheep = new Sheep();
        Griffin griffin = new Griffin();
        Dragon dragon = new Dragon();

        wolf.cry();
        wolf.move();
        sheep.move();
        wolf.eat(sheep);
        sheep.cry();
        wolf.sleep();
        dragon.cry();
        dragon.eat(wolf);
        griffin.cry();
        griffin.sleep();
        dragon.eat(griffin);
    }
}
using cesiAnimal.animal;
using cesiAnimal.vehicle;

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
        dragon.mount(griffin);



        dragon.eat(griffin);

        Ship ship = new Ship();
        ship.mount(dragon);
        ship.move();
        ship.unmount(dragon);
        dragon.eat(ship);
        dragon.eat(dragon);


        Console.ReadLine();
    }
}
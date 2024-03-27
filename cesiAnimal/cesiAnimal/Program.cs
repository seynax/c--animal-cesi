using cesiAnimal.animal;
using cesiAnimal.vehicle;

class Program
{
    static void Main(string[] args)
    {
        Wolf wolf = new();
        Sheep sheep = new();
        Griffin griffin = new();
        Dragon dragon = new();
        Ship ship = new();

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
        ship.mount(dragon);
        ship.move();
        ship.unmount(dragon);
        dragon.eat(ship);
        dragon.eat(dragon);

        IList<Wolf> wolfs = new List<Wolf>
        {
            new Wolf("wolf"),
            new Wolf("snow"),
            new Wolf("boby"),
            new Wolf("billy"),
            new Wolf("woup")
        };

        IEnumerable<Wolf> selectedWolfs = from selectedWolf in wolfs
                                  where selectedWolf.Name != "snow"
                                  select selectedWolf;

        Console.WriteLine();
        Console.WriteLine();

        foreach (var selectedWolf in selectedWolfs)
        {
            Console.WriteLine(selectedWolf.Name);
        }

        IList<Animal> animals = new List<Animal>()
        {
            new Dragon(),
            new Griffin(),
            new Wolf(),
            new Sheep()
        };

        IEnumerable<Animal> selectedAnimals = animals.Where(animal => animal.Rarity < 51);

        Console.WriteLine();
        Console.WriteLine();

        foreach (var selectedAnimal in selectedAnimals)
        {
            Console.WriteLine(selectedAnimal.id + " : " + selectedAnimal.Name + ", " + selectedAnimal.Rarity + " % appear probability");
        }

        Console.ReadLine();
    }
}
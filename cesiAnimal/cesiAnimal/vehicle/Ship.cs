using cesiAnimal.animal;

namespace cesiAnimal.vehicle
{
    public class Ship : Vehicle
    {
        public Ship()
        {
            this.name = "ship";
        }

        public override void mount(Animal animal)
        {
            Console.WriteLine(animal.name + " mount on " + this.name);
        }

        public override void move()
        {
            Console.WriteLine(this.name + " move");
        }

        public override void unmount(Animal animal)
        {
            Console.WriteLine(animal.name + " unmount " + this.name);
        }
    }
}
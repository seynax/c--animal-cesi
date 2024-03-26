using cesiAnimal.animal;

namespace cesiAnimal.vehicle
{
    public abstract class Vehicle : Drivable
    {
        public String name { get; protected set; }

        public Vehicle()
        {
            this.name = "non-existent";
        }

        public Vehicle(String name)
        {
            this.name = name;
        }

        public virtual void mount(Animal animal)
        {
            Console.WriteLine(animal.name + " mount on " + this.name);
        }

        public virtual void move()
        {
            Console.WriteLine(this.name + " move");
        }

        public virtual void unmount(Animal animal)
        {
            Console.WriteLine(animal.name + " unmount " + this.name);
        }
    }
}
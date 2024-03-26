using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using cesiAnimal.vehicle;

namespace cesiAnimal.animal
{
    internal class Dragon : Animal, Drivable
    {
        public Dragon()
        {
            this.name = "Dragon";
        }

        public override void cry()
        {
            Console.WriteLine("Grrrr grr !");
        }

        public void eat(Animal animal)
        {
            Console.WriteLine(this.name + " eat " + animal.name);
        }

        public void eat(Vehicle vehicle)
        {
            Console.WriteLine(this.name + " eat " + vehicle.name + " vehicle");
        }

        public void mount(Animal animal)
        {
            Console.WriteLine(animal.name + " mount on dragon");
        }

        public void move()
        {
            Console.WriteLine("move with animal");
        }

        public void unmount(Animal animal)
        {
            Console.WriteLine(animal.name + " unmount on dragon");

        }
    }
}

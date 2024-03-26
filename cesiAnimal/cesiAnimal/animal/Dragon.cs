using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cesiAnimal.animal
{
    internal class Dragon : Animal
    {
        public Dragon()
        {
            this.Name = "Dragon";
        }

        public override void cry()
        {
            Console.WriteLine("Grrrr grr !");
        }

        public void eat(Animal animal)
        {
            Console.WriteLine(this.Name + " eat " + animal.Name);
        }
    }
}

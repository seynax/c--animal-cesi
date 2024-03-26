using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cesiAnimal.animal
{
    internal class Griffin : Animal
    {
        public Griffin()
        {
            this.name = "Griffin";
        }

        public override void cry()
        {
            Console.WriteLine("Anini !");
        }

        public new void sleep()
        {
            Console.WriteLine(this.name + " strange sleeping");
        }
    }
}

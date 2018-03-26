using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class Reptile : Animal
    {
        new string name;

        public Reptile(string name)
        {
            this.name = name;
        }


        public override void Greet()
        {
            throw new NotImplementedException();
        }

        public override string WantChild()
        {
            return "want a child from an egg!";
        }
    }
}

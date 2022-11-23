using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hunter_2022_11_23
{
    abstract class Animal
    {
        const double basePrice = 100000;

        public new virtual string GetType() { return " prémjének az ára: "; }

        public virtual double getPrice() { return basePrice; }
    }
}

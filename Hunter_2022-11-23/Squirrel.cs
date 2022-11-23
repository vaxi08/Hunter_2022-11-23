using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hunter_2022_11_23
{
    class Squirrel: Animal
    {
        const double squirrelFactor = 1.2;
        const string type = "mókus";

        public override string GetType()
        {
            return type + base.GetType();
        }

        public override double getPrice()
        {
            return base.getPrice() * squirrelFactor;
        }
    }
}

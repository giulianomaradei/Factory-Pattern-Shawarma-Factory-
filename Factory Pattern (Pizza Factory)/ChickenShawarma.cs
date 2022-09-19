using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern__Pizza_Factory_.Sabores {
    public class ChickenShawarma : Shawarma {
        public ChickenShawarma() {
            name = "Chiken";
            meat = "Fried Chicken";
            salad = "Tomatos and Lettuce";
            sauce = "Mix of Hot Sauce and Mayo";
            price = 3.5;
        }

        

    }
}

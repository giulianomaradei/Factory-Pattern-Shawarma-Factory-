using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern__Pizza_Factory_.Sabores {
    public class MeatShawarma : Shawarma{
        public MeatShawarma() {
            name = "Meat";
            meat = "Cow meat from cows";
            salad = "More cow meat from more other cows";
            sauce = "Sauce to put into the cow meat and cow meat salad";
            price = 3.5;
        }

        

    }
}

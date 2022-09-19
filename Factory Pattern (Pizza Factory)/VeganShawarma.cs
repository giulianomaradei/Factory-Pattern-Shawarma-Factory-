using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern__Pizza_Factory_.Sabores {
    public class VeganShawarma : Shawarma {
        public VeganShawarma() {
            name = "Vegan (MeatLess)";
            meat = "Tofu";
            salad = "Cocumber, Bell pepper and  Purple Onions";
            sauce = "Vegan Barbecue";
            price = 4.0;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern__Pizza_Factory_ {
    public abstract class Shawarma {
        protected string name { get; set; }
        protected string meat;
        protected string salad;
        protected string sauce;
        protected double price;

        public override string ToString() {
            return "Your " + name + "Shawarma is ready, made with the most delicius ingredients\n" +
                "Meat: " + meat + "\n" +
                "Salad: " + salad + "\n" +
                "Sauce: " + sauce + "\n" +
                "Price: " + price + "\n";
        }

    }
}

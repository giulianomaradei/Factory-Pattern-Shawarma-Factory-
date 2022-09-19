using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern__Pizza_Factory_ {
    internal class Program {
        static void Main(string[] args) {
            ShawarmaShop shop = new ShawarmaShop();

            Console.WriteLine("Choose your Shawarma\n1-Meat\n2-Vegan\n3-Chicken\n");
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine(shop.AssembleShawarma(input).ToString());

            Console.ReadKey(true);
        }
    }
}

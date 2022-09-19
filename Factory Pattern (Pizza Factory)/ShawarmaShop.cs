using Factory_Pattern__Pizza_Factory_.Sabores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern__Pizza_Factory_ {
    public class ShawarmaShop : ShawarmaFactory {
        protected override Shawarma MakeShawarma(int tipo) {
            if(tipo == 2) 
                return new VeganShawarma();      
            else if(tipo == 1) 
                return new MeatShawarma();            
            else if(tipo == 3) 
                return new ChickenShawarma();            
            else
                return null;
        }


    }
}

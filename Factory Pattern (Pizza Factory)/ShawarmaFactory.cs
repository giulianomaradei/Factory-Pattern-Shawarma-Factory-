using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern__Pizza_Factory_ {
    public abstract class ShawarmaFactory {

        public Shawarma AssembleShawarma(int tipo) {
            Shawarma shawarma;
            shawarma = MakeShawarma(tipo);
            return shawarma;
        }

        protected abstract Shawarma MakeShawarma(int tipo);

    }
}

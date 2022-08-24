using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ER2
{
    public abstract class Pessoa
    {
        public string nome { get; set; }

        public string endereco { get; set; }

        public bool endeCom { get; set; }

        public void PagarImposto(){}
        
        
    }
}
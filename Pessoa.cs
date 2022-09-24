using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ER2
{
    public abstract class Pessoa
    {
        //atributos
        public string? nome { get; set; }

        public Endereco? endereco { get; set; } 

        
        //metodos
        public abstract float PagarImposto(float rendimento);
        
        
    }
}
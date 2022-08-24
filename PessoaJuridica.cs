using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ER2
{
    public class PessoaJuridica : Pessoa
    {
        public string CNPJ { get; set; }

        public string RazaoSocial { get; set; }
        
        
    }
}
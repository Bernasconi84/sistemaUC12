using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ER2
{
    public class Endereco
    {
        public string logradouro { get; set;}
        public int numero { get; set; }
        public string complemento { get; set; }
        public bool endeCom { get; set; }
        
        public string cep { get; set; }
        
        
    }
}
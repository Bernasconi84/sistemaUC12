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
        
        public override void PagarImposto(float rendimento){} 

        public bool validarCNPJ(string CNPJ){
            if(CNPJ.Length >= 14 && (CNPJ.Substring(CNPJ.Length - 4)) =="0001"){
                return true;
            }else{
                return false;
            }
        }
        
    }
}
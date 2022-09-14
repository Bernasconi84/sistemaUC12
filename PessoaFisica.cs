using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ER2
{
    public class PessoaFisica : Pessoa
    {
        public string CPF { get; set; }

        public DateTime dataNasc { get; set; }
        public override void PagarImposto(float rendimento){ }

        public bool ValidarDataNasc(DateTime dataNasc){
            DateTime dataAtual = DateTime.Today;

            double anos = +(dataAtual - dataNasc).TotalDays/365;

            if(anos >= 18){
                return true;
            }else{
                return false;
            };
        }
        
        
    }
}
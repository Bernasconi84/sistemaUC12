using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ER2
{
    public class PessoaFisica : Pessoa
    {
        public string? CPF { get; set; }

        public DateTime dataNasc { get; set; }
        public override float PagarImposto(float salario){ 
            if (salario <= 1500){
                return 0;
            }else if (salario > 1500 && salario <= 5000){
                return (salario * 3)/100;
            }else{
                return (salario * 5)/100;
            }
        }

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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ER2
{
    public class PessoaJuridica : Pessoa
    {
        public string? CNPJ { get; set; }

        public string? RazaoSocial { get; set; }

        public string caminho { get; private set; } = "Database/PessoaJuridica.csv";
        
        
        
        public override float PagarImposto(float rendimento){
            if(rendimento <= 5000){
                return (rendimento * 6)/100;
            }else if(rendimento > 5000 && rendimento <= 10000){
                return (rendimento * 8)/100;
            }else{
                return (rendimento * 10)/100;
            }
            
        } 

        public bool validarCNPJ(string CNPJ){
            if(CNPJ.Length >= 14 && (CNPJ.Substring(CNPJ.Length - 4)) =="0001"){
                return true;
            }else{
                return false;
            }
        }

        public void Inserir(PessoaJuridica pj){
            VerificarPastaArquivo(caminho);

            string[] pjstring = {$"{pj.nome}, {pj.CNPJ}, {pj.RazaoSocial}"};

            File.AppendAllLines(caminho, pjstring);
        }
        public List<PessoaJuridica> ler(){

            List<PessoaJuridica> listapj = new List<PessoaJuridica>();
            string[]linhas = File.ReadAllLines(caminho);

            foreach(string cadalinha in linhas){
                string[] atributos = cadalinha.Split(",");

                PessoaJuridica cadaPj = new PessoaJuridica();

                cadaPj.nome = atributos[0];
                cadaPj.CNPJ = atributos[1];
                cadaPj.RazaoSocial = atributos[2];

                listapj.Add(cadaPj);
            }
            return listapj;
        }
    }
}
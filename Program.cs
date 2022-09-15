namespace ER2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            // Console.WriteLine(@$"
            // ===============================================
            // |                                             |
            // |        Seja bem vindo ao nosso Sistema      |
            // |            de cadastro de pessoas           |
            // |              Físicas e Jurídicas            |
            // ===============================================
            // ");


            Console.Write("iniciando");
            Thread.Sleep(1000);
            Console.Write("#");

            for (var contador = 0; contador < 10; contador++)
            {
                Thread.Sleep(1000);
                Console.Write("#");
            }
            Console.Clear();

             string opcao;

            do{
            Console.WriteLine(@$"
          ===============================================
          *        Seja bem vindo ao nosso Sistema      *
          *            de cadastro de pessoas           *
          *              Físicas e Jurídicas            *
          ***********************************************                                             
          *        Escolha uma das opções abaixo        *
          ***********************************************                                             
          *         1 - Pessoa Física                   *
          *         2 - Pessoa Jurídica                 *
          *         0 - Sair                            *
          ===============================================
          ");

           
            opcao = Console.ReadLine();
            switch (opcao){
              case "1":
              break;
               case "2":
              break;
               case "0":
              break;
              default:
              System.Console.WriteLine("Opção inválida, por favor digite uma das opções apresentadas.");
              break;
            }
            }while(opcao != "0");

            Console.ResetColor();


            // Endereco end = new Endereco();
            // end.logradouro = "Rua Estrela";
            // end.numero = 99;
            // end.complemento = "casa";
            // end.endeCom = false;  

            // PessoaFisica pf = new PessoaFisica();
            // pf.endereco = end;
            // pf.nome = "Bernasconi";
            // pf.CPF = "36996336936";
            // pf.dataNasc = new DateTime(1984, 01, 14);

            // System.Console.WriteLine($"{pf.nome} mora na rua:{pf.endereco.logradouro},{pf.endereco.numero}");
            // System.Console.WriteLine(pf.ValidarDataNasc(pf.dataNasc));

            // bool idadeValida = pf.ValidarDataNasc(pf.dataNasc);
            // System.Console.WriteLine(idadeValida);

            // if(idadeValida== true){
            //   System.Console.WriteLine("Cadastro aprovado");
            // }else{ 
            //   System.Console.WriteLine("Cadastro reprovado");
            // }


            // PessoaJuridica pj = new PessoaJuridica();

            // Endereco end = new Endereco();
            // end.logradouro = "Rua Estrela";
            // end.numero = 99;
            // end.complemento = "casa";
            // end.endeCom = false;  

            // pj.endereco = end;
            // pj.CNPJ = "12345678990001";
            // pj.RazaoSocial = "Alegria";

            // pj.validarCNPJ(pj.CNPJ);

            // if(pj.validarCNPJ(pj.CNPJ)){
            //   System.Console.WriteLine("CNPJ válido!");
            // }else{
            //   System.Console.WriteLine("CNPJ inválido!");
            // };





        }
    }
}
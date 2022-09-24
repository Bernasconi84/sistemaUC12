namespace ER2
{
    public class Program
    {
        static void Main(string[] args)
        {

          static void BarraCarregamento(string texto)
          {
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(texto);
            Thread.Sleep(100);
           
            for (var contador = 0; contador < 10; contador++)
            {
                 Console.Write("$");
                Thread.Sleep(100);
               
               
            }
          }

            Console.BackgroundColor = ConsoleColor.DarkCyan;
           

            BarraCarregamento("Iniciando ");
            Console.Clear();

             string? opcao;

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
          *                                             *
          *         0 - Sair                            *
          ===============================================
          ");

           
            opcao = Console.ReadLine();
            switch (opcao){
              case "1":
              Endereco endPF = new Endereco();
              endPF.logradouro = "Rua estrela D'Avila";
              endPF.numero = 36;
              endPF.complemento = "Jardim Das Azaleias";
              endPF.endeCom = false;

              PessoaFisica Guilherme = new PessoaFisica();
              Guilherme.CPF = "36369363936";
              Guilherme.dataNasc = new  DateTime(1986, 06, 15);
              Guilherme.nome = "Guilherme Machado Ruiz";

              float impostoAPagar = Guilherme.PagarImposto(10000);

              System.Console.WriteLine(@$"
               Nome: {Guilherme.nome}
               imposto a pagar: {impostoAPagar}
               CPF: {Guilherme.CPF}
               Data de Nascimento: {Guilherme.dataNasc.ToString("dd/MM/yyyy")}
               Endereço: {endPF.logradouro}, {endPF.numero}"
               );
              break;

               case "2":
               Endereco endPJ = new Endereco();
               endPJ.logradouro = "José de Alencar";
               endPJ.numero = 180;
               endPJ.complemento = "Centro Empresarial";
               endPJ.endeCom = true;

               PessoaJuridica pj = new PessoaJuridica();
               pj.CNPJ = "12345678901";
               pj.endereco = endPJ;
               pj.RazaoSocial = "Pessoa Jurídica";
               pj.nome = "Avon";

               float impostoPJuridica = pj.PagarImposto(10000);

               System.Console.WriteLine(@$"
               Razão Social: {pj.RazaoSocial}
               Nome: {pj.nome}
               CNPJ: {pj.CNPJ}
               Imposto a pagar: {impostoPJuridica}
               Rua: {endPJ.logradouro},{endPJ.numero}
               ");
              break;

               case "0":
               Console.WriteLine("Obrigado por utilizar o nosso sistema.");
               Console.ForegroundColor = ConsoleColor.DarkBlue;
               BarraCarregamento("Finalizando ");
               Thread.Sleep(500);
           
          
              break;
              default:
              System.Console.WriteLine("Opção inválida, por favor digite uma das opções apresentadas.");
              break;
            }
            }while(opcao != "0");

            Console.ResetColor();


        }
    }
}
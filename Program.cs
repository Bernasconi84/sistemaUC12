namespace ER2
{
    public class Program
    {
        static void Main(string[] args)
        {
          List<PessoaFisica> listapf = new List<PessoaFisica>();


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
          *             Pessoa Física                   *
          *        1 - Cadastrar Pessoa Física          *
          *        2 - Listar Pessoa Física             *
          *        3 - Remover Pessoa Física            *
          *                                             *
          *            Pessoa Jurídica                  *
          *        1 - Cadastrar Pessoa Jurídica        *
          *        2 - Listar Pessoa Jurídica           *
          *        3 - Remover Pessoa Jurídica          *
          ***********************************************
          *        0 - Sair                             *
          ===============================================
          ");

           
            opcao = Console.ReadLine();
            switch (opcao){
               case "1":
               Endereco endPF = new Endereco();
               System.Console.WriteLine("Digite seu logradouro");
               endPF.logradouro = Console.ReadLine();

               System.Console.WriteLine("Digite o número da residência");
               endPF.numero = int.Parse(Console.ReadLine());
              
               System.Console.WriteLine(@$"Digite o complemento (caso exista), senão pressione enter para pular");
               endPF.complemento = Console.ReadLine();
               
               System.Console.WriteLine("Este endereço é comercial? (S/N)");
                string endeCom = Console.ReadLine().ToUpper();

                if (endeCom == "S"){
                  endPF.endeCom = false;
                }else{
                  endPF.endeCom = true;
                }

               PessoaFisica pf = new PessoaFisica();
               pf.endereco = endPF;

               System.Console.WriteLine("Digite seu CPF (Somente Números)");
               pf.CPF = Console.ReadLine();
               
               System.Console.WriteLine("Digite seu Nome");
               pf.nome = Console.ReadLine();
               
               System.Console.WriteLine("Digite o valor do seu salário (Somente Números)");
               pf.salario = float.Parse(Console.ReadLine());

               System.Console.WriteLine("Digite sua data de nascimento [AA, MM, DD]");
               pf.dataNasc = DateTime.Parse(Console.ReadLine());

               bool idadeValida = pf.ValidarDataNasc(pf.dataNasc);

               if (idadeValida == true){
                System.Console.WriteLine("Cadastro Aprovado");
                listapf.Add(pf);
                System.Console.WriteLine(pf.PagarImposto(pf.salario));
               }else{
                System.Console.WriteLine("Cadastro reprovado");
               }

              break;

               case "2":
               foreach (var cadaItem in listapf){
                System.Console.WriteLine($"{cadaItem.nome}, {cadaItem.CPF}");
               }
               
              break;
               
               case "3":
               System.Console.WriteLine("Digite o CPF que deseja remover:");
               string cpfProcuado = Console.ReadLine();
               PessoaFisica pessoaEncontrada = listapf.Find(cadaItem => cadaItem.CPF == cpfProcuado);

               if (pessoaEncontrada != null){
                listapf.Remove(pessoaEncontrada);
                System.Console.WriteLine("CPF removido");
               }else{
                System.Console.WriteLine("CPF não encontrado");
               }
                
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
namespace DesafioPOO.Models
{
    public class Menu
    {
        public static void AdicionarCelular(string opcao)
        {
            Console.Clear();
            Console.WriteLine("Qual é o número do seu smartphone?");
            string numero = Console.ReadLine();

            Console.WriteLine("Qual é o modelo do seu smartphone?");
            string modelo = Console.ReadLine();

            Console.WriteLine("Qual é o número IMEI do seu smartphone?");
            string imei = Console.ReadLine();

            Console.WriteLine("Qual a memória do seu smartphone?");
            int memoria = Convert.ToInt32(Console.ReadLine());

            switch(opcao)
            {
                case "1":
                    AdicionarSmartphoneNokia(numero, modelo, imei, memoria);
                    break;
                case "2":
                    AdicionarIphone(numero, modelo, imei, memoria);
                    break;
            }
            Console.Clear();
        }

        public static void AdicionarSmartphoneNokia(string numero, string modelo, string imei, int memoria)
        {
            Smartphone nokia = new Nokia(numero, modelo, imei, memoria);
            AcessarMenuDeFuncoes(nokia);
        }

        public static void AdicionarIphone(string numero, string modelo, string imei, int memoria)
        {
            Smartphone iphone = new Iphone(numero, modelo, imei, memoria);
            AcessarMenuDeFuncoes(iphone);
        }

        public static void AcessarMenuDeFuncoes(Smartphone smartphone)
        {
            bool exibirMenuDeFuncoes = true;

            while(exibirMenuDeFuncoes)
            {
                Console.Clear();
                Console.WriteLine("Menu de funções\n");
                Console.WriteLine("1 - Fazer Ligação");
                Console.WriteLine("2 - Receber ligação");
                Console.WriteLine("3 - Instalar aplicativo");
                Console.WriteLine("4 - Sair do menu de funções");
                string opcao = Console.ReadLine();

                switch(opcao)
                {
                    case "1":
                        smartphone.Ligar();
                        Console.WriteLine("\nDigite qualquer tecla para retornar");
                        Console.ReadKey();
                        break;
                    case "2":
                        smartphone.ReceberLigacao();
                        Console.WriteLine("\nDigite qualquer tecla para retornar");
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.WriteLine("Qual aplicativo deseja instalar?");
                        string app = Console.ReadLine();
                        smartphone.InstalarAplicativo(app);
                        Console.WriteLine("\nDigite qualquer tecla para retornar");
                        Console.ReadKey();
                        break;
                    case "4":
                        exibirMenuDeFuncoes = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            }
        }

        public static void InstalarApp(string nomeApp)
        {
            int progressoAtual = 0;

            Thread.Sleep(2000);
            while(progressoAtual != 100)
            {
                progressoAtual += 20;
                Console.Clear();
                Console.WriteLine($"Baixando {nomeApp}...");
                Console.Write(progressoAtual + "%");
                Thread.Sleep(1000);
            }
            Console.WriteLine($"\n{nomeApp} instalado com sucesso!");
        }
    }
}
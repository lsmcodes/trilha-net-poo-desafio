using DesafioPOO.Models;

Console.OutputEncoding = System.Text.Encoding.UTF8;

bool exibirMenu = true;

while(exibirMenu){
    Console.Clear();
    Console.WriteLine("Escolha o seu smartphone:\n");
    Console.WriteLine("1 - Nokia");
    Console.WriteLine("2 - Iphone");
    Console.WriteLine("3 - Sair");

    string opcao = Console.ReadLine();

    switch(opcao)
    {
        case "1":
            Menu.AdicionarCelular("1");
            break;
        case "2":
            Menu.AdicionarCelular("2");
            break;
        case "3":
            exibirMenu = false;
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}
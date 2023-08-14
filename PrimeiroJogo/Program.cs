// Programa gera um número aleatório entre 1 e 100 e o usuário deve adivinhar qual é esse número,
// e quando acertar o jogo acaba.

void AdivinheONumero()
{
    #region Random, Nexxt and NextDouble
    // Durante o desafio aprendi como gerar números aleatórios
    // Existe uma classe que pertence ao namespace System, que nos permite gerar os números aleatórios
    // Para gerar número inteiro é necessário dentro de uma variavel inserir o método Next();
    // Podemos esccolher o número gerado dentro do método Next (1, 100);
    // PS: Para gerar um número de ponto flutuante é necessário inserir NextDouble();
    #endregion
    Random numAleatorio = new Random();

    int numInt = numAleatorio.Next(1, 100);

    Console.Write("Digite seu nome: ");
    string nome = Console.ReadLine()!;
    //Console.Clear faz a limpeza do console
    Console.Clear();
    Console.WriteLine(@"
███╗░░░███╗██╗░░░██╗███╗░░██╗██████╗░░█████╗░░█████╗░██╗░░░░░███████╗░█████╗░████████╗░█████╗░██████╗░██╗░█████╗░
████╗░████║██║░░░██║████╗░██║██╔══██╗██╔══██╗██╔══██╗██║░░░░░██╔════╝██╔══██╗╚══██╔══╝██╔══██╗██╔══██╗██║██╔══██╗
██╔████╔██║██║░░░██║██╔██╗██║██║░░██║██║░░██║███████║██║░░░░░█████╗░░███████║░░░██║░░░██║░░██║██████╔╝██║██║░░██║
██║╚██╔╝██║██║░░░██║██║╚████║██║░░██║██║░░██║██╔══██║██║░░░░░██╔══╝░░██╔══██║░░░██║░░░██║░░██║██╔══██╗██║██║░░██║
██║░╚═╝░██║╚██████╔╝██║░╚███║██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░░██║░░░██║░░░╚█████╔╝██║░░██║██║╚█████╔╝
╚═╝░░░░░╚═╝░╚═════╝░╚═╝░░╚══╝╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚═╝░░░╚═╝░░░░╚════╝░╚═╝░░╚═╝╚═╝░╚════╝░");
    Console.WriteLine($"\nSeja Bem vindo ao MundoAleatório, {nome}!");
    /*O usuário deve adivinhar qual é o número, e quando adivinhar o jogo encerra.*/

    int contador = 10;

    // Diferença de While para Do...While é que no While é possível o código rodar 0 vezes e Do...While ele sempre
    // vai rodar pelo menos uma vez depois verificar
    do
    {
        Console.Write("\nAdivinhe qual é o numero aleatório gerado de 1 a 100: ");
        string numAleatorioUsuario = Console.ReadLine()!;
        var numIntAleatorioUsuario = int.Parse(numAleatorioUsuario);

        if (numInt == numIntAleatorioUsuario)
        {
            Console.Clear();
            Console.WriteLine($"Você acertou! O número era {numInt} Parabéns! Agora encerre seu jogo, muito obrigado por jogar!");
            break;
        }
        else if (numInt < numIntAleatorioUsuario)
        {
            Console.Clear();
            Console.WriteLine("Você errou! Tente novamente. Você ainda tem " + (contador - 1) + " tentativas para jogar!");
            Console.WriteLine("O número é menor");
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Você errou! Tente novamente. Você ainda tem " + (contador - 1) + " tentativas para jogar!");
            Console.WriteLine("O número é maior");
        }
        contador--;
    } while (contador > 0);
    if (contador == 0)
    {
        Console.Clear();
        Console.WriteLine("\nDesculpe, mas você excedeu o limite de tentativas!");
        Console.WriteLine("Dica: O número era " + numInt);
    }
}

AdivinheONumero();

//OBS: Bonus inserir tentativas
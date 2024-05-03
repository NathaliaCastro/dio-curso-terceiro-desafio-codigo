using DesafioDeCodigo.Models;

// ----------------- Desafio das Cartas -----------------

// Input para escolher a carta desejada
int valorEscolhido, naipeEscolhido;

do
{
    Console.WriteLine("As = 1, Valete = 2, Dama = 3, Rei = 4");
    Console.WriteLine($"Digite um número para escolher uma carta: ");
    valorEscolhido = int.Parse(Console.ReadLine());
} 
while (valorEscolhido < 1 || valorEscolhido > 4);

Console.WriteLine("\n");

do
{
    Console.WriteLine("Paus = 0, Ouros = 1, Copas = 2, Espadas = 3");
    Console.WriteLine("Digite um número para escolher um naipe: ");
    naipeEscolhido = int.Parse(Console.ReadLine());
} 
while (naipeEscolhido < 0 || naipeEscolhido > 3);

Console.WriteLine("\n");

// Criação da carta escolhida pelo usuário
Carta cartaEscolhida = new Carta((Naipe)naipeEscolhido, (Valor)valorEscolhido);

// Exibição da carta escolhida pelo usuário
string nomeValor = "", nomeNaipe = "";

switch (cartaEscolhida.GetValor())
{
    case Valor.As:
        nomeValor = "Ás";
        break;
    case Valor.Valete:
        nomeValor = "Valete";
        break;
    case Valor.Dama:
        nomeValor = "Dama";
        break;
    case Valor.Rei:
        nomeValor = "Rei";
        break;
}

switch (cartaEscolhida.GetNaipe())
{
    case Naipe.Paus:
        nomeNaipe = "Paus";
        break;
    case Naipe.Ouros:
        nomeNaipe = "Ouros";
        break;
    //TODO: Complete o código
    
    case Naipe.Copas:
        nomeNaipe = "Copas";
        break;

    case Naipe.Espadas:
        nomeNaipe = "Espadas";
        break;
}

Console.WriteLine($"Você escolheu a carta {nomeValor} de {nomeNaipe}");





























// ----------------- Desafio do Robô -----------------

// string nome;
// string modelo;
// int ano;

// Console.WriteLine("Informe o nome do robô: ");
// nome = Console.ReadLine();

// Console.WriteLine("Informe o modelo do robô: ");
// modelo = Console.ReadLine();

// Console.WriteLine("Informe o ano de fabricação do robô: ");
// ano = int.Parse(Console.ReadLine());
// Console.WriteLine("\n");

// //TODO: Instanciar um Robo passando os valores lidos em seu construtor.
// Robo robo = new Robo (nome, modelo, ano);

// //TODO: Invocar o método "exibirInformacoes".
// robo.ExibirInformacoes(); 






























// ----------------- Desafio do Item mágico -----------------

// Console.WriteLine("Informe o nome do item: ");
// string nome = Console.ReadLine();
// Console.WriteLine("\n");

// Console.WriteLine("Informe a descrição do item: ");
// string descricao = Console.ReadLine();
// Console.WriteLine("\n");

// Console.WriteLine("Informe o poder do item: ");
// int poder = int.Parse(Console.ReadLine());
// Console.WriteLine("\n");

// // Criando o item mágico
// ItemMagico item = new ItemMagico(nome, descricao, poder);

// // Retornando o item criado
// Console.WriteLine($"Item: {item.Nome}\nDescrição: {item.Descricao}\nPoder: {item.Poder}");

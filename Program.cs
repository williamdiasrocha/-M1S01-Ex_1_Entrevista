// See https://aka.ms/new-console-template for more information


//  EXERCICIO 1 - ENTREVISTA


//Entrada de dados

Console.WriteLine("Olá, Tudo bem? Qual é o seu nome?");
string nome = Console.ReadLine();

Console.WriteLine("Bem vindo, " + nome + ". E qual é o seu sobrenome?");
string sobrenome = Console.ReadLine();

Console.WriteLine("E qual é a sua idade, " + nome);
string idade = Console.ReadLine();

Console.WriteLine("Qual a sua cor favorita, " + nome + "?");
string corFavorita = Console.ReadLine();

// Saida de dados

Console.WriteLine("RESPOSTAS DO USUÁRIO");
Console.WriteLine("Seu nome é: " + nome +" "+ sobrenome);
Console.WriteLine("Você tem " + idade + " anos.");
Console.WriteLine("Você prefere a cor " + corFavorita + ".");
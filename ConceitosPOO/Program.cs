// See https://aka.ms/new-console-template for more information
using ConceitosPOO;

Console.WriteLine("Hello, World!");
Cliente cliente;
Console.WriteLine("Informe o nome do cliente");
string nome = Console.ReadLine();
Console.WriteLine("Informe o CPF do cliente");
string cpf = Console.ReadLine();

cliente = new Cliente(nome, cpf);
cliente.Nome = "Marcos";
Console.WriteLine($"Nome do cliente: {cliente.Nome}");
cliente.Cpf = "01";
Console.WriteLine($"Cpf do cliente: {cliente.Cpf}");

Agencia agencia = new Agencia(123);
agencia.Nome = "UGBVR";
agencia.Telefone = "(24)3345-1700";
Console.WriteLine("Dados da agencia: ");
Console.WriteLine("Numero: " + agencia.Numero);
Console.WriteLine("Nome: " + agencia.Nome);
Console.WriteLine("Telefone: " + agencia.Telefone);
Console.WriteLine("Informe o numero da conta: ");
long numero = long.Parse(Console.ReadLine());
//long numero = Convert.ToInt64(Console.ReadLine()):
Console.WriteLine($"Informe o saldo inicial da conta:{numero}:");
decimal saldoIncial = decimal.Parse(Console.ReadLine());
//Imprimir os dados da conta 
Conta conta = new Conta(numero ,saldoIncial);
Console.WriteLine($"Número da Conta: {conta.Numero}");
Console.WriteLine($"Saldo Inicial: {conta.Saldo}");

//depositar 1000 na conta
conta.Deposito(1000);
//exibir saldo
Console.WriteLine($"A conta de numero {conta.Numero} possui {conta.Saldo} de saldo!");
//sacar 500 da conta
conta.Saque(500);
//exbir saldo
Console.WriteLine($"A conta de numero {conta.Numero} possui {conta.Saldo} de saldo!");

//A partir do video identifique as tecnologias utilizadas para o desenvolvimento das soluções apresentadas. Recomenda-se ler os artigos do blog relacionados ao vídeo.

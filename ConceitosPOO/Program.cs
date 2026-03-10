// See https://aka.ms/new-console-template for more information
using ConceitosPOO;

Console.WriteLine("Hello, World!");
Cliente cliente;
cliente = new Cliente("marcos", "123");
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

// See https://aka.ms/new-console-template for more information
using ConceitosPOO;

Console.WriteLine("Hello, World!");
Cliente cliente;
cliente = new Cliente();
cliente.Nome = "Marcos";
Console.WriteLine($"Nome do cliente: {cliente.Nome}");
cliente.Cpf = "01";
Console.WriteLine($"Cpf do cliente: {cliente.Cpf}");

Agencia agencia;
agencia = new Agencia();

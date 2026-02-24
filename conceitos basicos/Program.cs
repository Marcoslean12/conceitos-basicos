// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;

int idade;
idade = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite a sua idade: ");
if (idade >= 18)
{
    Console.WriteLine("Você é o maior de idade!");
}
else
{
    Console.WriteLine("Você é menor de idade!");
}
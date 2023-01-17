using Refatorado;
using System;

ICalculaDescontoFidelidade descFidelidade = new CalculaDescontoFidelidade();
ICalculaDescontoStatusContaFactory descStatusConta = new CalculaDescontoStatusContaFactory();

GerenciadorDeDesconto gerenciadorDeDesconto = new GerenciadorDeDesconto(descFidelidade, descStatusConta);

Console.WriteLine("\nCenário 01: Valor da compra 1.000,00 fidelidade de 10 anos(5%).\n");

var resultado0 = gerenciadorDeDesconto.AplicarDesconto(1000, StatusContaCliente.NaoRegistrado, 0);
Console.WriteLine($"Para o tipo {StatusContaCliente.NaoRegistrado}, o valor a ser pago é de: R${resultado0}");

var resultado1 = gerenciadorDeDesconto.AplicarDesconto(1000, StatusContaCliente.ClienteComum, 10);
Console.WriteLine($"Para o tipo {StatusContaCliente.ClienteComum}, o valor a ser pago é de: R${resultado1}");

var resultado2 = gerenciadorDeDesconto.AplicarDesconto(1000, StatusContaCliente.ClienteEspecial, 10);
Console.WriteLine($"Para o tipo {StatusContaCliente.ClienteEspecial}, o valor a ser pago é de: R${resultado2}");

var resultado3 = gerenciadorDeDesconto.AplicarDesconto(1000, StatusContaCliente.ClienteVip, 10);
Console.WriteLine($"Para o tipo {StatusContaCliente.ClienteVip}, o valor a ser pago é de: R${resultado3}");

Console.WriteLine("\nCenário 02: Valor da compra 1.000,00 fidelidade de 4 anos(4%).\n");
var resultado4 = gerenciadorDeDesconto.AplicarDesconto(1000, StatusContaCliente.ClienteComum, 4);
Console.WriteLine($"Para o tipo {StatusContaCliente.ClienteComum}, o valor a ser pago é de: R${resultado4}");

var resultado5 = gerenciadorDeDesconto.AplicarDesconto(1000, StatusContaCliente.ClienteEspecial, 4);
Console.WriteLine($"Para o tipo {StatusContaCliente.ClienteEspecial}, o valor a ser pago é de: R${resultado5}");

var resultado6 = gerenciadorDeDesconto.AplicarDesconto(1000, StatusContaCliente.ClienteVip, 4);
Console.WriteLine($"Para o tipo {StatusContaCliente.ClienteVip}, o valor a ser pago é de: R${resultado6}");

Console.ReadKey();


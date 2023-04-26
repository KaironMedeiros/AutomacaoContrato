using AutomacaoContrato.Entities;
using AutomacaoContrato.Services;
using System;
using System.Globalization;


namespace AutomacaoContrato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DADOS DO CONTRATO");
            Console.WriteLine("Número do contrato:");
            int numContrato = int.Parse(Console.ReadLine());

            Console.WriteLine("Data do contrato dd/MM/yyyy:");
            DateTime data = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine("Valor do contrato:");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite o número de parcelas");
            int meses = int.Parse(Console.ReadLine());

            Contrato Meucontrato = new Contrato(numContrato, data, valor);

            ContratoService contratoService = new ContratoService(new TaxaPessoaFisica());

            contratoService.ProcessaContrato(Meucontrato, meses);


            Console.WriteLine(Meucontrato);



        }
    }
}

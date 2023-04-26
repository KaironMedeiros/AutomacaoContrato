using AutomacaoContrato.Entities;
using System;


namespace AutomacaoContrato.Services
{
    internal class ContratoService
    {

        private ITaxaService _taxaService;


        public ContratoService(ITaxaService taxaPagamento)
        {
            _taxaService = taxaPagamento;
        }

        public void ProcessaContrato(Contrato contrato, int meses)
        {
            double parcelaBase = contrato.ValorTotal / meses;

            for (int i = 1; i <= meses; i++)
            {
                DateTime data = contrato.Data.AddMonths(i);

                double taxaJuros = parcelaBase + _taxaService.TaxaJuros(parcelaBase, meses);
                double ParcelaTotal = parcelaBase + _taxaService.TaxaServico(taxaJuros);

                contrato.AddParcela(new Parcela(data, ParcelaTotal));
            }
        }
    }
}

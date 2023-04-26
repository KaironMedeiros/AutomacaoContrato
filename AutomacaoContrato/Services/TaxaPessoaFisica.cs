using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomacaoContrato.Services
{
    internal class TaxaPessoaFisica : ITaxaService
    {
        private const double Servico = 0.05;
        private const double JuroMensal = 0.12;

        public double TaxaJuros(double valor, int meses)
        {

            return valor * JuroMensal * meses;


        }

        public double TaxaServico(double valor)
        {
            return valor * Servico;
        }
    }
}

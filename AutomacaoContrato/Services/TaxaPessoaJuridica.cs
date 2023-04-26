using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomacaoContrato.Services
{
    internal class TaxaPessoaJuridica
    {
        internal class TaxaPessoaFisica : ITaxaService
        {
            public double TaxaJuros(double valor, int meses)
            {

                return valor * 0.8 * meses;


            }

            public double TaxaServico(double valor)
            {
                return valor * 0.02;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;


namespace AutomacaoContrato.Entities
{
    internal class Contrato
    {
        public int NumContrato { get; set; }
        public DateTime Data { get; set; }
        public double ValorTotal { get; set; }
        public List<Parcela> Parcelas { get; set; }

        public Contrato(int numContrato, DateTime data, double valorTotal)
        {
            NumContrato = numContrato;
            Data = data;
            ValorTotal = valorTotal;
            Parcelas = new List<Parcela>();
        }

        public void AddParcela(Parcela parcela)
        {
            Parcelas.Add(parcela);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Dados do Contrato:");
            sb.AppendLine($"Número do contrato: {NumContrato}");
            sb.AppendLine($"Data: {Data.ToString("dd/MM/yyyy")} Valor do contrato: {ValorTotal.ToString("F2", CultureInfo.InvariantCulture)}");

            int i = 1;
            foreach (Parcela parcela in Parcelas)
            {
                sb.AppendLine($"Parcela {i} - {parcela.ToString()}");
                i++;
            }

            return sb.ToString();
        }

    }


}

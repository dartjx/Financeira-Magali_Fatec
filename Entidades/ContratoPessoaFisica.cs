using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Financeira
{
    class ContratoPessoaFisica : Contrato
    {
        public string   Cpf { get; protected set; }
        public int IdadeContratante { get; set; }

        public ContratoPessoaFisica()
        {

        }
        public ContratoPessoaFisica(int numero, string contratante, double valor, int prazo, string cpf, int idadeContratante)
            : base(numero,  contratante, valor, prazo)
        {
            Cpf = cpf;
            IdadeContratante = idadeContratante;
        }

        public override double CalcularPrestacao()
        {
            if (IdadeContratante <= 30) { 
                return (Valor / Prazo) + 1;
        }
            else if (IdadeContratante <= 40)
            {
                return (Valor / Prazo) + 2;
            }
            else if (IdadeContratante <= 50)
            {
                return (Valor / Prazo) + 3;
            }
            else
            {
                return (Valor / Prazo) + 3;
            }
           
        }

        public override string ExibirInfo()
        {
            return " - Número: "
                + Numero
                + "\n - Valor: $"
                + Valor.ToString("F2", CultureInfo.InvariantCulture)
                + "\n - Prazo: "
                + Prazo
                + " meses"
                + "\n - Valor Prestação: $"
                + CalcularPrestacao().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

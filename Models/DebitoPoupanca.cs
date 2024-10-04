using System;

namespace SeuProjeto.Models
{
    public class DebitoPoupanca : DebitoConta
    {
        // Debitando
        public override void Debitar(decimal valor)
        {
            // Lógica para debitar da conta poupança
            Console.WriteLine($"Débito de R${valor} realizado na Conta Poupança.");
        }

        public override string FormatarTransacao()
        {
            return "Transação de Conta Poupança";
        }
    }
}

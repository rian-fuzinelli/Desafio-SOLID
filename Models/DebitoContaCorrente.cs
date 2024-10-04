namespace SeuProjeto.Models
{
    public class DebitoContaCorrente : DebitoConta
    {
        public override void Debitar(decimal valor)
        {
            // Lógica para debitar da conta corrente
        }

        public override string FormatarTransacao()
        {
            return "Transação de Conta Corrente";
        }
    }
}
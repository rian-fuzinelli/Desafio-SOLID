using SeuProjeto.Models;

class Program
{
    static void Main(string[] args)
    {
        DebitoConta contaCorrente = new DebitoContaCorrente();
        contaCorrente.NumeroTransacao = 1;
        contaCorrente.Debitar(100);
        Console.WriteLine(contaCorrente.FormatarTransacao());

        DebitoConta contaPoupanca = new DebitoPoupanca();
        contaPoupanca.NumeroTransacao = 2;
        contaPoupanca.Debitar(200);
        Console.WriteLine(contaPoupanca.FormatarTransacao());
    }
}
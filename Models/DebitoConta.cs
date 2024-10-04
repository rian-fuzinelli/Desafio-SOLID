using System;

namespace SeuProjeto.Models
{
    public abstract class DebitoConta
    {
        public int NumeroTransacao { get; set; }
        public abstract void Debitar(decimal valor);
        public abstract string FormatarTransacao();
    }
}
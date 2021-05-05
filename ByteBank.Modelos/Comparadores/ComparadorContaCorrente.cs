using System.Collections.Generic;

namespace ByteBank.Modelos.Comparadores
{
    public class ComparadorContaCorrentePorAgencia : IComparer<ContaCorrente>
    {
        public int Compare(ContaCorrente x, ContaCorrente y)
        {
            if (x == y)
                return 0;

            if (x == null)
                return 1;

            if (y == null)
                return -1;

            return x.Agencia.CompareTo(y.Agencia);
        }
    }
}

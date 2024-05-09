using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace calculadora.services
{
    public class Calculadora
    {

        private List<object> _historico;

        public Calculadora()
        {
            _historico = new List<object>();
        }
        public int somar(int val1, int val2)
        {
            var operacao = new List<object> { "soma", val1, val2, val1 + val2 };
            _historico.Insert(0, operacao);
            return val1 + val2;
        }

        public int subtrair(int val1, int val2)
        {
            var operacao = new List<object> { "subtracao", val1, val2, val1 - val2 };
            _historico.Insert(0, operacao);
            return val1 - val2;
        }

        public int dividir(int val1, int val2)
        {
            var operacao = new List<object> { "divisao", val1, val2, val1 / val2 };
            _historico.Insert(0, operacao);
            return val1 / val2;
        }

        public int multiplicar(int val1, int val2)
        {
            var operacao = new List<object> { "multiplicacao", val1, val2, val1 * val2 };
            _historico.Insert(0, operacao);
            return val1 * val2;
        }

        public List<object> Historico()
        {
            return _historico;
        }
    }
}
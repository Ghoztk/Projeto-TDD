using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto
{
    public class Calculadora
    {
        private List<string> listahistorico;

        public Calculadora()
        {
            listahistorico = new List<string>();
        }
        
        public int somar(int num, int num2)
        {   
            int res = num + num2;
            listahistorico.Insert(0, $"Res: {res}");
            return res;
        }

        public int subtrair(int num, int num2)
        {
            int res = num - num2;
            listahistorico.Insert(0, $"Res: {res}");
            return res;
        }

        public int multiplicar(int num, int num2)
        {
            int res = num * num2;
            listahistorico.Insert(0, $"Res: {res}");
            return res;
        }

        public int dividir(int num, int num2)
        {
            int res = num / num2;
            listahistorico.Insert(0, $"Res: {res}");
            return res;
        }

        public List<string> historico()
        {
            listahistorico.RemoveRange(3, listahistorico.Count - 3);
            return listahistorico;
        }

        
    }
}
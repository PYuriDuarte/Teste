using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    public class Funcoes
    {
        public void Mostrar_Texto()
        {
            Console.WriteLine("Baidu");
        }

        public int Somar_Numeros(int valor1, int valor2)
        {
            return valor1 + valor2;
        }
        public bool Verifica_Digito(string digito1)
        {
            return int.TryParse(digito1, out int num);
        }
        public bool Verifica_Nomes(string nome1)
        {
            return nome1.Replace("\n", "").Replace("\r", "").Trim().Equals(string.Empty);
        }

    }
}

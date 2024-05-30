using System;
using System.Collections.Generic;

namespace CalculadoraClasses
{
    public class Calculadora
    {
        private List<int> Historico = new List<int>();
        public int Somar(int valor1, int valor2)
        {
            return valor1 + valor2;
        }
        public int Subtrair(int valor1, int valor2)
        {
            return valor1 - valor2;
        }
        public int Multiplicar(int valor1, int valor2)
        {
            return valor1 * valor2;
        }
        public int Dividir(int valor1, int valor2)
        {
            return valor1 / valor2;
        }
        public void AdicionarNoHistorico(int valor)
        {
            if (Historico.Count == 3)
            {
                Historico.RemoveAt(0);
            }
            Historico.Add(valor);
        }
        public List<int> MostrarHistorico()
        {
            return Historico;
        }
    }
}

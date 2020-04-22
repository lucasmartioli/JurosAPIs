using System;

namespace CalculadoraJuros.Domain
{
    public static class JurosCompostos
    {
        private static double Truncate(double value) => Math.Truncate(100 * value) / 100;
        public static double Calcular(double valorInicial, double taxaDeJuros, int tempo) => Truncate(valorInicial * Math.Pow(1 + taxaDeJuros, tempo));
    }
}

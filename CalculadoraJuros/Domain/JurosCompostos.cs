using System;

namespace CalculadoraJuros.Domain
{
    public static class JurosCompostos
    {
        public static double Calcular(double valorInicial, double taxaDeJuros, int tempo) => valorInicial * Math.Pow(1 + taxaDeJuros, tempo);

    }
}

using System;
namespace ExercicioSeis
{
	public class ConversorDeMoeda
	{
		public static double Iof = 6.0;

		public static double DolarParaReal(double quantia, double cotacao)
		{
			double conversao = quantia * cotacao;
			return conversao + conversao * Iof / 100.0;
		}
	}
}


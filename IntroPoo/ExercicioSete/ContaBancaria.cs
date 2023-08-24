﻿using System;
using System.Globalization;
namespace ExercicioSete
{
	public class ContaBancaria
	{
		public int Conta { get; private set; }
		public string Titular { get; set; }
		public double Saldo { get; private set; }

		public ContaBancaria(int numero, string titular)
		{
			Conta = numero;
			Titular = titular;
		}

		public ContaBancaria(int numero, string titular, double saldo) : this(numero, titular)
		{
			Saldo = saldo;
		}

		public void Deposito(double quantia)
		{
			Saldo += quantia;
		}

		public void Saque(double quantia)
		{
			Saldo -= quantia + 5.0;
		}

        public override string ToString()
        {
			return "Conta: " + Conta + ", Titular: " + Titular + ", Saldo: R$ " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
		}
	}
}


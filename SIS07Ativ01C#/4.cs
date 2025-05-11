/*
 * Criado por SharpDevelop.
 * Usuário: Pedro Dutra
 * Data: 08/05/2025
 * Hora: 09:32
 */
using System;

namespace project_4
{
	class Program
	{
		public static void Main(string[] args)
		{
			string temp;
			
			bool valor;
			
			Console.WriteLine("Digite [s] para Sim e [n] para Não.");
			
			temp = Console.ReadLine().ToLower();
			
			if(temp == "s" || temp == "sim" || temp == "Sim")
			{
				valor = true;
				Console.Clear();
				Console.WriteLine("SIM");
				Console.ReadKey(true);
				Console.WriteLine("Clique para finaliza...");
				Console.ReadKey(true);
			}
			
			if(temp == "n" || temp == "nao" || temp == "não")
			{
				Console.Clear();
				valor = false;
				Console.WriteLine("Não");
				Console.ReadKey(true);
				Console.WriteLine("Clique para finaliza...");
				Console.ReadKey(true);
			}
		}
	}
}

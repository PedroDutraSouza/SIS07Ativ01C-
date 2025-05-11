/*
 * Criado por SharpDevelop.
 * Usuário: Pedro Dutra
 * Data: 08/05/2025
 * Hora: 09:02
 */
using System;

namespace project_2
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Digite um número real...");
			
			double numero = Convert.ToDouble(Console.ReadLine());
			
			Console.Clear();
			
			Console.WriteLine("Clique qualquer tecla para ver o número...");
			
			Console.ReadKey(true);
			
			Console.Clear();
			
			Console.WriteLine(numero);
			                  
			Console.ReadKey(true);
			
			Console.Write("Press any key to continue . . . ");
			
			Console.ReadKey(true);
			
			Console.Clear();
			
			
		}
	}
}

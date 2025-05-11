/*
 * Criado por SharpDevelop.
 * Usuário: Pedro Dutra
 * Data: 08/05/2025
 * Hora: 09:18
 */
using System;

namespace project_3
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Digite um número real...");
			
			float numero = Convert.ToSingle(Console.ReadLine());
			
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

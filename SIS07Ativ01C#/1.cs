/*
 * Created by SharpDevelop.
 * User: Pedro Dutra
 * Date: 07/05/2025
 * Time: 09:13
 */
using System;

namespace project_1
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Aqui começamos nosso programa...
			Console.WriteLine("Digite um número inteiro: ");
			
			int numero = Convert.ToInt32(Console.ReadLine());
			
			Console.Clear();
			
			Console.WriteLine("Clique qualquer tecla para ver o número armazenado...");
			
			Console.ReadKey(true);
			
			Console.Clear();
			
			Console.WriteLine(numero);
			
			Console.WriteLine("Clique qualquer tecla para finalizar...");
			
			Console.ReadKey(true);
			
			Console.Clear();
		}
	}
}
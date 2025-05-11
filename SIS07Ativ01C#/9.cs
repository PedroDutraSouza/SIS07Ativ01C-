/*
 * Created by SharpDevelop.
 * User: Pedro Dutra
 * Date: 11/05/2025
 * Time: 17:06
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace project_09
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Digite uma frase: ");
			
			string frase = Console.ReadLine();
			
			Console.Clear();
			
			string semEspacos = frase.Replace(" ", "");
			
			int comprimento = semEspacos.Length;
			
			Console.WriteLine("A frase: " + frase + ".");
			Console.WriteLine("Possui: " + comprimento + " letras.");
			
			Console.ReadKey(true);

		}
	}
}
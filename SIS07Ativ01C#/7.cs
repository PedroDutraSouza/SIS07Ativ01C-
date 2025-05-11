/*
 * Created by SharpDevelop.
 * User: Pedro Dutra
 * Date: 11/05/2025
 * Time: 16:27
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace project_07
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Digite seu nome: ");
			
			string nome = Console.ReadLine();
			
			Console.Clear();
			
			Console.WriteLine("Digite sua idade: ");
			
			int idade = Convert.ToInt16(Console.ReadLine());
			
			Console.Clear();
			
			Console.WriteLine("Clique para exibir nome e idade...");
			
			Console.ReadKey(true);
			
			Console.Clear();
			
			Console.WriteLine("Nome: " + nome + ".");
			
			Console.WriteLine("Idade: " + idade + ".");
			
			Console.ReadKey(true);
			
			Console.Clear();
			
			Console.WriteLine("Clique para finalizar...");
			
			Console.ReadKey(true);
		}
	}
}
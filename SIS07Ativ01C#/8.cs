/*
 * Created by SharpDevelop.
 * User: Pedro Dutra
 * Date: 11/05/2025
 * Time: 16:47
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace project_08
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Digite o valor total: ");
			
			double total = Convert.ToDouble(Console.ReadLine());
			
			Console.Clear();
			
			Console.WriteLine("Quantos porcento de deconto? ");
			
			double desconto = Convert.ToDouble(Console.ReadLine());
			
			Console.Clear();
			
			double valor = total - ((total * desconto) / 100);
			
			Console.WriteLine("Valor com desconto: " + valor);
			
			Console.ReadKey(true);
			
			Console.Clear();
				
		}
	}
}
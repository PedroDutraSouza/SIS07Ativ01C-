/*
 * Criado por SharpDevelop.
 * Usuário: Pedro Dutra
 * Data: 08/05/2025
 * Hora: 10:23
 */
using System;

namespace project_6
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Pede ao usuario para que digite um caractere. 
			Console.WriteLine("Escreva um unico caractere.");
			//Cria variavel "caractere" tipo char, Converte o valor por padrão string em char.
			char caractere = Convert.ToChar(Console.ReadLine());
			
			//Limpa a tela.
			Console.Clear();
			
			//Pede para que usario prossiga para exibiçao da variavel.
			Console.Write("Clique para exibir caractere armazenado.");
			
			//"Pausa" execução e limpa a tela.
			Console.ReadKey(true);
			Console.Clear();
			
			//Exibe o valor na variavel "caractere".
			Console.WriteLine(caractere);
			
			//"Pausa" execução e limpa a tela.
			Console.ReadKey(true);
			Console.Clear();
			
			//Pede para que usario prossiga para finalização.
			Console.WriteLine("Clique para finalizar...");
			
			//"Pausa" execução e limpa a tela.
			Console.ReadKey(true);
			Console.Clear();
		}
	}
}
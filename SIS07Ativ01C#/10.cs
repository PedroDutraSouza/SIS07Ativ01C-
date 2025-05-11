/*
 * Created by SharpDevelop.
 * User: Pedro Dutra
 * Date: 11/05/2025
 * Time: 17:19
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace project_10
{
	class Program
	{
	    static void Main()
	    {
	        Console.Write("Digite o número da casa: ");
	        string numero = Console.ReadLine();
	
	        Console.Write("Digite o nome da rua: ");
	        string rua = Console.ReadLine();
	
	        Console.Write("Digite o bairro: ");
	        string bairro = Console.ReadLine();
	
	        Console.Write("Digite a cidade: ");
	        string cidade = Console.ReadLine();
	
	        Console.Write("Digite o estado: ");
	        string estado = Console.ReadLine();
	
	        Console.WriteLine("Endereço completo: Rua " + rua + " Nº: " +  numero + ", Bairro: " + bairro + ", Cidade: " + cidade + ", Estado: " + estado + ".");
	        
	        Console.ReadKey(true);
	    }
	}
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TesteAsyncAwait
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Main...");
			Executar();
			Executar();
			Console.ReadLine();
		}

		public static async void Executar()
		{
			await Task.Run(() => Tarefa(5000));
			await Task.Run(() => Tarefa(10000));
			await Task.Run(() => Tarefa(7000));

			Console.WriteLine("Executar...");
		}

		public static void Tarefa(int miliseg)
		{
			Thread.Sleep(miliseg);
			Console.WriteLine("Passaram-se " + miliseg / 1000 + " seg.");
		}
	}
}
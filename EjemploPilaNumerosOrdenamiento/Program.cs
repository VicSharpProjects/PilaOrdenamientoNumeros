using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploPilaNumerosOrdenamiento
{
	class Program
	{
		static void Main(string[] args)
		{
			Stack<int> miPila = new Stack<int>();
			Console.Write("Entrada: ");
			int valor = int.Parse(Console.ReadLine());
			for (int i = 0; i < valor; i++)
			{
				miPila.Push(Convert.ToInt32(Console.ReadLine()));
			}
			int[] vector = miPila.ToArray();
			//Ordenamiento por Seleccion
			int minimo = 0, temp;
			for (int i = 0; i < vector.Length - 1; i++)
			{
				minimo = i;
				for (int j = i + 1; j < vector.Length; j++)
				{
					if (vector[minimo] > vector[j]) minimo = j;
				}
				temp = vector[minimo];
				vector[minimo] = vector[i];
				vector[i] = temp;
			}
			//Coloco en una pila en orde descendente
			miPila.Clear();
			for (int i = 0; i < vector.Length; i++)
			{
				miPila.Push(vector[i]);
			}
			//Salida
			Console.WriteLine("\nSalida");
			for (int i = 0; i < vector.Length; i++)
			{
				Console.WriteLine(miPila.Pop());
			}
			Console.ReadKey();
		}
	}
}

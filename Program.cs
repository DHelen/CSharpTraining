using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectElena
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Elena");
			Console.WriteLine(Sum(2, 3));
			Console.ReadLine();
		}

		public static int Sum(int value1, int value2) 
		{
			return value1 + value2;
		}
	}
}

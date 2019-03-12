using System;

namespace kalkulator
{
	class program
	{
		static void Main(string[] args)
		{
			Console.Title = "Aplikasi";
			
			Console.Write("Inputkan a = ");
			int a = int.Parse(Console.Readline());
			
			Console.Write("Inputkan b = ");
			int b = Convert.ToInt32(Console.Readline());
			
			Console.Writeline("1. Penambahan");
			Console.Writeline("2. Pengurangan");
			Console.Writeline("3. Perkalian");
			Console.Writeline("4. Pembagian");
			
			Console.Write("Input Nomor Menu [1..4]: ");
			int c = int.Parse(Console.Readline());
			
			if ( c = 1 )
			{
				Console.WriteLine("Hasil Penambahan" + a + " + " + b +" = " + penambahan(a, b));
			}
			else if ( c = 2 ) 
			{
				Console.WriteLine("Hasil Pengurangan (0) - (1) = (2)", a, b, pengurangan (a, b));
			}
			else if ( c = 3) 
			{
				Console.WriteLine("Hasil Perkalian (0) * (1) = (2)", a, b, perkalian (a, b));	
			}
			else if ( c = 3 ) 
			{
				Console.WriteLine("Hasil Pembagian (0) / (1) = (2)", a, b, pembagian (a, b));
			}
			else
			{
				Console.WriteLine("Menu tidak tersedia");
			}
			
			Console.WriteLine("\nTekan Sembarang Key Untuk Keluar");
			Console.ReadKey();
			
		}
		static int penambahan (int a, int b) 
		{
			return a + b;
		}
		static int pengurangan (int a, int b) 
		{
			return a - b;
		}
		static int perkalian (int a, int b) 
		{
			return a * b;
		}
		static int pembagian (int a, int b) 
		{
			return a / b;
		}
	}
	
}
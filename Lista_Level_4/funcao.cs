
using System;

namespace Lista_Level_4
{
	
	class calculadora{
		
		public static void Leitor(){
			Console.WriteLine("Digite dois números: ");
				int num = int.Parse(Console.ReadLine());
				int num2 = int.Parse(Console.ReadLine());
		}
		public static void Menu(){
			Console.WriteLine("============ CALCULADORA ============");
			Console.WriteLine();
			Console.WriteLine("0) Sair\n1) Calcular\n2) Multiplicar\n3) Dividir\n4) Subtrair");
			
		}
		
		public static int soma(int num, int num2){
			
			return num + num2;
		}
		
		public static int multiplicar(int num, int num2){
			
			return num * num2;
		}
		
		public static int dividir(int num, int num2){
			
			return num / num2;
		}
		
		public static int subtrair(int num, int num2){
			
			return num - num2;
		}
		
	}
	
	class funcao
	{
		
		public static void Main(string[] args)
		{
			calculadora calculo = new calculadora();
			
			int sair = 1;
			
			while (sair == 1) {
				
				calculadora.Leitor();
				calculadora.Menu();
				Console.WriteLine("Digite dois números: ");
				int num = int.Parse(Console.ReadLine());
				int num2 = int.Parse(Console.ReadLine());
				
				Console.Write("Escolha uma opção: ");
				int op = int.Parse(Console.ReadLine());
				
				
				switch (op) {
					case 1:
						Console.WriteLine("A soma de {0} e {1} será: {2}", num, num2, calculadora.soma(num, num2));
						break;
					case 2:
						Console.WriteLine("A divisão de {0} e {1} será: {2}", num, num2, calculadora.dividir(num, num2));
						break;
					case 3:
						Console.WriteLine("A multiplicação de {0} e {1} será: {2}", num, num2, calculadora.multiplicar(num, num2));
						break;
					case 4:
						Console.WriteLine("A subtração de {0} e {1} será: {2}", num, num2, calculadora.subtrair(num, num2));
						break;
						
					case 0:
						sair = 0;
						break;
				}
				Console.ReadKey();
				Console.Clear();
			}

			
		}
	}
}
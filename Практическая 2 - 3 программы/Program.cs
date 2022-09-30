using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace gdg
{
	internal class Program
	{
		static void Main(string[] args)
		{
			byte x = 0;
		mu:
			Console.WriteLine("Введите номер программы:");
			Console.WriteLine("1. Игра \"Угадай число\"");
			Console.WriteLine("2. Таблица умножения");
			Console.WriteLine("3. Вывод делителей числа");
			Console.WriteLine("4. Выход");
				x = Convert.ToByte(Console.ReadLine());
			if (x < 1 || x > 4)
				Console.WriteLine("Вы ввели неподходящий номер операции, введите числа от 1 до 4");
              switch (x)
				{
					case 1:
						{
							Random r = new Random();
							Int16 a = 0;
							int b = r.Next(0, 100);
							do
							{
								Console.WriteLine("Введите число:");
								a = Convert.ToInt16(Console.ReadLine());
								Console.WriteLine("Вы ввели:{0}",a);
								if (a > b)
									Console.WriteLine("Ваше число больше загаданого");
								else if (a < b)
									Console.WriteLine("Ваше число меньше загаданого");
							}
							while (a != b);
						Console.WriteLine("Вы выиграли, числа совпадают");
						goto mu;
						break;
						}
					case 2:
						{
							Console.WriteLine("Таблица умножения:");
							int t = 10;
							int[,] m = new int[t, t];
							for (int i = 0; i < t; i++)
							{
								for (int j = 0; j < t; j++)
								{
									m[i, j] = (i) * (j);
								}
							}
							for (int i = 2; i != t; i++)
							{
								for (int j = 2; j < t; j++)
								{
									Console.Write("{0}*{1}={2}\t", j, i, $"{m[i, j]}");
								}
								Console.WriteLine();
							}
						goto mu;
						break;
						}
					case 3:
						{
							int c = 0;
							while (c == 0)
							{
								Int16 b;
								Console.WriteLine("Введите число или \"enter\" для выхода:");
								string a = Console.ReadLine();
								if (a == "enter")
									goto mu;
								else
									b = Convert.ToInt16(a);
								Console.WriteLine("числа, на которые это число может делиться без остатка: ");
								for (int i = 1; i <= b; i++)
								{
									if (b % i == 0)
									{
										Console.Write("{0}\t", i);
									}
								}
								Console.WriteLine();
							}
							break;
						}
				    case 4:
					{
						Console.WriteLine("Вы вышли из программы");
						break;
					}
			  }	
			
		}
	}
}



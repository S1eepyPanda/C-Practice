using System;
using System.Globalization;
using System.Text;
namespace Myapp
{
    internal class Program
    {
        public static void Main()
        {
            int x;
            int y;
            int z;
            int s;
            float a; float b; float c; float d;
            string Name;
            int Age;
            Console.WriteLine("Введите номер задания");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("-------------------------------------------------------");
                string method = Console.ReadLine();
                Console.WriteLine("-------------------------------------------------------");
                switch (method)
                {
                    case "1":
                        {
                            x = int.Parse(Console.ReadLine());
                            y = int.Parse(Console.ReadLine());
                            z = x + y;
                            Console.WriteLine("a={0}\nb={1}", x, y);
                            Console.WriteLine("{0}+{1}={2}", x, y, z);
                            break;
                        }
                    case "2":
                        {
                            x = int.Parse(Console.ReadLine());
                            y = int.Parse(Console.ReadLine());
                            Console.WriteLine("a={0}\nb={1}", x, y);
                            Console.WriteLine("{0}+{1}={1}+{0}");
                            break;
                        }
                    case "3":
                        {
                            x = int.Parse(Console.ReadLine());
                            y = int.Parse(Console.ReadLine());
                            z = int.Parse(Console.ReadLine());
                            s = x + y + z;
                            Console.WriteLine("a={0}\nb={1}\nc={2}\n{0}+{1}+{2}={3}", x, y, z, s);
                            break;
                        }
                    case "4":
                        {
                            a = float.Parse(Console.ReadLine());
                            b = float.Parse(Console.ReadLine());
                            c = a * b;
                            Console.WriteLine("a={0}\nb={1}\n{0:##.#}*{1:##.#}={2:##.#}", a, b, c);
                            break;
                        }
                    case "5":
                        {
                            a = float.Parse(Console.ReadLine());
                            b = float.Parse(Console.ReadLine());
                            c = a / b;
                            Console.WriteLine("a={0:###.###}\nb={1:###.###}\n{0:###.###}/{1:###.###}={2:###.###}", a, b, c);
                            break;
                        }
                    case "6":
                        {
                            a = float.Parse(Console.ReadLine());
                            b = float.Parse(Console.ReadLine());
                            c = float.Parse(Console.ReadLine());
                            Console.WriteLine("a={0}\nb={1}\nc={2}\n<{0:##.##}+{1:##.##}>+{2:##.##}-{0:##.##}+<{1:##.##}+{2:##.##}>", a, b, c);
                            break;
                        }
                    case "7":
                        {
                            Console.OutputEncoding = Encoding.Unicode;
                            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("ru-RU");
                            x = int.Parse(Console.ReadLine());
                            y = int.Parse(Console.ReadLine());
                            z = x * y;
                            Console.WriteLine("Номинал купюры = {0:C}\nКоличество купюр = {1}\nСумма денег = {2:C}", x, y, z);
                            break;
                        }
                    case "8":
                        {
                            Console.OutputEncoding = Encoding.Unicode;
                            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("ru-RU");
                            Console.Write("Введите сумму вклада = ");
                            a = float.Parse(Console.ReadLine());
                            Console.Write("Введите процент по вкладу = ");
                            b = float.Parse(Console.ReadLine());
                            b /= 100;
                            c = a * b;
                            Console.WriteLine("Через год начислят {0:C}", c);
                            break;
                        }
                    case "9":
                        {
                            Console.OutputEncoding = Encoding.Unicode;
                            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("ru-RU");
                            Console.Write("Введите сумму вклада = ");
                            a = float.Parse(Console.ReadLine());
                            Console.Write("Введите процент по вкладу = ");
                            b = float.Parse(Console.ReadLine());
                            b /= 100;
                            c = (a * b) + a;
                            Console.WriteLine("Через год начислят {0:C}", c);
                            break;
                        }
                    case "10":
                        {
                            Console.Write("Как тебя зовут? ");
                            Name = Console.ReadLine();
                            Console.Write("Сколько тебе лет? ");
                            Age = int.Parse(Console.ReadLine());
                            Age = 2009 - Age;
                            Console.WriteLine("{0}, ты родился в {1} году.", Name, Age);
                            break;
                        }
                }

            }
        }
    }
}
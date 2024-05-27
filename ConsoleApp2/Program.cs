/*
 * sbyte - 1B - -128 to 127
 * byte  - 1B - 0 to 255
 * short - 2B - -32 768 to 32 767
 * ushort - unsigned to 65 535
 * int - 4B - -2 147 483 648 to 2 147 483 647
 * uint - unsigned - 0 to 4 294 967 295
 * long - 8B -  дохуя
 * ulong - 0 to слишком дохуя
 * float - 4B 
 * double - 8B
 * enum Name:int
 * {
 * ex1=0,
 * ex2=43,
 * ex3=76,
 * }
 * int x = 3, y = 4;
Console.WriteLine("x={0} y={1}", x, y); на место параметра {0} выводится значение x и т.д.
double x math.E;
Console.WriteLine("E={0,20}", x);   (2,718...)
Console.WriteLine("E={0,10}", x);(2,718...)
\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
double x math.E;
Console.WriteLine("E={0:##.###}", x);E=2,718
Console.WriteLine("E={0:.####}", x); E=2,7183
\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
Console.WriteLine("C format:{0,14:C} \t{0:C2}, 12345.678" ||C format: 12 345,68p.           12345,68p.
\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
sting s = Console.ReadLine(); 
Console.WriteLine(s);         
\\
string s = Console.ReadLine();
int x = int.Parse(s);
Console.WriteLine(x);
OR
int x = int.Parse(Console.ReadLine()); преобразовывает строку в числовой формат int в данном примере
Console.WriteLine(x);
 */
using System.Globalization;
using System.Text;

Console.OutputEncoding = Encoding.Unicode;
Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("ru-RU");
static int Main()
{
    string method = Console.ReadLine();
    int x, y, z;
    switch (method)
    {
        case "+":
             x = int.Parse(Console.ReadLine());
             y = int.Parse(Console.ReadLine());
             z = x + y;
            Console.WriteLine(z);
            break;
        case "show":
             x = int.Parse(Console.ReadLine());
             y = int.Parse(Console.ReadLine());
            break;
    }
    return 0;
}
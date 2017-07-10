using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekBrainsStart
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите номер задачи \n 1. Задача 'Анкета' \n 2. Задача Индекс Массы Тела \n 3. Задача вычисления расстояния");
            string str = Console.ReadLine();
          ///  double counter = Convert.ToDouble(str);
            switch (str)
                {
                case "1":
                    Program.Strings();
                    break;
                case "2":
                    Program.IMT();
                    break;
                case "3":
                    Program.rasst();
                    break;
                default:
                    Console.WriteLine("Экипаж прощается с вами. Желаем приятного полета");
                    Console.ReadKey();
                    break;
                }

            //  Console.WriteLine("введите второе число");
           //        Console.WriteLine(Program.SQR(Convert.ToInt64(str)));
          //  Pause();
        }
        static void Strings()
        {
            string Fam;
            string Name;
            string SName;
            string Age;
            string Length;
            string Mass;
            Console.WriteLine("Введите фамилию");
            Fam = Console.ReadLine();
            Console.WriteLine("Введите имя");
            Name = Console.ReadLine();
            Console.WriteLine("Введите отчество");
            SName = Console.ReadLine();
            Console.WriteLine("Введите возраст");
            Age = Console.ReadLine();
            Console.WriteLine("Введите рост");
            Length = Console.ReadLine();
            Console.WriteLine("Введите вес");
            Mass = Console.ReadLine();
            string str = Fam + " " + Name + " " + SName + ", " + Age + " лет, вес - " + Mass + " кг.";
            Console.WriteLine(str);

            Console.ReadKey();
        }
        static void IMT()
        {
            Console.WriteLine("Введите рост в сантиметрах");
            string str;
            str = Console.ReadLine();
            double length = Convert.ToDouble(str);
            Console.WriteLine("Введите массу тела в килограммах");
            str = Console.ReadLine();
            double mass = Convert.ToDouble(str);
            double IMT = (mass * 100 * 100 / (length * length));
            Console.WriteLine(IMT);
                        Console.ReadKey();
        }

        static void rasst()
        {
            Console.WriteLine("Введите абсциссу первой точки");
            string str;
            str = Console.ReadLine();
            double x1 = Convert.ToDouble(str);
            Console.WriteLine("Введите ординату первой точки");
            
            str = Console.ReadLine();
            double y1 = Convert.ToDouble(str);
            Console.WriteLine("Введите абсциссу второй точки");
            
            str = Console.ReadLine();
            double x2 = Convert.ToDouble(str);
            Console.WriteLine("Введите ординату второй точки");
            
            str = Console.ReadLine();
            double y2 = Convert.ToDouble(str);
            double rasst;
            rasst = Rast(x1, y1, x2, y2);
            Console.WriteLine("Расстояние между точками равно ", "{0:F2}", rasst);
            Console.ReadKey();
        }

        static double Rast(double x1, double y1, double x2, double y2)
        {
            double d = Math.Sqrt(Math.Pow(x1 - x2,2) + Math.Pow(y1 - y2,2));
            Console.WriteLine(d);
            return d;
        }

    /*    //тупо пауза
        /// <summary>
        /// ждет нажатия клавиши
        /// </summary>
        static void Pause()
        {
            Console.ReadLine();
        }

        /// <summary>
        /// берет инт возвращает квадрат
        /// </summary>
        /// <param name="x">принимаемый инт</param>
        /// <returns>возвращает квадрат принятого инта</returns>
        static int SQR(int x)
        {
            return x * x;
        }
        static int ReadNUM(string t)
        {
            return Convert.ToInt32(t);
        }

        static int SUM(int j, int i)
        { 
            return j+i;
        }*/
    }
}

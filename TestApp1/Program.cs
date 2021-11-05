using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Разработать статический класс для работы с окружностью. Класс должен содержать 3 метода:

            метод, определяющий длину окружности по заданному радиусу;
            метод, определяющий площадь круга по заданному радиусу;
            метод, проверяющий принадлежность точки с координатами (x,y) кругу с радиусом r и координатами центра x0, y0.
            */

            Console.WriteLine("Программа расчета параметров окружности");

            Console.Write("Для расчетов введите радиус окружности R: ");
            double radOkr = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Длина окружности равна {0:f2}", Circle.Length(radOkr)); //вызов метода длины

            Console.WriteLine("Площадь круга равна {0:f2}\n", Circle.Area(radOkr)); //вызов метода площади

            Console.WriteLine("Проверка принадлежности точки к кругу");
            Console.Write("Введите координату Х центра окружности: ");
            int koordX0 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите координату Y центра окружности: ");
            int koordY0 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите координату X точки для проверки: ");
            int koordX = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите координату Y точки для проверки: ");
            int koordY = Convert.ToInt32(Console.ReadLine());

            Circle.PointInCircle(koordX, koordY, radOkr, koordX0, koordY0); //вызов метода проверки принадлежности точки

            
            Console.ReadKey();
        }


    
    public static class Circle
    {
        public static double Length(double r) //метод расчета длины
        {
            return 2 * Math.PI * r;
        }
        public static double Area(double r) //метод расчета площади
        {
            return Math.PI * Math.Pow(r, 2);
        }
        public static void PointInCircle(int x, int y, double r, int x0, int y0) //метод проверки принадлежности
        {
            if ((Math.Pow(x - x0, 2) + Math.Pow(y - y0, 2)) <= Math.Pow(r, 2))
            {
                    Console.WriteLine("\nТочка с введенными координатами принадлежит окружности");
             }
            else
            {
                    Console.WriteLine("\nТочка с введенными координатами не принадлежит окружности");
                }
        }
    
}
    }
}

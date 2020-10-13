using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCalculator
{
    class Program
    {
        
        static void Main(string[] args)
        {
            while (true)
            {
                CalculationMethod cm = new CalculationMethod();
                Console.Write("请输入两个整数：\n");
                Console.Write("第一个：");
                int number1 = int.Parse(Console.ReadLine());
                Console.Write("第二个：");
                int number2 = int.Parse(Console.ReadLine());
                Equals(number1, number2);
                Console.Write("\n");
                Console.Write("请输入运算符：\n");
                string str = Console.ReadLine();
                switch (str)
                {
                    case "+":
                        Console.Write("结果为：" + cm.Add(number1, number2));
                        break;
                    case "-":
                        Console.Write("结果为：" + cm.Subtraction(number1, number2));
                        break;
                    case "*":
                        Console.Write("结果为：" + cm.Multiplication(number1, number2));
                        break;
                    case "/":
                        Console.Write("结果为：" + cm.Division(number1, number2));
                        break;
                    case "%":
                        Console.Write("结果为：" + cm.Division(number1, number2));
                        break;
                    case "&":
                        Console.Write("结果为：" + cm.Division(number1, number2));
                        break;
                }
                Console.Write("\n");
                Console.Write("按T键退出，按其他键继续 ");
                if (Console.ReadKey().KeyChar == 'T')
                    break;
                else
                    Console.Clear();
                
            }
            Console.Read();
        }

        public static void Equals(int num1, int num2)
        {
            if (num1 == num2)
                Console.Write("输入的两个整数相等\n");
            else
                Console.Write("输入的两个整数不相等\n");
        }



    }
}

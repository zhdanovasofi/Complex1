using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Как класс с закрытыми полями, где операции реализуются как методы класса;
Комплексное число представляется парой действительных чисел (a, b), где а – действительная часть, b – мнимая часть. Реализовать класс Complex для работы с комплексными числами. Обязательно должны присутствовать операции:

- сложения add, (a, b) + (c, d) = (a + с, b + d);

- вычитания sub, (a, b) – (c, d) = (a – c, b - d);

- умножения mul, (a, b) * (c, d) = (ac – bd, ad + bc);

- деления div, (a, b) / (c, d) = (ac + bd, bc - ad) / (c2 + d2);

- сравнение equ, (a, b) = (c, d), если (a = c) и (b = d);

- сопряженное число conj, conj(a, b) = (a, -b)
*/
namespace Complex
{
    class Program
    {
        static void Main(string[] args)
        {
            Variables();
        }
        static void Variables()
        {
            ComplexNums complexNum = new ComplexNums();

            complexNum.Init();
            complexNum.Display();
            while (true) {
                Console.Write("What do you want to do next? You have a variables options: sum, sub, mul, div, equ, conj, exit. ");
                string answer = Console.ReadLine();
                switch (answer)
                {
                    case "sum":
                        Console.WriteLine(complexNum.Sum());
                        break;
                    case "sub":
                        Console.WriteLine(complexNum.Sub());
                        break;
                    case "div":
                        Console.WriteLine(complexNum.Div());
                        break;
                    case "mul":
                        Console.WriteLine(complexNum.Mul());
                        break;
                    case "equ":
                        Console.WriteLine(complexNum.Equ());
                        break;
                    case "conj":
                        Console.WriteLine(complexNum.Conj());
                        break;
                }
                if (answer == "exit")
                    break;
            }

        } 
    }
    class ComplexNums
    {
        static double a, b;
        public void Init()
        {
            Console.Write("Put in a real part:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Put in an imaginary part: ");
            b = Convert.ToDouble(Console.ReadLine());
        }
        public void Display()
        {
            Console.WriteLine("Your complex number is {0}+{1}i", a, b);
        }
        public string ToString(double realPart, double imaginaryPart)
        {
            string rslt = Convert.ToString(realPart) + "+" + Convert.ToString(imaginaryPart) + "i";
            return rslt;
        }
        public string Sum()
        {
            double c, d;
            Console.Write("Put in a real part:");
            c = Convert.ToDouble(Console.ReadLine());
            Console.Write("Put in imaginary part: ");
            d = Convert.ToDouble(Console.ReadLine());
            double realPart = a + c;
            double imaginaryPart = b + d;
            string rslt = "Sum is = " + ToString(realPart, imaginaryPart);
            return rslt;
        }
        public string Mul()
        {
            double c, d;
            Console.Write("Put in a real part:");
            c = Convert.ToDouble(Console.ReadLine());
            Console.Write("Put in an imaginary part: ");
            d = Convert.ToDouble(Console.ReadLine());
            double realPart = (a * c) - ( b * d );
            double imaginaryPart = a * d + b * c;
            string rslt = "Mul is = " + ToString(realPart, imaginaryPart);
            return rslt;
        }
        public string Sub()
        {
            double c, d;
            Console.Write("Put in a real part:");
            c = Convert.ToDouble(Console.ReadLine());
            Console.Write("Put in an imaginary part: ");
            d = Convert.ToDouble(Console.ReadLine());
            double realPart =  a - c;
            double imaginaryPart = b - d;
            string rslt = "Sub is = " + ToString(realPart, imaginaryPart);
            return rslt;
        }
        public string  Div()
        {
            double c, d;
            Console.Write("Put in a real part:");
            c = Convert.ToDouble(Console.ReadLine());
            Console.Write("Put in an imaginary part: ");
            d = Convert.ToDouble(Console.ReadLine());
            double realPart = (a * c + b * d) / (c * c + d * d);
            double imaginaryPart = (b * c - a * d) / (c * c + d * d);
            string rslt = "Div is = " + ToString(realPart, imaginaryPart);
            return rslt;
        }
        public string Equ()
        {
            double c, d;
            Console.Write("Put in a real part:");
            c = Convert.ToDouble(Console.ReadLine());
            Console.Write("Put in an imaginary part: ");
            d = Convert.ToDouble(Console.ReadLine());
            return (a == c && b == d) ? "They are equal" : "They are not equal";
        }
        public string Conj()
        {
            double c, d;
            Console.Write("Put in a real part:");
            c = Convert.ToDouble(Console.ReadLine());
            Console.Write("Put in an imaginary part: ");
            d = Convert.ToDouble(Console.ReadLine());
            return (a == c && b == -d) ? "They are conjugate" : "They are not conjugate";
        }
    }
}

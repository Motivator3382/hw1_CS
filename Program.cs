using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;

namespace basic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string str_number = Console.ReadLine();
            //int number = int.Parse(str_number);

            //if (number > 100 || number < 1)
            //{
            //    Console.WriteLine("Error.Wrong number");
            //}
            //else if (number % 5 == 0 && number % 3 == 0)
            //{
            //    Console.WriteLine("Fizz Buzz");
            //}
            //else if (number % 5 == 0)
            //{
            //    Console.WriteLine("Buzz");
            //}
            //else if (number % 3 == 0)
            //{
            //    Console.WriteLine("Fizz");
            //}
            //else if ( number > 100 || number < 1)
            //{
            //    Console.WriteLine("Error.Wrong number");
            //}
            //else
            //{
            //    Console.WriteLine(number);
            //}

            //Console.WriteLine("Type number: ");
            //string str_number = Console.ReadLine();
            //Console.WriteLine("Type % : ");
            //string str_percent = Console.ReadLine();
            //Console.WriteLine(int.Parse(str_number) * int.Parse(str_percent) / 100.0);

            //int number = 0;
            //for (int i = 4; i > 0 ; i--)
            //{
            //    string str_number_i = Console.ReadLine();
            //    number = number * 10 + int.Parse(str_number_i);
            //}
            //Console.WriteLine(number);

            //Console.Write("Введите шестизначное число: ");
            //string number = Console.ReadLine();
            //if (number.Length != 6)
            //{
            //    Console.WriteLine("Ошибка: число не шестизначное!");
            //    return;
            //}
            //Console.Write("Введите первый разряд (1-6): ");
            //int pos1 = int.Parse(Console.ReadLine());
            //Console.Write("Введите второй разряд (1-6): ");
            //int pos2 = int.Parse(Console.ReadLine());
            //char[] chars = number.ToCharArray();
            //char temp = chars[pos1 - 1];
            //chars[pos1 - 1] = chars[pos2 - 1];
            //chars[pos2 - 1] = temp;
            //string result = new string(chars);
            //Console.WriteLine("Результат: " + result);

            //string date = Console.ReadLine();
            //string str = "";
            //bool first_dot = true; bool second_dot = true;
            //int day = 0; int month = 0; int year = 0;
            //for (int i = 0; i < date.Length; i++)
            //{
            //    if (date[i] == '.')
            //    {
            //        if (first_dot)
            //        {
            //            day = int.Parse(str);
            //            first_dot = false;
            //        }
            //        else if (second_dot)
            //        {
            //            month = int.Parse(str);
            //            second_dot = false;
            //        }
            //        str = "";
            //        continue;
            //    }
            //    str += date[i];
            //}
            //year = int.Parse(str);
            //string season = "";
            //if (month == 1 || month == 2 || month == 12)
            //{
            //    season = "Winter";
            //}
            //else if (month >= 3 && month <= 5)
            //{
            //    season = "Spring";
            //}
            //else if (month >= 6 && month <= 8)
            //{
            //    season = "Summer";
            //}
            //else { season = "Autumn"; }
            //int y = year - (14 - month) / 12;
            //int x = y + y / 4 - y / 100 + y / 400;
            //int m = month + 12 * ((14 - month) / 12) - 2;
            //int d = (day + x + (31 * m) / 12) % 7;
            //string[] days = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            //string dayOfWeek = days[d];
            //Console.WriteLine($"{dayOfWeek} {season}");

            //int degree = Convert.ToInt16(Console.ReadLine());
            //char CorF = Convert.ToChar(Console.ReadLine());
            //switch (CorF)
            //{
            //    case 'C':
            //        Console.WriteLine("F " + (degree * 1.8 + 32));
            //        break;
            //    case 'F':
            //        Console.WriteLine("C " + (degree - 32) * 5 / 9.0);
            //        break;
            //    default:
            //        Console.WriteLine("Wrong format");
            //        break;
            //}

            int from = Convert.ToInt16(Console.ReadLine());
            int to = Convert.ToInt16(Console.ReadLine());
            if (from > to)
            {
                int temp = from;
                from = to;
                to = temp;
            }
            for (int i = from; i < to; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}

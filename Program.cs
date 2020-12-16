using System;
using static Laba9.Laba9;

namespace Laba9
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User(10, 2);
            Type1 obj1 = new Type1();
            Type2 obj2 = new Type2();
            Type3 obj3 = new Type3();

            user.Move += message => Console.WriteLine(message);
            user.Squeeze += OutputBlueMessage;
            user.FuncMove(12);
            user.FuncSqueeze(4);
            user.FuncMove(-7);
            user.FuncSqueeze(2);

            Console.WriteLine();

            obj1.TypeEvent += message => Console.WriteLine(message);
            obj2.TypeEvent += OutputBlueMessage;
            obj3.TypeEvent += message => Console.WriteLine(message);
            obj3.TypeEvent += OutputBlueMessage;
            obj1.LvlUp();
            obj2.LvlUp();
            obj2.LvlUp();
            obj3.LvlUp();
            obj3.LvlUp();

            Console.WriteLine("\n------------------------------------------------------\n");

            string str = "Эххх.....     Был у меня когда-то товарищ,           а оказался......    мычь..........";
            Action<string> DelegAction = message => Console.WriteLine(message); // Создание делегата по шаблону
            DelegAction("Исходная строка:\n" + str + "\n");
            Func<string, string> DelegFunc; // Создание делегата по шаблону
            DelegFunc = DeleteDots;
            str = DelegFunc(str);
            DelegFunc = ToUp;
            str = DelegFunc(str);
            DelegFunc = DeleteAllSpaces;
            str = DelegFunc(str);
            DelegFunc = AddSpaces;
            str = DelegFunc(str);
            DelegFunc = DeleteSpaces;
            str = DelegFunc(str);
            DelegAction("Строка после обработки всеми функциями: \n" + DelegFunc(str) + "\n");
        }


        public static string DeleteSpaces(string str)
        {
            string result = "";
            bool mark = false;
            foreach (char el in str)
            {
                if (el == ' ' && mark == false)
                {
                    result += el;
                    mark = true;
                }
                else if (el != ' ')
                {
                    result += el;
                    mark = false;
                }
            }
            return result;
        }
        public static string DeleteDots(string str)
        {
            string result = "";
            bool mark = false;
            foreach (char el in str)
            {
                if (el == '.' && mark == false)
                {
                    result += el;
                    mark = true;
                }
                else if (el != '.')
                {
                    result += el;
                    mark = false;
                }
            }
            return result;
        }
        public static string ToUp(string str) 
        { 
            return str.ToUpper();
        }
        public static string DeleteAllSpaces(string str)
        {
            string result = "";
            foreach (char el in str)
            {
                if (el == ' ')
                {
                    continue;
                }
                result += el;
            }
            return result;
        }
        public static string AddSpaces(string str)
        {
            string result = "";
            foreach (char el in str)
            {
                if (el == ' ')
                {
                    result += el;
                }
                result += el;
            }
            return result;
        }
    }


}

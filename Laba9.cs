using System;
using System.Collections.Generic;
using System.Text;

namespace Laba9
{
    class Laba9
    {
        public class User
        {
            public delegate void DelegMove(string message);
            public event DelegMove Move;
            public delegate void DelegSqueeze(string message);
            public event DelegSqueeze Squeeze;

            public int Placing { get; set; } // Размежение
            public int Compression { get; set; } // Сжатие
            public User(int _placing, int _compression)
            {
                Placing = _placing;
                Compression = _compression;
            }

            public void FuncMove(int x)
            {
                Placing += x;
                Move.Invoke("Размещение стало равно " + Placing); // Т.к. делегат DelMove принимает строку, то при вызове события надо её передать
            }
            public void FuncSqueeze(int y)
            {
                int save = Compression;
                Compression = y;
                Squeeze.Invoke("Коэффициент сжатия изменился с " + save + " на " + Compression);
            }
        }



        public static void OutputBlueMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue; // Устанавливаем красный цвет символов
            Console.WriteLine(message);
            Console.ResetColor(); // Сбрасываем настройки цвета
        }



        public delegate void TypeDeleg(string message);
        public class Type1
        {
            public event TypeDeleg TypeEvent;
            public int typelvl = 1;
            public void LvlUp() 
            {
                TypeEvent.Invoke($"Уровень Type1 повысился! Теперь он равен {typelvl++}");
            }
        }
        public class Type2
        {
            public event TypeDeleg TypeEvent;
            public int typelvl = 2;
            public void LvlUp()
            {
                TypeEvent.Invoke($"Уровень Type2 повысился! Теперь он равен {typelvl++}");
            }
        }
        public class Type3
        {
            public event TypeDeleg TypeEvent;
            public int typelvl = 4;
            public void LvlUp()
            {
                TypeEvent.Invoke($"Уровень Type3 повысился! Теперь он равен {typelvl++}");
            }
        }
    }
}

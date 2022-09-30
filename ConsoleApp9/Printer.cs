using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Printer
    {
        private string _printer;
        private int _price;
        private int _sheetsPerHour;
        private int _inkLevel;
        private bool _scan;

        public Printer(int inkLevel,int price,int sheersPerHour )
        {
            _inkLevel = inkLevel;
            _price = price;
            _sheetsPerHour = sheersPerHour;
        }
        public void TurnOn()
        {
            _scan = true;
            Console.WriteLine("Вы включили принтер");
            Console.WriteLine();
        }

        public void TurnOff()
        {
            _scan = false;
            Console.WriteLine("Вы выключили принтер");
        }

        public void Test()
        {
            if (_inkLevel < 0)
            {
                Console.WriteLine("В принтере нет чернил");
                Console.WriteLine();
            }
            else if (_inkLevel > 0  & _scan == true)
            {
                Console.WriteLine("Вы запустили тест") ;
                Console.WriteLine();
                Console.WriteLine("Вы потратили 10 чернил");
                _inkLevel=_inkLevel-10;
                Console.WriteLine($"Уровень чернил - {_inkLevel}");
                Console.WriteLine();
            }
            else if (_scan == false)
            {
                Console.WriteLine("Ваш принтер выключен");
            }
        }
        public void AddInk()
        {
            if (_scan == true)
            {
                Console.WriteLine("Добавьте чернила");
                Console.WriteLine();
                string a = Console.ReadLine();
                int x = int.Parse(a);
                _inkLevel = _inkLevel + x;
                if (_inkLevel < 101 & _scan == true)
                {
                    Console.WriteLine($"Уровень чернил в принтере теперь - {_inkLevel}");
                    Console.WriteLine();
                }
                else if (_inkLevel > 100)
                {
                    Console.WriteLine("Место для чернил закончилось");
                    _inkLevel = _inkLevel - x;
                }
            }
            else if( _scan == false)
            {
                Console.WriteLine("Ваш принтер выключен");
            }
        }        
        public void GetInfo()
        {
            if (_scan == true)
            {
                Console.WriteLine("Информация о принтере");
                Console.WriteLine();
                Console.WriteLine("Может сканировать файлы");
                Console.WriteLine($"Цена принтера - {_price}");
                Console.WriteLine($"Сканирует {_sheetsPerHour} листов в час");
                Console.WriteLine();
            }
            else if (_scan == false)
            {
                Console.WriteLine("Ваш принтер выключен") ;
            }
        }
    }
}

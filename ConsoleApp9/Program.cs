using ConsoleApp9;
Printer printer = new Printer(100, 10000, 50);
void Menu()
{
    Console.WriteLine("Меню");
    Console.WriteLine();
    Console.WriteLine("1. Включить принтер");
    Console.WriteLine("2. Протестить принтер");
    Console.WriteLine("3. Получить информацию о принтере");
    Console.WriteLine("4. Добавить чернила");
    Console.WriteLine("5. Выключить принтер");
    Console.WriteLine();
}
void GetMenu()
{
    string menu2 = Console.ReadLine();
    bool menu1 = int.TryParse(menu2, out var menu);
    if (menu == 1)
    {
        printer.TurnOn();
    }
    else if (menu == 2)
    {
        printer.Test();
    }
    else if (menu == 3)
    {
        printer.GetInfo();
    }
    else if (menu == 4)
    {
        printer.AddInk();
    }
    else if (menu == 5)
    {
        printer.TurnOff();
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine("Выберите меню из списка");
        Console.WriteLine();
    }
}
while (true)
{
    Menu();
    GetMenu();
}

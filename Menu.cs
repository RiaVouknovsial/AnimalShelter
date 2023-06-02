class Menu
{
    AnimalShelter shelter;

    public Menu(AnimalShelter animalShelter)
    {
        shelter = animalShelter;
    }

    public void ShowOptions()
    {
        Console.WriteLine();
        Console.WriteLine("Выберите опцию:");
        Console.WriteLine("1 - Добавить животное в приют");
        Console.WriteLine("2 - Удалить животное из приюта");
        Console.WriteLine("3 - Вывести информацию о всех животных");
        Console.WriteLine("4 - Выйти из программы");

        string option = Console.ReadLine();

        switch (option)
        {
            case "1":
                {
                    Console.WriteLine();
                    Console.WriteLine("Добавить животное в приют");
                    shelter.AddAnimal();
                    break;
                }

            case "2":
                {
                    Console.WriteLine();
                    Console.WriteLine("Удалить животное из приюта");
                    shelter.RemoveAnimal();
                    break;
                }

            case "3":
                {
                    Console.WriteLine();
                    Console.WriteLine("Вывести информацию о всех животных");
                    shelter.PrintAnimals();
                    break;
                }

            case "4":
                {
                    Console.WriteLine();
                    Console.WriteLine("Для выхода из программы нажмите Escape");
                    if (Console.ReadKey().Key == ConsoleKey.Escape)
                    {
                        Environment.Exit(0);
                    }
                    break;
                }

            default:
                {
                    Console.WriteLine();
                    Console.WriteLine("Неизвестная операция");
                    break;
                }
        }
    }
}
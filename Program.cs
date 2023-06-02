//Разработайте систему для управления животным приютом.
//В вашем приюте могут находиться различные виды животных, такие как кошки, собаки, птицы и рептилии.
//Каждое животное имеет уникальный идентификатор, кличку и возраст.

//Требования:

//Создайте интерфейс IAnimal, который содержит следующие методы:

//void MakeSound(), который будет выводить звук, издаваемый животным.
//string GetInfo(), который будет возвращать информацию о животном в виде строки.
//Создайте абстрактный класс Animal, реализующий интерфейс IAnimal.
//В этом классе определите следующие общие свойства:

//Уникальный идентификатор животного.
//Кличку животного.
//Возраст животного.
//Создайте классы Cat, Dog, Bird и Reptile, наследующиеся от класса Animal.
//Каждый из этих классов должен реализовывать методы интерфейса IAnimal в соответствии с особенностями
//соответствующего вида животного.

//Создайте класс AnimalShelter, который будет содержать список животных в приюте. Реализуйте следующие методы:

//void AddAnimal(Animal animal), для добавления животного в приют.
//void RemoveAnimal(Animal animal), для удаления животного из приюта.
//void PrintAnimals(), для вывода информации о всех животных в приюте.
//Создайте программу, которая демонстрирует работу вашей системы управления животным приютом.
//Программа должна содержать меню с возможностью добавления и удаления животных, а также просмотра информации о животных.

using System;
using System.Xml.Linq;

AnimalShelter shelter = new AnimalShelter();
Menu menu = new Menu(shelter);

while (true)
{
    menu.ShowOptions();
}

//interface IAnimal
//{
//    void MakeSound();
//    string GetInfo();
//}

//abstract class Animal:IAnimal
//{
//   public abstract  void MakeSound();
//   public abstract  string GetInfo();

//    public  string ID { get; set; }
//    public  string Name { get; set; }
//    public int Age { get; set; }

//    public string AnimalType { get; set; }
//}

//class Cat:Animal
//{
//    public override void MakeSound()
//    {
//         Console.WriteLine("Звук, издаваемый животным: мяу-мяу");
//    }
//    public override string GetInfo()
//    {
//       string value = $"ID: {ID}, Name: {Name}, Age: {Age}, AnimalType: {AnimalType}";
//        MakeSound();
//        return value;
//    }

//    public  Cat(string id, string name, int age, string animaltype)
//    {
//        ID = id;
//        Name = name;
//        Age = age;
//        AnimalType = animaltype;
//    }
//}

//class Dog : Animal
//{
//    public override void MakeSound()
//    {
//        Console.WriteLine("Звук, издаваемый животным: гав-гав");
//    }
//    public override string GetInfo()
//    {
//        string value = $"ID: {ID}, Name: {Name}, Age: {Age}, AnimalType: {AnimalType}";
//        MakeSound();
//        return value;
//    }

//    public  Dog(string id, string name, int age, string animaltype)
//    {
//        ID = id;
//        Name = name;
//        Age = age;
//        AnimalType = animaltype;
//    }
//}
//class Bird : Animal
//{
//    public override void MakeSound()
//    {
//        Console.WriteLine("Звук, издаваемый животным: чик-чирик");
//    }
//    public override string GetInfo()
//    {
        
//        string value = $"ID: {ID}, Name: {Name}, Age: {Age}, AnimalType: {AnimalType}";
//        MakeSound();
//        return value;
//    }

//    public Bird(string id, string name, int age, string animaltype)
//    {
//        ID = id;
//        Name = name;
//        Age = age;
//        AnimalType = animaltype;
//    }
//}

//class Reptile : Animal
//{
//    public override void MakeSound()
//    {
//        Console.WriteLine("Звук, издаваемый животным: шишшшшшшшшшш");
//    }
//    public override string GetInfo()
//    {
        
//        string value = $"ID: {ID}, Name: {Name}, Age: {Age}, AnimalType: {AnimalType}"; 
//        MakeSound();
//        return value;
//    }

//    public Reptile(string id, string name, int age, string animaltype)
//    {
//        ID = id;
//        Name = name;
//        Age = age;
//        AnimalType = animaltype;
//    }
//}

//class AnimalShelter
//{
//    List<Animal> animals;
//        public AnimalShelter()
//    {
//        animals = new List<Animal>();
//    }
//    public void AddAnimal()
//    {
//        Console.WriteLine("Введите данные о животном:");
//        Console.Write("AnimalType: ");
//        string animaltype = Console.ReadLine();
//        Console.Write("ID: ");
//        string id = Console.ReadLine();
//        Console.Write("Name: ");
//        string name = Console.ReadLine();
//        Console.Write("Age: ");
//        int age = int.Parse(Console.ReadLine());
        
//        Console.WriteLine("Выберите тип животного:");
//        Console.WriteLine("1 - Кот");
//        Console.WriteLine("2 - Собака");
//        Console.WriteLine("3 - Птица");
//        Console.WriteLine("4 - Рептилия");

//        string animalType = Console.ReadLine();

//        Animal animal; 

//        switch (animalType)
//        {
//            case "1":
//                animal = new Cat(id, name, age, animaltype);
//                break;

//            case "2":
//                animal = new Dog(id, name, age, animaltype);
//                break;

//            case "3":
//                animal = new Bird(id, name, age, animaltype);
//                break;

//            case "4":
//                animal = new Reptile(id, name, age, animaltype);
//                break;

//            default:
//                Console.WriteLine("Неверный тип животного");
//                return;
//        }

//        animals.Add(animal);
//        Console.WriteLine("Животное успешно добавлено в приют");     
//    }

//    public void RemoveAnimal()
//    {
//        Console.WriteLine("Введите ID животного, которое нужно удалить:");
//        string id = Console.ReadLine();

//        Animal animal = FindAnimalById(id);

//        if (animal == null)
//        {
//            Console.WriteLine("Животное с указанным ID не найдено");
//        }
//        else
//        {
//            animals.Remove(animal);
//            Console.WriteLine("Животное успешно удалено из приюта");
//        }
//     }

//    public Animal FindAnimalById(string id)
//    {
//        return animals.Find(animal => animal.ID == id);
//    }

//    public void PrintAnimals()
//    {
//        foreach (Animal animal in animals)
//        {
//            Console.WriteLine(animal.GetInfo());
//        }
//    }

//    public Animal this[int index]
//    {
//        get => animals[index];
//        set => animals[index] = value;
//    }
//}
//class Menu
//{
//    AnimalShelter shelter;

//    public Menu(AnimalShelter animalShelter)
//    {
//        shelter = animalShelter;
//    }

//    public void ShowOptions()
//    {
//        Console.WriteLine();
//        Console.WriteLine("Выберите опцию:");
//        Console.WriteLine("1 - Добавить животное в приют");
//        Console.WriteLine("2 - Удалить животное из приюта");
//        Console.WriteLine("3 - Вывести информацию о всех животных");
//        Console.WriteLine("4 - Выйти из программы");

//        string option = Console.ReadLine();

//        switch (option)
//        {
//            case "1":
//                {
//                    Console.WriteLine();
//                    Console.WriteLine("Добавить животное в приют");
//                    shelter.AddAnimal();
//                    break;
//                }

//            case "2":
//                {
//                    Console.WriteLine();
//                    Console.WriteLine("Удалить животное из приюта");
//                    shelter.RemoveAnimal();
//                    break;
//                }

//            case "3":
//                {
//                    Console.WriteLine();
//                    Console.WriteLine("Вывести информацию о всех животных");
//                    shelter.PrintAnimals();
//                    break;
//                }

//            case "4":
//                {
//                    Console.WriteLine();
//                    Console.WriteLine("Для выхода из программы нажмите Escape");
//                    if (Console.ReadKey().Key == ConsoleKey.Escape)
//                    {
//                        Environment.Exit(0);
//                    }
//                    break;
//                }

//            default:
//                {
//                    Console.WriteLine();
//                    Console.WriteLine("Неизвестная операция");
//                    break;
//                }
//        }
//    }
//}
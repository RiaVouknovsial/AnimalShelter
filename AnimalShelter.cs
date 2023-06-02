class AnimalShelter
{
    List<Animal> animals;
    public AnimalShelter()
    {
        animals = new List<Animal>();
    }
    public void AddAnimal()
    {
        Console.WriteLine("Введите данные о животном:");
        Console.Write("AnimalType: ");
        string animaltype = Console.ReadLine();
        Console.Write("ID: ");
        string id = Console.ReadLine();
        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Age: ");
        int age = int.Parse(Console.ReadLine());

        Console.WriteLine("Выберите тип животного:");
        Console.WriteLine("1 - Кот");
        Console.WriteLine("2 - Собака");
        Console.WriteLine("3 - Птица");
        Console.WriteLine("4 - Рептилия");

        string animalType = Console.ReadLine();

        Animal animal;

        switch (animalType)
        {
            case "1":
                animal = new Cat(id, name, age, animaltype);
                break;

            case "2":
                animal = new Dog(id, name, age, animaltype);
                break;

            case "3":
                animal = new Bird(id, name, age, animaltype);
                break;

            case "4":
                animal = new Reptile(id, name, age, animaltype);
                break;

            default:
                Console.WriteLine("Неверный тип животного");
                return;
        }

        animals.Add(animal);
        Console.WriteLine("Животное успешно добавлено в приют");
    }

    public void RemoveAnimal()
    {
        Console.WriteLine("Введите ID животного, которое нужно удалить:");
        string id = Console.ReadLine();

        Animal animal = FindAnimalById(id);

        if (animal == null)
        {
            Console.WriteLine("Животное с указанным ID не найдено");
        }
        else
        {
            animals.Remove(animal);
            Console.WriteLine("Животное успешно удалено из приюта");
        }
    }

    public Animal FindAnimalById(string id)
    {
        return animals.Find(animal => animal.ID == id);
    }

    public void PrintAnimals()
    {
        foreach (Animal animal in animals)
        {
            Console.WriteLine(animal.GetInfo());
        }
    }

    public Animal this[int index]
    {
        get => animals[index];
        set => animals[index] = value;
    }
}
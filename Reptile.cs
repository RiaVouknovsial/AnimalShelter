class Reptile : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Звук, издаваемый животным: шишшшшшшшшшш");
    }
    public override string GetInfo()
    {

        string value = $"ID: {ID}, Name: {Name}, Age: {Age}, AnimalType: {AnimalType}";
        MakeSound();
        return value;
    }

    public Reptile(string id, string name, int age, string animaltype)
    {
        ID = id;
        Name = name;
        Age = age;
        AnimalType = animaltype;
    }
}
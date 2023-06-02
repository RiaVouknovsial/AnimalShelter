abstract class Animal : IAnimal
{
    public abstract void MakeSound();
    public abstract string GetInfo();

    public string ID { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }

    public string AnimalType { get; set; }
}
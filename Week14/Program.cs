using System.Xml.Linq;

Console.WriteLine("Name your dog");
string myDogName = Console.ReadLine();
Dog myDog = new Dog(myDogName);

Dog neighboursDog = new Dog("Good Girl");


Console.WriteLine($"Koera nimi on {myDog.Name}");
Console.WriteLine($"Naabri koer on {neighboursDog.Name}");

myDog.Rename("Bad boy");

while (myDog.LevelOfHapiness != 5)
{
    myDog.Bark();
}

myDog.WagTail();

class Dog
{
    private string _name;
    private int _levelOfHapiness;

    public Dog(string name)
    {
        _name = name;
        _levelOfHapiness = 0;
    }

    public string Name
    {
        get { return _name; }
    }

    public int LevelOfHapiness
    {
        get { return _levelOfHapiness; }
    }

    public void Rename(string newName)
    {
        _name = newName;
        Console.WriteLine($"Koera uus nimi on {newName}");
    }

    public void Bark()
    {
        Console.WriteLine("Woof-Woof");
        _levelOfHapiness++;
    }

    public void WagTail()
    {
        Console.WriteLine("Wiggle wiggle");
    }
}
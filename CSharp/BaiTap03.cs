using System;
namespace BaiTap03;

public abstract class Animal
{
    public abstract string MakeSound();
}

public class Chicken : Animal, IEdible
{
    public override string MakeSound()
    {
        return $"Con ga gay o o o";
    }

    public string HowToEat()
    {
        return $"Chien, xao, Nuong";
    }
}

public class Tiger : Animal
{
    public override string MakeSound()
    {
        return $"Con ho gam";
    }
}

public interface IEdible
{
    string HowToEat();
}

public interface  IFruit : IEdible
{
    
}

public class Orange : IFruit
{
    public string HowToEat()
    {
        return $"Cam: Vat nuoc hoac cat";
    }
}

public class Apple : IFruit
{
    public string HowToEat()
    {
        return $"Tao: Got vo roi cat mieng";
    }
}

public static class Program
{
    public static void Run()
    {
        Animal[] listAnimals = new Animal[2];
        listAnimals[0] = new Tiger();
        listAnimals[1] = new Chicken();
        foreach (Animal animal in listAnimals)
        {
            Console.WriteLine(animal.MakeSound());
            if (animal is Chicken)
            {
                IEdible edibler = (Chicken)animal;
                Console.WriteLine(edibler.HowToEat());
            }
        }
        IFruit[] listFruits = new IFruit[2];
        listFruits[0] = new Apple();
        listFruits[1] = new Orange();
        foreach (IFruit fruit in listFruits)
        {
            Console.WriteLine(fruit.HowToEat());
        }
    }
}


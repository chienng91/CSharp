using System.Runtime.CompilerServices;

namespace CSharpp;

public class Fan
{
    public const int Slow = 1;
    public const int Medium = 2;
    public const int Fast = 3;
    
    private int speed = 1;
    private bool on = false;
    private double radius = 5;
    private string color = "Blue";

    public int Speed
    {
        get { return speed; }
        set { speed = value; }
    }

    public bool On
    {
        get { return on; }
        set { on = value; }
    }

    public double Radius
    {
        get { return radius; }
        set { radius = value; }
    }

    public string Color
    {
        get { return color; }
        set { color = value; }
    }
    public Fan()
    {
    }
    public string ToString()
    {
        if (on)
        {
            return $"Speed: {speed}, Radius: {radius}, Color: {color}, fan is on";
        }
        else
        {
            return $"Radius: {radius}, Color: {color}, fan is off";
        }
    }
    
}

class BaiTapFan
{
    public static void Run()
    {
        Fan fan1 = new Fan();
        fan1.Speed = 3;
        fan1.Radius = 10;
        fan1.Color = "yellow";
        fan1.On = true;
        
        Fan fan2 = new Fan();
        fan2.Speed = 2;
        fan2.Radius = 5;
        fan2.Color = "blue";
        fan2.On = false;
        
        Console.WriteLine(fan1.ToString());
        Console.WriteLine(fan2.ToString());
    }
}
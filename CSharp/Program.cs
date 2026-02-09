namespace CSharpp;

public class Program
{
    static void Main()
    {
        Console.WriteLine("Chon chuong trinh");
        Console.WriteLine("1. Bai tap ve Fan");
        Console.WriteLine("2.1 Bai tap ve VuKhi");
        Console.WriteLine("2.2 Bai tap ve Quai vat");
        Console.WriteLine("3.1 StopWatch");
        Console.WriteLine("3.2 StopWatch x Sapxep 100000 so");
        
        string choice = Console.ReadLine();
        switch (choice)

        {
            case "1": BaiTapFan.Run(); break;
            case "2.1": ListVK.Run(); break;
            case "2.2": ListQuaiVat.Run(); break;
            case "3.1": StopWatch2.Run(); break;
            case "3.2": StopWatch3.Run(); break;
        }
    }
}
namespace CSharpp;

public class Program
{
    private static void Main()
    {
        Console.WriteLine("Chon chuong trinh");
        Console.WriteLine("1.0. Bai tap ve Fan");
        Console.WriteLine("1.1 Hinh Chu Nhat");
        Console.WriteLine("1.2 Animal");
        Console.WriteLine("1.3 Thong tin Student");
        Console.WriteLine("2.1 Bai tap ve VuKhi");
        Console.WriteLine("2.2 Bai tap ve Quai vat");
        Console.WriteLine("3.1 StopWatch");
        Console.WriteLine("3.2 StopWatch x Sapxep 100000 so");
        Console.WriteLine("4.1 BankAccount");
        Console.WriteLine("4.2 Book");
        Console.WriteLine("5.1 Bai tap ve Animal");
        Console.WriteLine("5.2 Bai tap ve NhanVien");
        Console.WriteLine("5.3 Bai tap ve TaiKhoan");
        Console.WriteLine("6.1 Information Manager  ");
        Console.WriteLine("6.2 Interface  ");
        Console.WriteLine("6.3 BaiTap  ");
        var choice = Console.ReadLine();
        switch (choice)

        {
            case "1.0": BaiTapFan.Run(); break;
            case "1.1": HCN.Run(); break;
            case "1.2": AnimalInfo.Run(); break;
            case "1.3": StudentInfo.Run(); break;
            case "2.1": ListVK.Run(); break;
            case "2.2": ListQuaiVat.Run(); break;
            case "3.1": StopWatch2.Run(); break;
            case "3.2": StopWatch3.Run(); break;
            case "4.1": RunBankAccount.Run(); break;
            case "4.2": RunBook.Run(); break;
            case "5.1": RunAnimal.Run(); break;
            case "5.2": RunNhanVien.Run(); break;
            case "5.3": RunTaiKhoan.Run(); break;
            case  "6.1":  RunSoftware.Run(); break;
            case "6.2": BaiTap03.Program.Run(); break;
            case "6.3": RunIPlayable.Run(); break;
        }
    }
}


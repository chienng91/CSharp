using System.Runtime.CompilerServices;

namespace CSharpp;

public class BankAccount
{
    private string accountNumber;
    private double balance;
    public static string bankName = "VCB";

    public BankAccount(string accountNumber, double balance, string bankName )
    {
        this.accountNumber = accountNumber;
        this.balance = balance;
    }
    public string AccountNumber
    {
        get
        {
            return accountNumber;
        } 
    }
    public double Balance
    {
        get
        {
            return balance;
        }
    }
    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            balance += amount;
        }
    }
    public string GetInfo()
    {
        return $"So TK {accountNumber}, so du {balance}, tai ngan hang {bankName}";
    }
    public static void ChangeBankName(string NewBank)
    {
        bankName = NewBank;
    }
}
public class RunBankAccount
{
    public static void Run()
    {
        BankAccount bankAccount1 = new BankAccount("123", 100,"Vietcombank");
        BankAccount bankAccount2 = new BankAccount("114", 500,"Vietcombank");
        BankAccount.ChangeBankName("Techcombank");
        Console.WriteLine(bankAccount1.GetInfo());
        Console.WriteLine(bankAccount2.GetInfo());
    }
}
public class Book
{
    private string title;
    private string author;
    private double price;
    public Book(string title, string author, double price)
    {
        this.title = title;
        this.author = author;
        this.price = price;
    }
    public string Title
    {
        get{return title;}
    }
    public string Author
    {
        get{ return author;}
    }
    public double Price
    {
        get{return price;}
    }
}

public class RunBook
{
    public static void Run()
    {
        List<Book> listBook = new List<Book>();
        
        Book book1 = new Book("Mat Biec", "Nguyen Nhat Anh", 150000);
        listBook.Add(book1);
        Book book2 = new Book("Nha Gia Kim", "Paulo Coelho", 135000);
        listBook.Add(book2);
        while (true) //Sau khi chay xong chuong trinh se quay ve Menu
        {
        Console.WriteLine("Menu");
        Console.WriteLine("1. Add New Book");
        Console.WriteLine("2. Display All Books ");
        Console.WriteLine("3. Delete Book ");
        Console.WriteLine("4. Pay Book ");
        Console.WriteLine("0. Exit");
        string menu = Console.ReadLine();
       
            switch (menu)
        {
                case "1":
            {
                Console.WriteLine("Nhap ten sach moi");
                string title = Console.ReadLine();
                Console.WriteLine("Nhap ten tac gia");
                string author = Console.ReadLine();
                Console.WriteLine("Nhap gia tien cuon sach");
                double price = double.Parse(Console.ReadLine()); 
                Book addBook = new Book(title, author, price);
                listBook.Add(addBook);
                break;
            }
            case "2":
            {
                Console.WriteLine("Danh sach book:");
                foreach (Book book in listBook)
                {
                    Console.WriteLine($"{book.Title}, {book.Author}, {book.Price}");
                }
                break;
            }
            case "3":
            {
                Console.WriteLine("Nhap dau sach muon xoa khoi danh sach");
                string title = Console.ReadLine();
                Book bookToRemove = listBook.Find(book => book.Title == title); //Tim ten sach
                if (bookToRemove != null)
                {
                    listBook.Remove(bookToRemove);
                    Console.WriteLine("Da xoa " + title);
                }
                else
                {
                    Console.WriteLine("Khong tim thay ten sach");
                }
                break;
            }
            case "4":
            {
                Console.WriteLine("Tong tien thanh toan");
                double totalPrice = 0;
                foreach (Book book in listBook)
                {
                    totalPrice  += book.Price;
                }
                Console.WriteLine($"Total price: {totalPrice}");
                break;
            }
            case "0":
                return;
        }
            
        }
    }
}

public class TuDienAnhViet
{
    Dictionary<string, string> tuDienAnhViet = new Dictionary<string, string>();

    public TuDienAnhViet()
    {
        tuDienAnhViet.Add("Love", "Yeu");
        tuDienAnhViet.Add("Wait", "Doi");
        tuDienAnhViet.Add("Stop", "Dung Lai");
        tuDienAnhViet.Add("Money", "Tien");
    }

    public void TraTu(string keyword)
    {
        if (tuDienAnhViet.ContainsKey(keyword))
        {
            Console.WriteLine($"Nghia cua tu {keyword} la {tuDienAnhViet[keyword]}");
        }
        else
        {
            Console.WriteLine("Khong tim thay tu nay. Them vao Tu dien");
            Console.WriteLine("1. Co");
            Console.WriteLine("2. Khong");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                {
                    
                    break;
                }
            }
        }
    }
}
public class RunTuDienAnhViet
{
    public static void Run()
    {      
        TuDienAnhViet tuDien = new TuDienAnhViet();
        Console.WriteLine("Nhap tu can tim");
        string keyword =  Console.ReadLine();
        tuDien.TraTu(keyword);
    }
}

public class Student
{
    private int iD;
    private string name;
    private double score;

    public Student(int iD, string name, double score)
    {
        this.iD = iD;
        this.name = name;
        this.score = score;
    }
    List<Student> listStudent = new List<Student>();
    
}



using System;

public class HinhChuNhat
{
    public double chieuDai, chieuRong;

    public HinhChuNhat(double chieuDai, double chieuRong)
    {
        this.chieuDai = chieuDai;
        this.chieuRong = chieuRong;
    }

    public double ChuViHCN()
    {
        return (chieuDai + chieuRong) * 2;
    }

    public double DienTichHCN()
    {
        return chieuDai * chieuRong;
    }

    public string HienThi()
    {
        return "Hinh chu nhat co 2 canh: " + chieuDai + " va " + chieuRong;
    }
}
public class HCN{
    public static void Run()
    {
        Console.WriteLine("Nhap 2 canh cua HCN");
        double chieuDai = Double.Parse(Console.ReadLine());
        double chieuRong = Double.Parse(Console.ReadLine());
        HinhChuNhat HCN1 = new HinhChuNhat(chieuDai, chieuRong);
        Console.WriteLine(HCN1.HienThi());
        Console.WriteLine("Chu vi la " + HCN1.ChuViHCN());
        Console.WriteLine("Dien tich la " + HCN1.DienTichHCN());
    }
}


public abstract class Animal
{
    protected string Name { get; set; }
    protected double CanNang { get; set; }
    protected string MauLong { get; set; }
    protected string TiengKeu { get; set; }

    public Animal(string dog, string name, double canNang, string mauLong, string tiengKeu)
    {
        this.Name = name;
        this.CanNang = canNang;
        this.MauLong = mauLong;
        this.TiengKeu = tiengKeu;
    }

    public abstract void PrintInfo();
}

public class Dog : Animal
{
    public Dog(string name, double canNang, string mauLong, string tiengKeu)
        : base("Dog",name, canNang, mauLong, tiengKeu)
    {
    }

    public override void PrintInfo()
    {
        Console.WriteLine("Con " + Name + ", nang " + CanNang + " kg, Long mau " + MauLong + ", keu: " + TiengKeu) ;
    }
}

public class AnimalInfo
{
    public static void Run()
    {
        Console.WriteLine("Nhap thong tin Animal");
        Console.WriteLine("Animal thuoc giong gi");
        string name = Console.ReadLine();
        Console.WriteLine("Can nang cua no");
        double canNang = Double.Parse(Console.ReadLine());
        Console.WriteLine("Mau long cua no");
        string mauLong = Console.ReadLine();
        Console.WriteLine("tieng keu cua no");
        string tiengKeu = Console.ReadLine();
        Animal dog1 = new Dog(name, canNang, mauLong, tiengKeu);
        dog1.PrintInfo();
    }
}

public class Student
{
    public string MaSV;
    public string NameStudent;
    public static string NameSchool;
    public Student(string maSV, string nameStudent)
    {
        this.MaSV = maSV;
        this.NameStudent = nameStudent;
    }

    public void PrintInfo()
    {
        Console.WriteLine("Sinh vien " + NameStudent + ", Ma so sinh vien: " + MaSV + " ,Truong: " + NameSchool );
    }
}

public class StudentInfo
{
    public static void Run()
    {
        Console.WriteLine("Nhap ten Truong");
        Student.NameSchool = Console.ReadLine();
        Console.WriteLine("Nhap so luong hoc sinh");
        int n = int.Parse(Console.ReadLine());
        List<Student> listStudent = new List<Student>();
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Nhap thong tin hoc sinh");
            Console.WriteLine("Ma SV");
            string MaSV = Console.ReadLine();
            Console.WriteLine("Ten Hoc sinh");
            string NameStudent = Console.ReadLine();
            Student student = new Student(MaSV, NameStudent);
            listStudent.Add(student);
        }
        Console.WriteLine("Danh sach sinh vien");
        foreach (Student student in listStudent)
        {   
            student.PrintInfo();
        }
    }
}
    
using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

public class VuKhi
{
    public string Ten;
    public double SatThuong;

    public VuKhi()
    {
    }

    public VuKhi(string ten, double satThuong)
    {
        this.Ten = ten;
        this.SatThuong = satThuong;
    }


    public void AddVuKhi()
    {
        Console.WriteLine("Nhap Ten Vu Khi");
        this.Ten = Console.ReadLine();
        Console.WriteLine("Nhap Sat Thuong Khi");
        this.SatThuong = double.Parse(Console.ReadLine());
    }

    public void TanCong()
    {
        Console.WriteLine(" Vu Khi " + Ten + " gay ra " + SatThuong);
    }
}


public class ListVK
{
    public static void Run()
    {
        List<VuKhi> ListVK = new List<VuKhi>();
        for (int i = 0; i < 3; i++)
        {
            VuKhi VK = new VuKhi();
            VK.AddVuKhi();
            ListVK.Add(VK);
        }

        Console.WriteLine("Danh sach Vukhi");
        double TongSatThuong = 0;
        foreach (VuKhi VK in ListVK)
        {
            VK.TanCong();
            TongSatThuong += VK.SatThuong;
        }

        Console.WriteLine("Tong Sat Thuong: " + TongSatThuong);
    }
}


public class QuaiVat
{
    public string Ten;
    public int Mau;
    public string IDnumber;
    public QuaiVat()
    {
    }

    public QuaiVat(string ten, int mau)
    { 
        this.Ten = ten;
        this.Mau = mau;
    }
}


public class ListQuaiVat
{
    public static void Run()
    {
        Dictionary<string , QuaiVat> quaiVats = new Dictionary<string, QuaiVat>();

      Console.WriteLine("Nhap so luong quai vat");
      int n = int.Parse(Console.ReadLine());

      for (int i = 0; i < n; i++)
      {
          Console.WriteLine($"Nhap quai vat thu + {i+1}");
          Console.WriteLine($"Nhap ID Quai Vat (Vi du: Q{i+1})");
          string IDnumber = Console.ReadLine();
          Console.WriteLine("Nhap Ten Quai Vat");
          string Ten = Console.ReadLine();
          Console.WriteLine("Nhap Mau Quai Vat");
          int Mau = int.Parse(Console.ReadLine());

          QuaiVat qv = new QuaiVat(Ten, Mau);
          quaiVats.Add(IDnumber, qv);
      }

        Console.WriteLine("Nhap ID quai vat can tim");
        string IDNumer = Console.ReadLine();
      
        if (quaiVats.ContainsKey(IDNumer))
        {
            QuaiVat qv = quaiVats[IDNumer];
            Console.WriteLine(qv.Ten + " " + qv.Mau + " Mau" );
        }
        else
        {
            Console.WriteLine("Khong tim thay quai vat");
        }

    }
}


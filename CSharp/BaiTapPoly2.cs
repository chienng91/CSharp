namespace CSharpp;

public class Software
{
    public string nameSoftware { get; set; }
    public string appDeveloper { get; set; }
    public double monthlySubscriptionFee { get; set; }
    

    public Software(string NameSoftware, string AppDeveloper, double MonthlySubscriptionFee)
    {
        nameSoftware = NameSoftware;
        appDeveloper = AppDeveloper;
        monthlySubscriptionFee = MonthlySubscriptionFee;
    }
    public Software(){}
    public string InfoSoftware()
    {
        return $" Phan mem {nameSoftware}, cua {appDeveloper}, phi hang thang: {monthlySubscriptionFee}";
    }
}


public class PhanMemThietKe : Software
{
    public string version { get; set; }
    private bool isCloudSupport { get; set; }

    public string InfoSoftware()
    {
        base.InfoSoftware();
        if (isCloudSupport)
            return $"Phien ban : {version}, ho tro dam may";
        return $"Phien ban : {version}, khong ho tro dam may";
    }
}

public class CongCu : Software
{
    public string loaiMoHinh;
    public int minVram;

    public string InfoSoftware()
    {
        base.InfoSoftware();
        return $" Mo hinh loai:  {loaiMoHinh}, Vram toi thieu: {minVram}";
    }
}

public class RunSoftware
{
    public static void Run()
    {
        List<Software> listSw = new List<Software>();
        Software software1 = new Software("Photoshop", "Adobe", 300_000);
        software1.InfoSoftware();
        listSw.Add(software1);
        Software software2 = new Software("Unity", "Unity Technologies", 250_000);
        software2.InfoSoftware();
        listSw.Add(software2);
        double TongTien = 0;
        foreach (Software software in listSw)
        {
            TongTien += software.monthlySubscriptionFee;
        }
        Console.WriteLine($"TongTien: {TongTien}");
        double TongTien3Thang = TongTien * 3;
        Console.WriteLine($"Tong Tien 3 Thang: {TongTien3Thang}");
        double GiamGia3Thang = TongTien3Thang * 5/100;
        Console.WriteLine($"Giam Gia 5%: {GiamGia3Thang}");
        double TongThanhToan = TongTien3Thang - GiamGia3Thang;
        Console.WriteLine($"Tong Thanh Toan: {TongThanhToan}");
    }
}
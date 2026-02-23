using System.Globalization;

namespace CSharpp;

public class Animal
{
    public string name;

    public Animal(string name)
    {
        this.name = name;
    }

    public Animal()
    {
    }

    public virtual void Keu()
    {
        Console.WriteLine("Động vật đang kêu...");
    }
}

public class Dog : Animal
{
    public override void Keu()
    {
        Console.WriteLine("Gâu gâu!");
    }
}

public class Cat : Animal
{
    public override void Keu()
    {
        Console.WriteLine("Meo meo!");
    }
}

public class RunAnimal
{
    public static void Run()
    {
        Dog dog1 = new Dog();
        dog1.name = "Lu";
        Cat cat1 = new Cat();
        cat1.name = "Mun";
        dog1.Keu();
        cat1.Keu();
    }
}

public class NhanVien
{
    public string name;
    protected double luong = 0;

    public NhanVien(string name)
    {
        this.name = name;
    }

    public NhanVien()
    {
    }

    public virtual void TinhLuong(double luong)
    {
        this.luong = luong;
    }

    public void XuathongTin()
    {
        Console.WriteLine("Ho ten: " + name + " , luong: " + luong);
    }

    // public static string ConvertToVND<T>(T amount) where T : IConvertible
    // {
    //     decimal value = Convert.ToDecimal(amount);
    //
    //     CultureInfo culture = new CultureInfo("vi-VN");
    //     return string.Format(culture, "{0:C0}", value);
    // }
}

public class NhanVienFullTime : NhanVien
{
    public double luongCung;

    public void TinhLuong()
    {
        luong = luongCung;
    }
}

public class NhanVienPartTime : NhanVien
{
    public int soGioLam;
    public double luongTheoGio;

    public void TinhLuong()
    {
        luong = soGioLam * luongTheoGio;
    }
}

public class RunNhanVien
{
    public static void Run()
    {
        NhanVienFullTime nhanvien1 = new NhanVienFullTime();
        nhanvien1.name = "NhanVien1";
        nhanvien1.luongCung = 10_000_000;
        NhanVienPartTime nhanvien2 = new NhanVienPartTime();
        nhanvien2.name = "NhanVien2";
        nhanvien2.soGioLam = 20_000;
        nhanvien2.luongTheoGio = 50;

        nhanvien1.TinhLuong();
        nhanvien2.TinhLuong();

        nhanvien1.XuathongTin();
        nhanvien2.XuathongTin();
    }
}
public class TaiKhoan
{
    public double soDu;

    public TaiKhoan(double soDu)
    {
        this.soDu = soDu;
    }
    public TaiKhoan()
    {
    }
    public virtual void RutTien(double soTien)
    {
        soDu -= soTien;
        if (soDu >= 0 )
        {
            Console.WriteLine("Rút thành công. Số dư còn: ..." + soDu);
            return;
        }
        Console.WriteLine("Không đủ tiền");
    }
}
public class TaiKhoanVip : TaiKhoan
{
    public double soDuThauChi ;
    public TaiKhoanVip(double soDu)
    {
        this.soDu = soDu;
    }
    public override void RutTien(double soTien)
    {
        soDu -= soTien;
        if (soTien <= soDu)
        {
            Console.WriteLine("Rút thành công: " + soTien);
            Console.WriteLine("Số dư còn: " + soDu);
            return;
        }
        if (soDu < -5_000_000)
        {
            Console.WriteLine("Không đủ tiền");
            return;
        }
        soDuThauChi = 5_000_000 + soDu;
        Console.WriteLine("Rút thành công: " + soTien);
        Console.WriteLine("Số dư còn: 0");
        Console.WriteLine("Tài khoản thấu chi còn: " + soDuThauChi);
    }
}
public class TaiKhoanTietKiem : TaiKhoan
{
    public TaiKhoanTietKiem(double soDu)
    {
        this.soDu = soDu;
    }
    public int tax = 5_000;
    public override void RutTien(double soTien)
    {
        double soTienCanRut = soTien + tax;
        if (soDu <= soTienCanRut)
        {
            Console.WriteLine("Không đủ tiền");
            return;
        }
        soDu -= soTien - 5_000;
        Console.WriteLine("Rút thành công. Phí rút: 5000. Số dư còn: ..." + soDu);
    }
}
public class RunTaiKhoan
{
    public static void Run()
    {
        List<TaiKhoan> listTaiKhoan = new List<TaiKhoan>();
        TaiKhoan taiKhoanThuong = new TaiKhoan(100_000);
        TaiKhoan taiKhoanVip = new TaiKhoanVip(50_000);
        TaiKhoan taiKhoanTietKiem = new TaiKhoanTietKiem(100_000);
        
        listTaiKhoan.Add(taiKhoanThuong);
        listTaiKhoan.Add(taiKhoanTietKiem);
        listTaiKhoan.Add(taiKhoanVip);

        foreach (TaiKhoan account in listTaiKhoan)
        {
            account.RutTien(100_000);
        }
    }
}

/*



Bài 3: Quản Lý Tài Khoản Ngân Hàng
Đề bài: Ngân hàng có quy định rút tiền khác nhau cho tài khoản thường và tài khoản VIP.
Tạo class TaiKhoan:
Thuộc tính: SoDu (double).
Constructor nhận vào số dư ban đầu.
Phương thức public virtual void RutTien(double soTien):
Nếu soTien <= SoDu: Trừ tiền và in "Rút thành công. Số dư còn: ...".
Ngược lại: In "Không đủ tiền".
Tạo class TaiKhoanVip kế thừa TaiKhoan:
Override phương thức RutTien:
Cho phép rút tiền ngay cả khi số dư không đủ (Thấu chi), nhưng số tiền nợ không được quá 5 triệu (tức là SoDu không được nhỏ hơn -5,000,000).
In thông báo phù hợp.
Tạo class TaiKhoanTietKiem kế thừa TaiKhoan:
Override phương thức RutTien:
Mỗi lần rút bị trừ thêm 5,000đ phí dịch vụ. (Ví dụ rút 100k thì tài khoản bị trừ 105k).
Kiểm tra đủ tiền (tính cả phí) mới cho rút.
Trong hàm Main (Yêu cầu quan trọng):
Tạo một danh sách List<TaiKhoan>.
Thêm vào danh sách 1 TaiKhoan, 1 TaiKhoanVip, 1 TaiKhoanTietKiem.
Dùng vòng lặp foreach duyệt qua danh sách và gọi lệnh RutTien(100000) cho từng tài khoản. Quan sát cách mỗi tài khoản xử lý khác nhau dù cùng gọi một hàm.

 Tạo class cha tên là DongVat (Animal) có:
Thuộc tính: Ten (string).
Phương thức khởi tạo (Constructor) để gán tên.
Phương thức public virtual void Keu(): In ra màn hình "Động vật đang kêu...".
Tạo class con Cho (Dog) kế thừa từ DongVat:
Ghi đè (override) phương thức Keu(): In ra "Gâu gâu!".
Tạo class con Meo (Cat) kế thừa từ DongVat:
Ghi đè (override) phương thức Keu(): In ra "Meo meo!".
Trong hàm Main:
Khởi tạo một đối tượng Chó tên là "Lu".
Khởi tạo một đối tượng Mèo tên là "Mun".
Gọi hàm Keu() của cả hai đối tượng để kiểm tra kết quả.

Bài 2: Hệ Thống Tính Lương
Đề bài: Công ty cần quản lý lương của 2 loại nhân viên: Nhân viên Full-time và Nhân viên Part-time.
Tạo class cha NhanVien có:
Thuộc tính: HoTen (string).
Phương thức public virtual double TinhLuong(): Trả về 0 (mặc định).
Phương thức XuatThongTin(): In ra tên và lương.
Tạo class NhanVienFullTime kế thừa NhanVien:
Thêm thuộc tính: LuongCung (double).
Override phương thức TinhLuong(): Trả về chính LuongCung.
Tạo class NhanVienPartTime kế thừa NhanVien:
Thêm thuộc tính: SoGioLam (int) và LuongTheoGio (double).
Override phương thức TinhLuong(): Trả về SoGioLam * LuongTheoGio.
Trong hàm Main:
Tạo 1 nhân viên FullTime (Lương cứng: 10 triệu).
Tạo 1 nhân viên PartTime (Làm 20 giờ, 50k/giờ).
In thông tin và lương thực lãnh của cả hai ra màn hình.

*/
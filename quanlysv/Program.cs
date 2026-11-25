using System;
using System.Linq;
using System.Text;

public class Student
{
    public string Name { get; set; }
    public int Tuoi { get; set; }
    public string MSSV { get; set; }

    public Student()
    {
        Name = string.Empty;
        MSSV = string.Empty;
    }

    public void XuatSinhVien()
    {
        Console.WriteLine($"MSSV: {MSSV,-6} | Họ tên: {Name,-16} | Tuổi: {Tuoi}");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        Student[] students = new Student[]
        {
            new Student { Name = "Nguyen Van A", Tuoi = 20, MSSV = "SV001" },
            new Student { Name = "An Thi B",     Tuoi = 17, MSSV = "SV002" },
            new Student { Name = "Le Van C",     Tuoi = 22, MSSV = "SV003" },
            new Student { Name = "Pham Thi D",   Tuoi = 18, MSSV = "SV004" },
            new Student { Name = "Hoang Van E",  Tuoi = 24, MSSV = "SV005" }
        };

        Console.WriteLine("=== 1. TOÀN BỘ DANH SÁCH SINH VIÊN ===");
        var dsSinhVien = students.ToArray();
        foreach (var sv in dsSinhVien)
        {
            sv.XuatSinhVien();
        }

        Console.WriteLine("\n=== 2. SINH VIÊN CÓ TUỔI TỪ 15 ĐẾN 18 ===");
        var tuoi15Den18 = students.Where(s => s.Tuoi >= 15 && s.Tuoi <= 18).ToArray();
        foreach (var sv in tuoi15Den18)
        {
            sv.XuatSinhVien();
        }

        Console.WriteLine("\n=== 3. SINH VIÊN BẮT ĐẦU BẰNG CHỮ 'A' ===");
        var batDauBangA = students.Where(s => s.Name.StartsWith("A")).ToArray();
        foreach (var sv in batDauBangA)
        {
            sv.XuatSinhVien();
        }

        Console.WriteLine("\n=== 4. TỔNG TUỔI SINH VIÊN ===");
        int tongTuoi = students.Sum(s => s.Tuoi);
        Console.WriteLine($"Tổng tuổi của tất cả sinh viên là: {tongTuoi}");

        Console.WriteLine("\n=== 5. SINH VIÊN CÓ TUỔI LỚN NHẤT ===");
        int maxTuoi = students.Max(s => s.Tuoi);
        var svLonTuoiNhat = students.Where(s => s.Tuoi == maxTuoi).ToArray();
        foreach (var sv in svLonTuoiNhat)
        {
            sv.XuatSinhVien();
        }

        Console.WriteLine("\n=== 6. DANH SÁCH SẮP XẾP THEO TUỔI TĂNG DẦN ===");
        var sapXepTuoi = students.OrderBy(s => s.Tuoi).ToArray();
        foreach (var sv in sapXepTuoi)
        {
            sv.XuatSinhVien();
        }
    }
}

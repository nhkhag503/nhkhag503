using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace khnag
{
    internal class Program
    {
        static void Main(string[] args)
        {

             // Bài 1: Tính tổng giá trị của 2 số nguyên
        //     Console.Write("Nhập vào số nguyên a: ");
        //     int SoNguyenA = Convert.ToInt32(Console.ReadLine());

        //     Console.Write("Nhập vào số nguyên b: ");
        //     int SoNguyenB = Convert.ToInt32(Console.ReadLine());

        //     Console.WriteLine("Tổng giá trị của A + B là: {0}", SoNguyenA + SoNguyenB);

        //     Console.ReadLine();
    // Bài 2: Nhập vào 2 cạnh của hình chữ nhật, tính diện tích, chu vi và hiển thị kết quả ra màn hình

        //     int a, b;

        //     Console.WriteLine("Nhap canh  a: ");
        //     while (!int.TryParse(Console.ReadLine(), out a) || a <= 0)
        //     {
        //      Console.WriteLine("Vui lòng nhập một số nguyên dương cho cạnh a.");
        //     }

        //     Console.WriteLine("Nhap canh  b: ");
        //     while (!int.TryParse(Console.ReadLine(), out b) || b <= 0)
        //     {
        //        Console.WriteLine("Vui lòng nhập một số nguyên dương cho cạnh b.");
        //     }

        //     int chuvi = 2 * (a + b);
        //     int dienTich = a * b;

        //     Console.WriteLine("Chu vi = " + chuvi);
           
        //     Console.WriteLine("Dien Tich = " + dienTich);
           
        //    Console.ReadLine();
    //Bai 3 nhập vào đường kính hình tròn tính bán kính , chu vi , diện tích c# và hiển thị kết quả ra màn hình 

    //   Console.OutputEncoding = System.Text.Encoding.UTF8;

    //         // Nhập đường kính hình tròn
    //         Console.Write("Nhập vào đường kính hình tròn: ");
    //         double duongKinh;

    //         // Kiểm tra nhập liệu
    //         while (!double.TryParse(Console.ReadLine(), out duongKinh) || duongKinh <= 0)
    //         {
    //             Console.WriteLine("Vui lòng nhập một số dương cho đường kính.");
    //             Console.Write("Nhập lại đường kính hình tròn: ");
    //         }

    //         // Tính bán kính
    //         double banKinh = duongKinh / 2;

    //         // Tính chu vi
    //         double chuVi = 2 * Math.PI * banKinh;

    //         // Tính diện tích
    //         double dienTich = Math.PI * banKinh * banKinh;

    //         // Hiển thị kết quả
    //         Console.WriteLine($"Bán kính: {banKinh:F2}");
    //         Console.WriteLine($"Chu vi: {chuVi:F2}");
    //         Console.WriteLine($"Diện tích: {dienTich:F2}");

    //         Console.ReadLine();

    // Bài 4 : Nhập vào thông tin học sinh bao gồm: Họ tên, lớp, điểm trung bình HKI, điểm trung bình HKII. Tính điểm trung bình cả năm và hiển thị kết quả ra màn hình. Biết rằng điểm trung bình cả năm được tỉnh theo công thức sau: (ĐTB HKI + ĐTB HKII*2)/3
                  // khai bao
    // Khai báo biến
    //         string hoten;
    //         string lop;
    //         double diemtbHK1;
    //         double diemtbHK2;

    //  // dùng unikey 
    //         Console.OutputEncoding = Encoding.UTF8;

        
    //         Console.WriteLine("Nhập họ tên của bạn: ");
    //           hoten = Console.ReadLine();

    //         Console.WriteLine("Nhập lớp của bạn: ");  
    //           lop = Console.ReadLine();

          
    //         Console.WriteLine("Nhập điểm trung bình HK1: ");     
    //         diemtbHK1 = Convert.ToDouble(Console.ReadLine());

          
    //         Console.WriteLine("Nhập điểm trung bình HK2: ");
    //           diemtbHK2 = Convert.ToDouble(Console.ReadLine());

    // // Tính điểm trung bình cả năm
    //           double diemTrungBinhCaNam = (diemtbHK1 + diemtbHK2 * 2) / 3;

    // // Hiển thị kết quả
    //         Console.WriteLine($"Họ tên: {hoten}");
           
    //         Console.WriteLine($"Lớp: {lop}");
           
    //         Console.WriteLine($"Điểm trung bình HK1: {diemtbHK1}");
           
    //         Console.WriteLine($"Điểm trung bình HK2: {diemtbHK2}");
           
    //         Console.WriteLine($"Điểm trung bình cả năm: {diemTrungBinhCaNam:F2}"); 
            
    //         Console.ReadLine();
    


           }
        }
    }
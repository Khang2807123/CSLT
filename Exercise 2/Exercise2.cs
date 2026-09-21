using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace CSLT.SS2
{
   class exercise_1_15
   {
     enum CurrencyType
                    {
                        USD = 1, EUR, JPY, GBP
                    }
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            {
             //exercise1();
             //exercise2(); 
             //exercise3(); 
             //bt1();
             //bt2();
             //bt3();
             //bt5();
             //bt7();
            }

            static void exercise1()
            {
                Console.Write("Enter temperature in Celsius: ");
                double celsius = double.Parse(Console.ReadLine());
                double fahrenheit = (celsius * 9/5) + 32;
                double kelvin = celsius + 273.15;
                Console.WriteLine($"{celsius}°C = {fahrenheit}°F");
                Console.WriteLine($"{celsius}°C = {kelvin}K");
            }

            static void exercise2()
            {
                double radius = 25.624;
                double pi = 3.14;
                double surfaceArea = 4 * pi * Math.Pow(radius, 2);
                double volume = (4/3) * pi * Math.Pow(radius, 3);
                Console.WriteLine($"Surface Area: {surfaceArea}");
                Console.WriteLine($"Volume: {volume}");
            }

            static void exercise3()
            {
                 Console.Write("Enter the first number: ");
                 double num1 = double.Parse(Console.ReadLine());
                 Console.Write("Enter the second number: ");
                 double num2 = double.Parse(Console.ReadLine());
                 Console.WriteLine($"Addition: {num1 + num2}");
                 Console.WriteLine($"Subtraction: {num1 - num2}");
                 Console.WriteLine($"Multiplication: {num1 * num2}");
                 Console.WriteLine($"Division: {num1 / num2}");
                 Console.WriteLine($"The rest of the division is: {num1 % num2}");
            }

            static void bt1()
            {
                Console.Write("Nhập chỉ số điện cũ: ");
                decimal so_dien_cu = decimal.Parse(Console.ReadLine());
                Console.Write("Nhập chỉ số điện mới: ");
                decimal so_dien_moi = decimal.Parse(Console.ReadLine());
                decimal sdtt = so_dien_moi - so_dien_cu;

                if (sdtt <= 50)
                {
                    decimal gia = 1806 * sdtt;
                    decimal vat = gia * 0.08m;
                    decimal tong_tien = gia + vat;
                    Console.WriteLine($"Số điện tiêu thụ: {sdtt} kWh");
                    Console.WriteLine($"Tiền điện chưa thuế: {gia:#,##0} VNĐ");
                    Console.WriteLine($"Thuế VAT (8%): {vat:#,##0} VNĐ");
                    Console.WriteLine($"Tổng thanh toán: {tong_tien:#,##0} VNĐ");                   
                }
                else if (sdtt <= 100)
                {
                    decimal gia = 1806 * 50 + (sdtt-50)*1866;
                    decimal vat = gia * 0.08m;
                    decimal tong_tien = gia + vat;
                    Console.WriteLine($"Số điện tiêu thụ: {sdtt} kWh");
                    Console.WriteLine($"Tiền điện chưa thuế: {gia:#,##0} VNĐ");
                    Console.WriteLine($"Thuế VAT (8%): {vat:#,##0} VNĐ");
                    Console.WriteLine($"Tổng thanh toán: {tong_tien:#,##0} VNĐ");
                }
                else if (sdtt <= 200)
                {
                    decimal gia = 1806*50 + 50*1866 + (sdtt-100)*2167;
                    decimal vat = gia * 0.08m;
                    decimal tong_tien = gia + vat;
                    Console.WriteLine($"Số điện tiêu thụ: {sdtt} kWh");
                    Console.WriteLine($"Tiền điện chưa thuế: {gia:#,##0} VNĐ");
                    Console.WriteLine($"Thuế VAT (8%): {vat:#,##0} VNĐ");
                    Console.WriteLine($"Tổng thanh toán: {tong_tien:#,##0} VNĐ");
                }
                else if (sdtt <= 300)
                {
                    decimal gia = 1806*50 + 50*1866 + 100*2167 + (sdtt-200)*2729;
                    decimal vat = gia * 0.08m;
                    decimal tong_tien = gia + vat;
                    Console.WriteLine($"Số điện tiêu thụ: {sdtt} kWh");
                    Console.WriteLine($"Tiền điện chưa thuế: {gia:#,##0} VNĐ");
                    Console.WriteLine($"Thuế VAT (8%): {vat:#,##0} VNĐ");
                    Console.WriteLine($"Tổng thanh toán: {tong_tien:#,##0} VNĐ");
                }
                else
                {
                    decimal gia = 1806*50 + 50*1866 + 100*2167 + 100*2729 + (sdtt-300)*3050;
                    decimal vat = gia * 0.08m;
                    decimal tong_tien = gia + vat;
                    Console.WriteLine($"Số điện tiêu thụ: {sdtt} kWh");
                    Console.WriteLine($"Tiền điện chưa thuế: {gia:#,##0} VNĐ");
                    Console.WriteLine($"Thuế VAT (8%): {vat:#,##0} VNĐ");
                    Console.WriteLine($"Tổng thanh toán: {tong_tien:#,##0} VNĐ");
                }
            }

            static void bt2()
            {
                Console.Write("Hãy nhập chiều cao của bạn:");
                double height = double.Parse(Console.ReadLine());
                Console.Write("Hãy nhập cân nặng của bạn:");
                double weight = double.Parse(Console.ReadLine());
                double BMI = weight / Math.Pow(height,2);
                if (BMI < 18.5)
                {
                    double min_weight = 18.5 * Math.Pow(height,2);
                    double max_weight = 22.9 * Math.Pow(height,2);
                    Console.WriteLine($"Chỉ số BMI của bạn là: {BMI:F2}");
                    Console.WriteLine("Phân loại sức khoẻ: Gầy (Thiếu cân)");
                    Console.WriteLine($"Khuyên dùng: Cân nặng lý tưởng của bạn nên từ {min_weight:F2} kg đến {max_weight:F2} kg");
                }
                else if (BMI >= 18.5 && BMI < 23)
                {
                    double min_weight = 18.5 * Math.Pow(height,2);
                    double max_weight = 22.9 * Math.Pow(height,2);
                    Console.WriteLine($"Chỉ số BMI của bạn là: {BMI:F2}");
                    Console.WriteLine("Phân loại sức khoẻ: Bình thường (Lý tưởng)");
                    Console.WriteLine($"Khuyên dùng: Cân nặng lý tưởng của bạn nên từ {min_weight:F2} kg đến {max_weight:F2} kg");
                }
                else if (BMI >= 23 && BMI < 25)
                {
                    double min_weight = 18.5 * Math.Pow(height,2);
                    double max_weight = 22.9 * Math.Pow(height,2);
                    Console.WriteLine($"Chỉ số BMI của bạn là: {BMI:F2}");
                    Console.WriteLine("Phân loại sức khoẻ: Thừa cân (Tiền béo phì)");
                    Console.WriteLine($"Khuyên dùng: Cân nặng lý tưởng của bạn nên từ {min_weight:F2} kg đến {max_weight:F2} kg");
                }
                else
                {
                    double min_weight = 18.5 * Math.Pow(height,2);
                    double max_weight = 22.9 * Math.Pow(height,2);
                    Console.WriteLine($"Chỉ số BMI của bạn là: {BMI:F2}");
                    Console.WriteLine("Phân loại sức khoẻ: Béo phì");
                    Console.WriteLine($"Khuyên dùng: Cân nặng lý tưởng của bạn nên từ {min_weight:F2} kg đến {max_weight:F2} kg");
                }
            }

            static void bt3()
            {
                Console.Write("Hãy nhập số tiền bạn cần đổi: ");
                decimal tien = decimal.Parse(Console.ReadLine());
                decimal phi = tien * 0.005m;
                decimal tong_tien_doi = tien - phi;

                decimal ty_gia_USD = 25400m;
                decimal ty_gia_EUR = 27200m;
                decimal ty_gia_YEN = 165m;
                decimal ty_gia_GBP = 32100;

                Console.Write("Chọn ngoại tệ (1-USD, 2-EUR, 3-YEN, 4-GBP):");
                int choice = int.Parse(Console.ReadLine());
                CurrencyType loai_tien = (CurrencyType)choice;

                decimal so_tien_ngoai_te = 0;
                string ky_hieu = "";

                switch (loai_tien)
                {
                    case CurrencyType.USD:
                    so_tien_ngoai_te = tong_tien_doi/ty_gia_USD;
                    ky_hieu="USD";
                    break;
                    case CurrencyType.EUR:
                    so_tien_ngoai_te = tong_tien_doi/ty_gia_EUR;
                    ky_hieu="EUR";
                    break;
                    case CurrencyType.JPY:
                    so_tien_ngoai_te = tong_tien_doi/ty_gia_YEN;
                    ky_hieu="JPY";
                    break;
                    case CurrencyType.GBP:
                    so_tien_ngoai_te = tong_tien_doi/ty_gia_GBP;
                    ky_hieu="GBP";
                    break;
                }
                Console.WriteLine($"Phí dịch vụ: {phi:#,##0}");
                Console.WriteLine($"Số tiền VNĐ tính đổi: {tong_tien_doi:#,##0}");
                Console.WriteLine($"Số tiền {ky_hieu} nhận được:{so_tien_ngoai_te:N2} {ky_hieu}");
            }

            static void bt5()
            {
                Console.Write("Hãy nhập điểm C#: ");
                double diem1 = double.Parse(Console.ReadLine());
                Console.Write("Hãy nhập tín chỉ C#: ");
                double tc1 = double.Parse(Console.ReadLine());
                Console.Write("Hãy nhập điểm Toán rời rạc: ");
                double diem2 = double.Parse(Console.ReadLine());
                Console.Write("Hãy nhập tín chỉ Toán rời rạc: ");
                double tc2 = double.Parse(Console.ReadLine());
                Console.Write("Hãy nhập điểm Tiếng Anh: ");
                double diem3 = double.Parse(Console.ReadLine());
                Console.Write("Hãy nhập tín chỉ Tiếng Anh: ");
                double tc3 = double.Parse(Console.ReadLine());

                double diemtrungbinh = (diem1*tc1+diem2*tc2+diem3*tc3)/(tc1+tc2+tc3);
                string diemchu ="";
                double diemGPA = 0;
                string xeploai ="";

                switch (diemtrungbinh)
                {
                    case double d when d>= 8.5:
                    xeploai = "Giỏi, xuất sắc";
                    diemGPA = 4.0;
                    diemchu = "A";
                    break;
                    case double d when d >=7.0 && d<=8.4:
                    xeploai = "Khá";
                    diemGPA = 3.0;
                    diemchu = "B";
                    break;
                    case double d when d >= 5.5 && d<=6.9:
                    xeploai = "Trung bình";
                    diemGPA = 2.0;
                    diemchu = "C";
                    break;
                    case double d when d >= 4.0 && d<=5.4:
                    xeploai = "Yếu";
                    diemGPA = 1.0;
                    diemchu = "D";
                    break;
                    case double d when d < 4.0:
                    xeploai = "Kém (trượt)";
                    diemGPA = 0.0;
                    diemchu = "F";
                    break;
                }
                Console.WriteLine($"Điểm TB thang 10: {diemtrungbinh}");
                Console.WriteLine($"Điểm chữ quy đổi: {diemchu}");
                Console.WriteLine($"Điểm GPA thang 4: {diemGPA}");
                Console.WriteLine($"Xếp loại học lực: {xeploai}");
            }


            static void bt7()
            {
                Console.Write("Nhập khoảng cách di chuyển (km): ");
                double distance = double.Parse(Console.ReadLine());
                Console.Write("Nhập mức tiêu hao (l/100km): ");
                double muctieuhao = double.Parse(Console.ReadLine());
                Console.Write("Nhập giá xăng hiện tại (VNĐ/L): ");
                double petroprice = double.Parse(Console.ReadLine());
                Console.Write("Nhập số người đi: ");
                int people = int.Parse(Console.ReadLine());

                double total_liter_petro = distance/100*muctieuhao;
                double totalcost = total_liter_petro * petroprice;
                double price_per_person = Math.Ceiling(totalcost/people);

                Console.WriteLine($"Tổng nguyên liệu tiêu thụ: {total_liter_petro} Lít");
                Console.WriteLine($"Tổng chi phí xăng dầu: {totalcost:#,##0} VNĐ");
                Console.WriteLine($"Chi phí mỗi người: {price_per_person:#,##0} VNĐ");
            }
        }
   }
}

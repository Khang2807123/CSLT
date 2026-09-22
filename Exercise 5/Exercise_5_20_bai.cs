using System;
using System.Text;
using System.Globalization;
using System.Collections.Generic;


namespace bai_1_20
{
    internal class E5_bai1_bai20
    {
        //1
        static int TinhTong(int a, int b)
        {
            return a + b;
        }
        //2
        static bool KiemTraChan(int n)
        {
            if (n % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //3
        static int TimMax(int a, int b, int c)
        {
            return Math.Max(Math.Max(a,b),c);
        }
        //4
        static long TinhGiaiThua(int n)
        {
            long ans = 1;
            for (int i = 1; i<=n; i++)
            {
                ans *= i;
            }
            return ans;
        }
        //5
        static string DaoNguocChuoi(string input)
        {
            char[] chuoi = input.ToCharArray();
            Array.Reverse(chuoi);
            return new string(chuoi);
        }
        //6
        static bool KiemTraNguyenTo(int n)
        {
            for (int i = 2; i<n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        //7
        static void InFibonacci(int n)
        {
            long F0 = 0;
            long F1 = 1;
            for (int i = 1; i <= n; i++)
            {
                //011235
                long Fn = F0 + F1;
                F0 = F1;
                F1 = Fn;
            }

            Console.WriteLine(F0);
        }
        //8
        static int DemNguyenAm(string s)
        {
            string vowel = "aeiouAEIOU";
            int count = 0;
            foreach (char c in s)
            {
                if (vowel.Contains(c))
                {
                    count += 1;
                }
            }
            return count;
        }
        //9
        static double TinhLuyThua(double x, int y)
        {
            double ket_qua = 1;
            for (int i = 1; i <= y; i++)
            {
                ket_qua *= x;
            }
            return ket_qua;
        }
        //10
        static double TinhTrungBinh(int[] arr)
        {
            double dap_an = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                dap_an += arr[i];
            }
            return dap_an/arr.Length;
        }
        //11
        static bool KiemTraDoiXung(string s)
        {
            string dao_nguoc_s = DaoNguocChuoi(s);
            return dao_nguoc_s == s;

        }
        //12
        static double CelsiusToFahrenheit(double c)
        {
            double f = c * 9 / 5 + 32;
            return f;
        }
        //13
        static int TimMin(int[] arr)
        {
            int MinVal = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < MinVal)
                {
                    MinVal=arr[i];
                }
                
            }
            return MinVal;
        }
        //14
        static int TongCacChuSo(int n)
        {
            char[] Tung_so = n.ToString().ToCharArray();
            int ans = 0;
            for (int i = 0; i < Tung_so.Length; i++)
            {
                ans += Tung_so[i]-'0';
            }

            return ans;
        }
        //15
        static string XoaTrungLap(string s)
        {
            HashSet<char> DaXuatHien = new HashSet<char>();
            StringBuilder ChoVao = new StringBuilder();
            foreach(char c in s)
            {
                if (DaXuatHien.Add(c))
                {
                    ChoVao.Append(c);
                }
            }
            return ChoVao.ToString();
        }
        //16
        static void SapXepMang(int[] arr)
        {
            Array.Sort(arr);
            Console.WriteLine(string.Join(" ", arr));
        }
        //17
        static int UCLN(int a, int b)
        {
            while (b != 0)
            {
                int r = a % b;
                a = b;
                b = r;
            }
            return a;
        }
        //18
        static string DecimalToBinary(int n)
        {
            string k = " ";
            while (n != 0)
            {
                int r = n % 2;
                k = r + k;
                n /= 2;
            }

            return k;
        }
        //19
        static bool KiemTraNamNhuan(int year)
        {
            return year % 4 == 0 && year % 100 != 0 || year % 400 == 0;
        }
        //20
        static int DemSoTu(string sentence)
        {
            string[] tung_tu = sentence.Split(' ');
            return tung_tu.Length;
        }
        static void Main5(string[] args)
        {
            Console.WriteLine(XoaTrungLap("Programming"));
            InFibonacci(1);
            SapXepMang([9, 1, 6, 3]);
            Console.WriteLine(DecimalToBinary(15));
        }
    } 
}
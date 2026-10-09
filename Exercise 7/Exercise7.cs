using System;
using System.Text;
namespace CSLT_Exercise7
{
    internal class Exercise7
    {
        // 1. Nhập và in chuỗi
        static void Input_Print_String()
        {
            Console.Write("Input your string: ");
            string your_string = Console.ReadLine();
            Console.WriteLine(your_string);
        }
        // 2. Đếm độ dài chuỗi
        static int Length_String(string s)
        {
            int dem = 0;
            foreach(char c in s) dem ++;
            return dem;
        }
        // 3. Tách từng ký tự
        static void TachKyTu(string s)
        {
            int n = s.Length;
            for (int i = 0; i < n; i++)
            Console.WriteLine($"s[{i}] = '{s[i]}'");
        }
 
        // 4. In ký tự theo thứ tự ngược
        static void InNguoc(string s)
        {
            for (int i = s.Length - 1; i >= 0; i--)
                Console.Write(s[i]);
            Console.WriteLine();
        }
 
        // 5. Đếm số từ
        static int DemTu(string s)
        {
            int dem = 0;
            bool dangTrongTu = false;
            foreach (char c in s)
            {
                if (c == ' ' || c == '\t' || c == '\n')
                    dangTrongTu = false;
                else if (!dangTrongTu)
                {
                    dangTrongTu = true;
                    dem++;
                }
            }
            return dem;
        }
 
        // 6. So sánh hai chuỗi (không dùng hàm thư viện)
        static bool SoSanh(string a, string b)
        {
            if (a.Length != b.Length) return false;
            int n = a.Length;
            for (int i = 0; i < n; i++)
                if (a[i] != b[i]) return false;
            return true;
        }
 
        // Hàm phụ: kiểm tra ký tự
        static bool LaChuCai(char c) => (c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z');
        static bool LaChuSo(char c) => c >= '0' && c <= '9';
        static bool LaChuHoa(char c) => c >= 'A' && c <= 'Z';
 
        // 7. Đếm chữ cái, chữ số, ký tự đặc biệt
        static void DemLoaiKyTu(string s, out int chuCai, out int chuSo, out int dacBiet)
        {
            chuCai = chuSo = dacBiet = 0;
            foreach (char c in s)
            {   
                if (LaChuCai(c)) chuCai++;
                else if (LaChuSo(c)) chuSo++;
                else dacBiet++;
            }
        }
 
        // 8. Đếm nguyên âm và phụ âm
        static bool LaNguyenAm(char c)
        {
            switch (c)
            {
                case 'a': case 'e': case 'i': case 'o': case 'u':
                case 'A': case 'E': case 'I': case 'O': case 'U':
                    return true;
                default:
                    return false;
            }
        }
 
        static void DemNguyenAmPhuAm(string s, out int nguyenAm, out int phuAm)
        {
            nguyenAm = phuAm = 0;
            foreach (char c in s)
            {
                if (!LaChuCai(c)) continue;
                if (LaNguyenAm(c)) nguyenAm++;
                else phuAm++;
            }
        }
 
        // Hàm phụ: chuỗi con sub có khớp tại vị trí i của s không
        static bool KhopTaiViTri(string s, string sub, int i)
        {
            int m = sub.Length;
            for (int j = 0; j < m; j++)
                if (s[i + j] != sub[j]) return false;
            return true;
        }
 
        // 10. Tìm vị trí xuất hiện đầu tiên của chuỗi con (-1 nếu không có)
        static int TimViTri(string s, string sub)
        {
            int n = s.Length, m = sub.Length;
            if (m == 0) return 0;
            for (int i = 0; i <= n - m; i++)
                if (KhopTaiViTri(s, sub, i)) return i;
            return -1;
        }
 
        // 9. Kiểm tra chuỗi con có trong chuỗi không
        static bool ChuaChuoiCon(string s, string sub)
        {
            return TimViTri(s, sub) != -1;
        }
 
        // 11. Kiểm tra ký tự có phải chữ cái không, nếu có thì kiểm tra hoa/thường
        static void KiemTraKyTu(char c)
        {
            if (LaChuCai(c))
                Console.WriteLine($"'{c}' là chữ cái, dạng " + (LaChuHoa(c) ? "chữ HOA." : "chữ thường."));
            else
                Console.WriteLine($"'{c}' không phải chữ cái.");
        }
 
        // 12. Đếm số lần chuỗi con xuất hiện (không chồng lấn)
        static int DemChuoiCon(string s, string sub)
        {
            int n = s.Length, m = sub.Length;
            if (m == 0) return 0;
            int dem = 0, i = 0;
            while (i <= n - m)
            {
                if (KhopTaiViTri(s, sub, i))
                {
                    dem++;
                    i += m;
                }
                else i++;
            }
            return dem;
        }
 
        // 13. Chèn chuỗi con vào trước lần xuất hiện đầu tiên của một chuỗi
        static string ChenTruoc(string s, string chuoiChen, string mucTieu)
        {
            int pos = TimViTri(s, mucTieu);
            if (pos == -1) return s; // không tìm thấy -> giữ nguyên
            StringBuilder sb = new StringBuilder();
            int n = s.Length;
            for (int i = 0; i < n; i++)
            {
                if (i == pos) sb.Append(chuoiChen);
                sb.Append(s[i]);
            }
            return sb.ToString();
        }
 
        static void Main7(string[] args)
        {
            Console.WriteLine(Length_String("Hello everyone"));
        }
    }
}

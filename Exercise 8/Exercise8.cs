using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Bo comment mot dong de chay bai tuong ung:
        // Bai1();
        // Bai2();
        // Bai3();
        // Bai4();
        // Bai5();
        // Bai6();
        // Bai7();
        // Bai8();
        // Bai9();
        // Bai10();
        // Bai11();
        // Bai12();
        // Bai13();
        // Bai14();
        // Bai15();

        Console.WriteLine("Hay bo comment mot loi goi BaiX() trong Main de chay bai tuong ung.");
    }

    // Bai 1: Tao mot file rong
    static void Bai1()
    {
        string path = "file1.txt";
        File.Create(path).Close();
        Console.WriteLine("Tao file thanh cong!");
    }

    // Bai 2: Xoa mot file
    static void Bai2()
    {
        string path = "file1.txt";

        if (File.Exists(path))
        {
            File.Delete(path);
            Console.WriteLine("Da xoa file!");
        }
        else
        {
            Console.WriteLine("File khong ton tai!");
        }
    }

    // Bai 3: Tao file va ghi van ban
    static void Bai3()
    {
        string path = "file3.txt";
        File.WriteAllText(path, "Hello C#!");
        Console.WriteLine("Da ghi noi dung vao file!");
    }

    // Bai 4: Tao file va doc noi dung
    static void Bai4()
    {
        string path = "file4.txt";
        File.WriteAllText(path, "Xin chao!\nToi dang hoc C#.");
        string content = File.ReadAllText(path);
        Console.WriteLine(content);
    }

    // Bai 5: Ghi mang chuoi vao file
    static void Bai5()
    {
        string path = "file5.txt";
        string[] names = { "An", "Binh", "Cuong", "Dung" };
        File.WriteAllLines(path, names);
        Console.WriteLine("Da ghi mang chuoi vao file!");
    }

    // Bai 6: Ghi them van ban vao file
    static void Bai6()
    {
        string path = "file6.txt";
        File.WriteAllText(path, "Dong thu nhat\n");
        File.AppendAllText(path, "Dong thu hai\n");
        Console.WriteLine(File.ReadAllText(path));
    }

    // Bai 7: Tao file, sao chep sang ten khac va in noi dung
    static void Bai7()
    {
        string source = "file7.txt";
        string destination = "file7_copy.txt";

        File.WriteAllText(source, "Day la noi dung cua file.");
        File.Copy(source, destination, true);

        string content = File.ReadAllText(destination);
        Console.WriteLine(content);
    }

    // Bai 8: Doi ten file trong cung thu muc
    static void Bai8()
    {
        string oldName = "file8.txt";
        string newName = "file8_new.txt";

        File.WriteAllText(oldName, "Noi dung file.");
        if (File.Exists(newName))
        {
            File.Delete(newName);
        }

        File.Move(oldName, newName);
        Console.WriteLine("Da doi ten file!");
    }

    // Bai 9: Doc dong dau tien cua file
    static void Bai9()
    {
        string path = "file9.txt";
        File.WriteAllText(path, "Dong 1\nDong 2\nDong 3");

        string[] lines = File.ReadAllLines(path);

        if (lines.Length > 0)
        {
            Console.WriteLine(lines[0]);
        }
    }

    // Bai 10: Doc dong cuoi cung cua file
    static void Bai10()
    {
        string path = "file10.txt";
        File.WriteAllText(path, "Dong 1\nDong 2\nDong 3");

        string[] lines = File.ReadAllLines(path);

        if (lines.Length > 0)
        {
            Console.WriteLine(lines[lines.Length - 1]);
        }
    }

    // Bai 11: Doc n dong cuoi cung cua file
    static void Bai11()
    {
        string path = "file11.txt";
        File.WriteAllText(path, "Dong 1\nDong 2\nDong 3\nDong 4\nDong 5");

        string[] lines = File.ReadAllLines(path);

        Console.Write("Nhap n: ");
        int n = int.Parse(Console.ReadLine());

        if (n > lines.Length)
        {
            n = lines.Length;
        }

        if (n > 0)
        {
            for (int i = lines.Length - n; i < lines.Length; i++)
            {
                Console.WriteLine(lines[i]);
            }
        }
    }

    // Bai 12: Doc mot dong cu the
    static void Bai12()
    {
        string path = "file12.txt";
        File.WriteAllText(path, "Dong 1\nDong 2\nDong 3");

        string[] lines = File.ReadAllLines(path);

        Console.Write("Nhap dong can doc (bat dau tu 1): ");
        int n = int.Parse(Console.ReadLine());

        if (n >= 1 && n <= lines.Length)
        {
            Console.WriteLine(lines[n - 1]);
        }
        else
        {
            Console.WriteLine("So dong khong hop le!");
        }
    }

    // Bai 13: Dem so dong trong file
    static void Bai13()
    {
        string path = "file13.txt";
        File.WriteAllText(path, "Dong 1\nDong 2\nDong 3");

        string[] lines = File.ReadAllLines(path);
        Console.WriteLine("So dong trong file: " + lines.Length);
    }

    // Bai 14: In cau truc thu muc, bao gom cac file
    static void InThuMuc(string path, int level)
    {
        string[] files = Directory.GetFiles(path);

        foreach (string file in files)
        {
            Console.WriteLine(new string(' ', level * 4) + Path.GetFileName(file));
        }

        string[] folders = Directory.GetDirectories(path);

        foreach (string folder in folders)
        {
            Console.WriteLine(new string(' ', level * 4) + Path.GetFileName(folder) + "/");
            InThuMuc(folder, level + 1);
        }
    }

    static void Bai14()
    {
        Console.Write("Nhap duong dan thu muc: ");
        string path = Console.ReadLine();

        if (Directory.Exists(path))
        {
            Console.WriteLine(Path.GetFileName(path) + "/");
            InThuMuc(path, 1);
        }
        else
        {
            Console.WriteLine("Thu muc khong ton tai!");
        }
    }

    // Bai 15: Thong ke so lan xuat hien cua chu cai va chu so
    static void Bai15()
    {
        string path = "file15.txt";
        File.WriteAllText(path, "Hello C# 123\nHello 456");

        string[] lines = File.ReadAllLines(path);

        // Tim do dai dong lon nhat
        int maxLength = 0;

        for (int i = 0; i < lines.Length; i++)
        {
            if (lines[i].Length > maxLength)
            {
                maxLength = lines[i].Length;
            }
        }

        // Tao mang hai chieu va dua noi dung file vao mang
        char[,] a = new char[lines.Length, maxLength];

        for (int i = 0; i < lines.Length; i++)
        {
            for (int j = 0; j < lines[i].Length; j++)
            {
                a[i, j] = lines[i][j];
            }
        }

        int[] letters = new int[26];
        int[] digits = new int[10];

        for (int i = 0; i < lines.Length; i++)
        {
            for (int j = 0; j < lines[i].Length; j++)
            {
                char c = a[i, j];

                if (c >= 'A' && c <= 'Z')
                {
                    c = (char)(c + 32);
                }

                if (c >= 'a' && c <= 'z')
                {
                    letters[c - 'a']++;
                }
                else if (c >= '0' && c <= '9')
                {
                    digits[c - '0']++;
                }
            }
        }

        Console.WriteLine("Thong ke chu cai:");
        for (int i = 0; i < 26; i++)
        {
            if (letters[i] > 0)
            {
                Console.WriteLine((char)('a' + i) + ": " + letters[i]);
            }
        }

        Console.WriteLine("Thong ke chu so:");
        for (int i = 0; i < 10; i++)
        {
            if (digits[i] > 0)
            {
                Console.WriteLine(i + ": " + digits[i]);
            }
        }
    }
}

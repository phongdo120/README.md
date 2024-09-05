using System;

class Baitap
{
    // Bai 1
    public void Tongmang()
    {
        Console.Write("Nhap so luong phan tu cua mang: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        int sum = 0;

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhap pha tu thu {i + 1}: ");
            arr[i] = int.Parse(Console.ReadLine());
            sum += arr[i];
        }

        Console.WriteLine("Tong cac phan tu cua mang la: " + sum);
    }
    // Bai 2
    public void Demkitu()
    {
        Console.Write("Nhap mot chuoi: ");
        string input = Console.ReadLine();
        int count = 0;

        foreach (char c in input)
        {
            if (!char.IsWhiteSpace(c) && !char.IsPunctuation(c))
            {
                count++;
            }
        }

        Console.WriteLine("So luong ki tu khoong phai khoang trang va dau cau la: " + count);
    }

    // Bai 3
    public void Phantulonhat()
    {
        Console.Write("Nhap so luong phan tu cho mang: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhap phan tu thu {i + 1}: ");
            arr[i] = int.Parse(Console.ReadLine());
        }

        int max = arr[0];
        for (int i = 1; i < n; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }
        }

        Console.WriteLine("Phan tu lon nhat cu mang la: " + max);
    }
    //Bai 4
    public void Daonguocchuoi()
    {
        Console.Write("Nhap 1 chuoi : ");
        string input = Console.ReadLine();
        char[] arr = input.ToCharArray();
        Array.Reverse(arr);
        string chuoi = new string(arr);

        Console.WriteLine("chuoi sau khi dao nguoc la: " + chuoi);
    }

    // Bai 5
    public void Kiemtradx()
    {
        Console.Write("Nhap so luong phan tu cho mang: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhap phan tu thu {i + 1}: ");
            arr[i] = int.Parse(Console.ReadLine());
        }

        bool kt = true;
        for (int i = 0; i < n / 2; i++)
        {
            if (arr[i] != arr[n - i - 1])
            {
                kt = false;
                break;
            }
        }

        if (kt)
        {
            Console.WriteLine("Mang la mang doi xung.");
        }
        else
        {
            Console.WriteLine("Mang la mang khong doi xung.");
        }
    }

    // Bai 6
    public void Demkitutrongchuoi()
    {
        Console.Write("Nhap 1 chuoi: ");
        string input = Console.ReadLine();
        Console.Write("Nhap ki tu can dem: ");
        char ch = char.Parse(Console.ReadLine());
        int count = 0;

        foreach (char c in input)
        {
            if (c == ch)
            {
                count++;
            }
        }

        Console.WriteLine($"Ky tu '{ch}' xuat hien {count} lan trong chuoi.");
    }

    // Hàm Main để gọi các phương thức
    static void Main(string[] args)
    {
       Baitap baitap = new Baitap();

        baitap.Tongmang();
        Console.WriteLine("-----------------------------------");
        baitap.Demkitu();
        Console.WriteLine("-----------------------------------");
        baitap.Phantulonhat();
        Console.WriteLine("-----------------------------------");
        baitap.Daonguocchuoi();
        Console.WriteLine("-----------------------------------");
        baitap.Kiemtradx();
        Console.WriteLine("-----------------------------------");
        baitap.Demkitutrongchuoi();
    }
}

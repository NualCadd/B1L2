
using System;
using System.Collections;

class Program
{
    static void XuatMang(ArrayList M)
    {
        string chuoi = string.Join(", ", M.ToArray());
        Console.WriteLine(chuoi);
    }

    static void Main(string[] args)
    {
        ArrayList al = new ArrayList();
        string n;
        do
        {
            Console.Write("Nhap chuoi: ");
            n = Console.ReadLine();

            if (n == "stop")
                break;

            al.Add(n);

        } while (true);

        Console.WriteLine("Danh sach ban dau:");
        XuatMang(al);

        Console.WriteLine("So phan tu hien co: {0}", al.Count);

        Console.Write("\nNhap gia tri phan tu can tim: ");
        string x = Console.ReadLine();

        int vitri = al.IndexOf(x);

        if (vitri >= 0)
        {
            Console.WriteLine("Tim thay tai vi tri: {0}", vitri);

            Console.Write("Xoa phan tu (y/n): ");
            string ch = Console.ReadLine();

            if (ch.ToUpper() == "Y")
            {
                al.RemoveAt(vitri);

                Console.WriteLine("Mang sau khi xoa:");
                XuatMang(al);
            }
        }
        else
        {
            Console.WriteLine("Khong tim thay");
        }

        Console.WriteLine("Nhap vi tri muon them phan tu moi va ten phan tu: ");
        int index = int.Parse(Console.ReadLine());
        while(index < 0 || index > al.Count)
        {
            Console.WriteLine("Vi tri khong hop le. Vui long nhap lai: ");
            index = int.Parse(Console.ReadLine());
        }
        string hanghoa = Console.ReadLine();
        al.Insert(index, hanghoa);
        XuatMang(al);
    }
}

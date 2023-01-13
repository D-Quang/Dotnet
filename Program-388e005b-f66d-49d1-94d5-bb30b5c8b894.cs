using System;

namespace array3{
    class Program17{
        static void Nhap(int[] a, int n){
            for(int i=0; i<n; i++){
                Console.Write("a["+ i + "]= ");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        static void Xuat(int[] a, int n){
            Console.Write("Danh sach mang: ");
            for(int i=0; i<n; i++){
                Console.Write(a[i] + " ");
            }
        }

        static void InPtuChiaHet(int[] a, int n){
            for(int i=0; i<n; i++){
                if(a[i]%3==0){
                     Console.Write(a[i] + " ");
                }
            }

        }

       static void Kiemtra(int[] a, int n, int x){
        int count = 0;
        for (int i = 0; i < n; i++){
            if (a[i] == x){
                count++;
            }
        }
        if(count!=0){
            Console.WriteLine("Co trong mang");
        }
        else
        {
            Console.WriteLine("Khong co trong mang");
        }
        }

        static void countNum(int[] a,int n,int y){
            int count=0;
            for(int i = 0; i <n; i++){
                if(a[i]==y){
                    count++;
                }
            }
            Console.WriteLine("co {0} phan tu {1} xuat hien trong mang",count,y);
        }

      

        static void Main(String[] args){
            Console.WriteLine("Nhap 10 phan tu cua mang: ");
            int n=10;
            int[] a = new int[100];
            Nhap(a,n);
            Xuat(a,n);

            Console.WriteLine("Bai 2:");
            Console.WriteLine("\nSo phan tu chia het cho 3: ");
            InPtuChiaHet(a,n);

            Console.WriteLine("Bai 3: ");
            int x;
            Console.WriteLine("Nhap x: ");
            x = Convert.ToInt32(Console.ReadLine());
            Kiemtra(a,n,x);

            Console.WriteLine("Bai 4: ");
            int y;
            Console.WriteLine("Nhap y: ");
            y =Convert.ToInt32(Console.ReadLine());
            countNum(a,n,y);


           

            

        }
    }
}
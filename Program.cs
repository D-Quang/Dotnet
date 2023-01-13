using System;

namespace test {
    class Program {
       static void DuongTron()
        {
            double r,d,s;
            double PI = 3.14;
            Console.Write("Nhap ban kinh duong tron: ");
            r = Convert.ToDouble(Console.ReadLine());
            d= 2 * PI * r;
            Console.WriteLine("\nChu vi duong tron la: {0}", d);
            s = PI * r * r;
            Console.WriteLine("Dien tich duong tron la: {0}", s);
            Console.Read();  
        }

        static void SoSanh(){
            int a,b,c;
            int max;
            Console.Write("nhap a: ");
            a= Convert.ToInt32(Console.ReadLine());
            Console.Write("\nnhap b: ");
            b= Convert.ToInt32(Console.ReadLine());
            Console.Write("\nnhap c: ");
            c=Convert.ToInt32(Console.ReadLine());
            max= a>b? (a>c? a:c):(b>c? b:c);
            Console.Write("\nso lon nhat la: ",max);
        }

         static void SinhVien(){
            string name,date;
            int id;
            Console.Write("nhap ten sinh vien: ");
            name= Convert.ToString(Console.ReadLine());
            Console.Write("\nnhap ngay sinh: ");
            date= Convert.ToString(Console.ReadLine());
            Console.Write("\nnhap ma sinh vien: ");
            id= Convert.ToInt32(Console.ReadLine());
            ConsoleColor foreground = Console.ForegroundColor;  

            Console.ForegroundColor = ConsoleColor.White;  
            Console.WriteLine("Ho va ten: {0}", name);
            Console.WriteLine("Ngay sinh: {0}",date);
            Console.Write("Ma sinh vien:"+ id);
        }
        // bai vd tuan 2
        static void In(){
            int n=10,m= 30;
            for(int i=0;i<n;i++){
                for(int j=0;j<m;j++){
                    if((i==0 || i==n-1)||(j==0 || j==m-1)){
                        ConsoleColor foreground = Console.ForegroundColor;  
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("= ");
                    }else{
                         ConsoleColor foreground = Console.ForegroundColor;  
                         Console.ForegroundColor= ConsoleColor.Yellow;
                         Console.Write("* ");
                    }
                    //Console.Write("\n\n");
                }
                Console.Write("\n");
            }
        }
        static void NamAm(){
                int year,a,b;
                string [] can = new string[]  { "Canh", "Tan", "Nham", "Quy", "Giap", "At", "Binh", "Dinh", "Mau", "Ky" };
                string[] chi = new string[] { "Than", "Dau", "Tuat", "Hoi", "Ty", "Suu", "Dan", "Mao", "Thin", "Ty", "Ngo", "Mui" };
                Console.Write("nhap nam duong: ");
                year = Convert.ToInt32(Console.ReadLine());
                a= year % 10;
                b= year %12;
                Console.Write("\nnam am la: {0} {1}",can[a],chi[b]);


            }
        static void Main(string[] args) {
            /*Console.Write("Bai 1:\n");
            SoSanh();
            Console.Write("\nBai 2:\n");
            DuongTron();
            Console.Write("\nBai 3:\n");
            SinhVien();*/
            // Console.BackgroundColor = ConsoleColor.Black;
            //In();
            NamAm();
        }
    }
}
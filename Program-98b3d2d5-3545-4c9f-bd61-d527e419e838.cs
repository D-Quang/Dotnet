class Lop{
        private string tenLop;
        private int soHs;
        public Lop(){

        }
        public Lop(string Name,int shs){
            this.tenLop = Name;
            this.soHs = shs;
        }
         public void print(){
             Console.WriteLine("Ten Lop: " + tenLop);
             Console.WriteLine("So hoc sinh: " + soHs);
         }

    }
    class Khoi:Lop{
        Lop c;
        private int khoi;
        
        public Khoi(string Name,int shs,int k){
            c = new Lop(Name,shs);
            this.khoi= k;
        }

        public void print(){
            c.print();
            Console.WriteLine("khoi: " + khoi);
        }
    }
    class Truong:Lop{
        Lop c;
        private string TenTruong;
        public Truong(string Name,int Age,string nameT){
            c = new Lop(Name,Age);
            TenTruong= nameT;
        }
        public void print(){
            c.print();
            Console.WriteLine("Ten truong: " + TenTruong);
        }
        public static void print1(){
            Console.WriteLine("Truong Dai Hoc Phenikaa");
        }
    }

    class DataBase{
        static void Main(String[] args){
            Lop c = new Lop("LopMot", 20);
            c.print();
            Khoi n = new("LopMot",20,5);
            n.print();
            Truong t = new("LopMot", 20, "Phenikaa");
            t.print();
            Truong.print1();
            Console.ReadLine();
        }
    }
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("陣列練習");
            Console.WriteLine("輸入座號1到55號");
            int number = Convert.ToInt32(Console.ReadLine());
            int[] jack = { 80, 75, 60 };
            int[] mary = { 65, 67, 62 };
            int[] tom = { 100, 93, 91 };
            int[] grace = { 98, 25, 50 };
            int[] alice = { 83, 82, 87 };
            
            if(number==1)
            {
                Console.WriteLine("1.姓名：Jack \n2.電腦概論：" + jack[0] + "\n 3.程式設計：" + jack[1] + " \n 4.動畫設計：" + jack[2] );
            }
            else if (number == 2)
            {
                Console.WriteLine("1.姓名：Mary \n2.電腦概論：" + mary[0] + "\n 3.程式設計：" + mary[1] + " \n 4.動畫設計：" + mary[2]);
            }
            else if (number == 3)
            {
                Console.WriteLine("1.姓名：Tom \n2.電腦概論：" + tom[0] + "\n 3.程式設計：" + tom[1] + " \n 4.動畫設計：" + tom[2]);
            }
            else if (number == 4)
            {
                Console.WriteLine("1.姓名：Grace  \n2.電腦概論：" + grace[0] + "\n 3.程式設計：" + grace[1] + " \n 4.動畫設計：" + grace[2]);
            }
            else if (number == 5)
            {
                Console.WriteLine("1.姓名：Alice  \n2.電腦概論：" + alice[0] + "\n 3.程式設計：" + alice[1] + " \n 4.動畫設計：" + alice[2]);
            }
            else  
            {
                Console.WriteLine("座號超出範圍");
            }
        }
    }
}

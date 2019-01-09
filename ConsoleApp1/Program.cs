using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformsExamOrw

{
    class Program
    {
        //Question 1
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int i = Convert.ToInt32(Console.ReadLine());
            Power2(i);
            Console.WriteLine($"power 2 of your number is {i}");
        }
        private static void Power2(int i)
        {
            i = i * 2;

        }

        //Question 2

        static void Update(int[] a)
        {
            a[0] = 1;
        }
        static void Main(string[] args)
        {
            int[] a = { 5, 4, -5 };
            Update(a);
        }
        //האיבר הראשון של המערך לא ישתנה כיוון שהערך שקלטנו קטן מהאיבר הראשון במערך ולכן יישאר כפי שהוא

        //Question 3
        static void Update(int[] a)
        {
            a = new int[3];
            a[0] = 1;
        }
        Static void Main(string[] args)
        {
            int[] a = { 5, 4, -5 };
            Update(a);
        }

    }   
    
    


}

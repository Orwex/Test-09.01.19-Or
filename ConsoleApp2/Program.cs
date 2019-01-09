using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {

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
        
        
    }
}

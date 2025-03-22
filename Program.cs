using System.ComponentModel;
using System.Net.Security;
using System.Runtime.CompilerServices;

namespace ConsoleApp2;

internal class Program
{
    static void Main(string[] args)
    {
        int[] myname = { 1, 2, 3, 4, 5 };
        for(int i=0;i<myname.Length
            ; i++)
        {
            Console.WriteLine(i);

        }

        foreach(int i in myname
            )
        {
            Console.WriteLine(i);
            
        }
        int j = 0;
        while (j < myname.Length)
        {

            Console.WriteLine(j);
            j++;
        }
    }
}
 

using System.ComponentModel;
using System.Net.Security;
using System.Runtime.CompilerServices;

namespace ConsoleApp2;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Mygreat(8, 9));
    }
   public static string Mygreat(int a,int b) {

        string great = "";
        if (a < b)
        {
            great = "a is big";
        }
        else
        {
            great = "b is big";
        }
        return great;
    
    
    }
    }

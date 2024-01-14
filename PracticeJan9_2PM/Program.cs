using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace PracticeJan9_2PM
{
    public class Program
    {
        static void Main(string[] args)
        {
            string s1= ConfigurationManager.AppSettings["n1"].ToString();
            string s2 = ConfigurationManager.AppSettings["n2"].ToString();
            string s3 = ConfigurationManager.AppSettings["password"].ToString();
            Console.Write("Enter your password :");
            string s4=Console.ReadLine();
            if(s4.Equals(s3))
            {
                Console.WriteLine("wellcome");
            }
            else
            {
                Console.WriteLine("Password not  match");
            }
            Console.WriteLine(s4+" "+s1);
           
            
            
            
        }
    }
}


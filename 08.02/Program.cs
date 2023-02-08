using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Authentication.ExtendedProtection.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace _08._02
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Name: ");
            string name = Console.ReadLine();
            try
            { 
                if(name=="")
                {
                    throw new Exception("No name!  Error");
                }

            
            }
            catch(Exception a)           
            {
                Console.WriteLine(a.Message);
            }

            Console.WriteLine("Enter Surname: ");
            string surn = Console.ReadLine();
            try
            {
               
                if (surn == "")
                {
                    throw new Exception("No Surname!  Error");
                }
            }
            catch( Exception b) 
            {
                Console.WriteLine(b.Message);
            }

            Console.WriteLine("Enter Fathername: ");
            string fname = Console.ReadLine();
            try
            {
                
                if (fname == "")
                {
                    throw new Exception("No Fatheranme!  Error");
                }
            }
            catch (Exception c)
            {
                Console.WriteLine(c.Message);
                
            }

            Console.WriteLine("Enter Card: ");
            string card = Console.ReadLine();
            try
            {
                if(card=="")
                {
                    throw new Exception("No Card   Error");
                }
                if (card.Length!=16)
                {
                    throw new Exception("False Card Numbers  Error");
                }
            }
            catch (Exception d)
            {
                Console.WriteLine(d.Message);
                
            }

            Console.WriteLine("Enter Card Date Month: ");
            int mont = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Card Date Year: ");
            int year = int.Parse(Console.ReadLine());
            try
            {                    
                if (mont < 2 || year <= 23 || year > 35 || mont > 12)
                {                  
                    throw new Exception("False Card DATE  Error");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                
            }

            Console.WriteLine("Enter your CVC: ");
            string cvc = Console.ReadLine();
            try
            {
                if(cvc=="")
                {
                    throw new Exception("NO CVC Error");
                }
                if(cvc.Length!=3)
                {
                    throw new Exception("FAlSE CVC!");
                }
            }
            catch (Exception f)
            {
                Console.WriteLine(f.Message);
                
            }

            Console.WriteLine("\nYour Name:");
            System.Console.WriteLine(name);
            Console.WriteLine("\nYour Surname:");
            System.Console.WriteLine(surn);
            Console.WriteLine("\nYour Fathersname:");
            System.Console.WriteLine(fname);
            Console.WriteLine("\nYour Card:");
            System.Console.WriteLine(card);
            Console.WriteLine("\nYour Card Month:");
            Console.WriteLine(mont);
            Console.WriteLine("\nYour Card Year:");
            Console.WriteLine(year);
            Console.WriteLine("\nYour CVC:");
            System.Console.WriteLine("***");
        }
    }
}
//, "\nYour suname: ", surn, "\nYour Fathersname: ", fname, "\nYour Card: ", card.Last(), "\nYour Card Date: ", cdate1, "/", cdate2, "\nYour CVC: ***
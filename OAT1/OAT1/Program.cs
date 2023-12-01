using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OAT1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro objcarro = new Carro();
            objcarro.modelo = "Argo";
            objcarro.marca = "Fiat";
            objcarro.porta = 4;
            objcarro.km = 50000;


            Carro objcarro2 = new Carro();
            objcarro2.modelo = "Gol";
            objcarro2.marca = "volkswagen";
            objcarro2.porta = 4;
            objcarro2.km = 60000;

            Carro objcarro3 = new Carro();
            {
                objcarro3.modelo = "Civic";
                objcarro3.marca = "Honda";
                objcarro3.porta = 4;
                objcarro3.km = 70000;
            };
            Console.WriteLine(objcarro.modelo);
            Console.WriteLine(objcarro.marca);
            Console.WriteLine(objcarro.porta);
            Console.WriteLine(objcarro.km);
            Console.WriteLine("*************************");
            Console.WriteLine(objcarro2.modelo);
            Console.WriteLine(objcarro2.marca);
            Console.WriteLine(objcarro2.porta);
            Console.WriteLine(objcarro2.km);
            Console.WriteLine("*************************");
            Console.WriteLine(objcarro3.modelo);
            Console.WriteLine(objcarro3.marca);
            Console.WriteLine(objcarro3.porta);
            Console.WriteLine(objcarro3.km);
            Console.WriteLine("*************************");
        }

        private static void Main1()
        {
            Carro meuCarro = new Carro();

            Console.WriteLine(meuCarro.Acelerar()); 
            Console.WriteLine(meuCarro.Freiar());   

            Console.WriteLine(meuCarro.Acelerar());
            Console.WriteLine(meuCarro.Freiar());   

            Console.ReadLine();
            Console.ReadKey();
        }
    }
}


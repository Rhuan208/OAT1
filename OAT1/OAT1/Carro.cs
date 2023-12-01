using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT1
{
    internal class Carro
    {
        public string marca { get; set; }
        public int km { get; set; }
        public int porta { get; set; }
        public string modelo { get; set; }


        private bool emMovimento;

        public Carro()
        {
            emMovimento = false;
        }

        public string Acelerar()
        {
            if (emMovimento)
            {
                return "O carro já está em movimento!";
            }
            else
            {
                emMovimento = true;
                return "O carro está em movimento.";
            }
        }

        public string Freiar()
        {
            if (emMovimento)
            {
                emMovimento = false;
                return "O carro está parado.";
            }
            else
            {
                return "O carro já está parado!";
            }
        }
    }
}





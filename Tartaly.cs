using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Tartaly
    {
        private string nev { get; set; }
        private int a { get; set; }
        private int b { get; set; }
        private int c { get; set; }
        private double aktLiter { get; set; }

        Tartaly(string nev,int a,int b,int c)
        {
            this.nev = nev;
            this.a = a;
            this.b = b;
            this.c = c;
            this.aktLiter = 0;
        }
        Tartaly(string nev)
        {
            this.nev = nev;
            this.a = 10;
            this.b = 10;
            this.c = 10;
            this.aktLiter = 0;
        }
        public double Terfogat
        {
            get => this.a * this.b * this.c;
        }
        public void DuplazMeret()
        {
            this.a *= 2;
        }
        public void TeljesLeengedes()
        {
            this.aktLiter = 0;
        }
        public double Toltottseg
        {
            get => (this.aktLiter*1000 / Terfogat/1000) * 100;
        }
        public void Tolt(double mennyit)
        {
            if (Terfogat < this.aktLiter+mennyit)
            {
                Console.WriteLine("Hiba");
                return;
            }
            this.aktLiter += mennyit;
        }
        public string Info()
        {
            return $"{this.nev}: {this.Terfogat * 1000:n1} cm3 = ({this.Terfogat:n2} liter)," +
                $" töltöttsége: {this.Toltottseg:n2}%, ({this.aktLiter:n2} liter)," +
                $" méretei: {this.a}x{this.b}x{this.c} cm";

        }
    }
}

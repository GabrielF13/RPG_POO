using System;
using RPG_POO.src.Entities;

namespace RPG_POO
{
    class Program
    {
        static void Main(string[]args)
        {

            Knight arus = new Knight("Arus", 23, 469, 749, "Knight");
            Wizard angelica = new Wizard("Angelica", 13,292,574, "WhiteWizard");
            BlackWizard topapa = new BlackWizard("Topapa", 42,106,385,"BlackWizard");
            Ninja wedge = new Ninja("Wedge",42,292,574,"Ninja");

            //Knigth
            System.Console.WriteLine($"Status : {arus}");
            System.Console.WriteLine(arus.Attack());

            System.Console.WriteLine(); //Pular linha

            
            //Wizard
            System.Console.WriteLine($"Status : {angelica}");
            System.Console.WriteLine(angelica.Attack(1));
            System.Console.WriteLine(angelica.Attack(7));

            System.Console.WriteLine(); //Pular linha


            //BlackWizard
            System.Console.WriteLine($"Status : {topapa}");
            System.Console.WriteLine(topapa.Attack(1));
            System.Console.WriteLine(topapa.Attack(7));

            System.Console.WriteLine(); //Pular linha

            //Ninja
            System.Console.WriteLine($"Status {wedge}");
            System.Console.WriteLine(wedge.Attack());

        }
    }
}
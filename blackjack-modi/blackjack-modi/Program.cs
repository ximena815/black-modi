using System;

namespace blackjack_modi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a BlackJack GAME ;3");


            Random aleatorio = new Random();
            string respuesta = "s", continuar = "s";
            int carta1 = 0, carta2 = 0, juga = 0, n = 0, carta3 = 0, ganador = 0;//
            //cartas del 1 al 10
            int total1 = 0, total2 = 0, total3 = 0, total4 = 0, total5 = 0, totalac = 0, totalganador = 0;
            bool vali = false;


            while(vali == false)
            {
                Console.WriteLine("ingrese el n° de jugadores de 2 a 5 ");
                n = int.Parse(Console.ReadLine());
                
                if (n < 2 || n > 5)
                {
                    Console.WriteLine("dije de 2 a 5 jugadores");
                }
                else
                {
                    juga = n;
                    vali = true;
                }

            }
            for (int jugador = 1; jugador <= juga; jugador++)
            {
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("Eres el jugar n°: " + jugador);
                carta2 = aleatorio.Next(1, 11);
                Console.WriteLine("tu carta1 es: " + carta2);
                carta1 = aleatorio.Next(1, 11); //cartas del 1 al 10
                Console.WriteLine("tu carta2 es: " + carta1);
                if (jugador == 1) { total1 += carta1 + carta2; totalac = total1; }
                if (jugador == 2) { total2 += carta1 + carta2; totalac = total2; }
                if (jugador == 3) { total3 += carta1 + carta2; totalac = total3; }
                if (jugador == 4) { total4 += carta1 + carta2; totalac = total4; }
                if (jugador == 5) { total5 += carta1 + carta2; totalac = total5; }
                Console.WriteLine("tu total de cartas actual es: " + totalac);
                continuar = "s";
                while (continuar == "s")
                {
                    Console.WriteLine("¿Deseas otra carta? (s/n)");
                    respuesta = Console.ReadLine();

                    while (respuesta != "s" && respuesta != "n")
                    {
                        Console.WriteLine("¿Deseas otra carta? (s/n)");
                        respuesta = Console.ReadLine();
                    }

                    if (respuesta == "s")
                    {

                        carta3 = aleatorio.Next(1, 11); //cartas del 1 al 10
                        Console.WriteLine("tu carta es: " + carta3);
                        if (jugador == 1) { total1 += carta3; totalac = total1; }
                        if (jugador == 2) { total2 += carta3; totalac = total2; }
                        if (jugador == 3) { total3 += carta3; totalac = total3; }
                        if (jugador == 4) { total4 += carta3; totalac = total4; }
                        if (jugador == 5) { total5 += carta3; totalac = total5; }
                        Console.WriteLine("tu total de cartas actual es: " + totalac);

                        if (totalac > 21)//Perder ;3
                        {
                            Console.WriteLine("Mucha avaricia mijo perdio");
                            continuar = "n";
                            Console.ForegroundColor = ConsoleColor.Gray;
                            string pajarito =
                              "\n  ^ ^" +
                              "\n (O,O)" +
                              "\n (   )" +
                              "\n  T T";
                            Console.WriteLine(pajarito);
                            if (total1 > 21) { total1 = 0; }
                            if (total2 > 21) { total2 = 0; }
                            if (total3 > 21) { total3 = 0; }
                            if (total4 > 21) { total4 = 0; }
                            if (total5 > 21) { total5 = 0; }
                        }
                        if (totalac == 21)
                        {
                            Console.WriteLine("no me lo creo ganaste");
                            continuar = "n";
                            Console.ForegroundColor = ConsoleColor.Green;
                            string pajarito =
                              "\n  ^ ^" +
                              "\n (O,O)" +
                              "\n (   )" +
                              "\n  T T";
                            Console.WriteLine(pajarito);
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("le estan saliendo como plumas mijo");
                        Console.WriteLine("te falto " + (21 - totalac));
                        continuar = "n";

                        if (total1 > 21) { total1 = 0; }
                        if (total2 > 21) { total2 = 0; }
                        if (total3 > 21) { total3 = 0; }
                        if (total4 > 21) { total4 = 0; }
                        if (total5 > 21) { total5 = 0; }

                    }


                }
                
            }
            if (total1 > total2 && total1 > total3 && total1 > total4 && total1 > total5 && total1 <= 21)
            {
                totalganador = total1;
                ganador = 1;
            }
            else if (total2 > total3 && total2 > total4 && total2 > total5 && total2 <= 21)
            {
                totalganador = total2;
                ganador = 2;
            }
            else if (total3 > total4 && total3 > total5 && total3 <= 21)
            {
                totalganador = total3;
                ganador = 3;
            }
            else if (total4 > total5 && total4 <= 21)
            {
                totalganador = total4;
                ganador = 4;
            }
            else if (total5 <= 21)
            {
                totalganador = total5;
                ganador = 5;
            }
            if (totalganador != 0 && ganador != 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("total ganador " + totalganador);
                Console.WriteLine("El jugador que tiene el gran honor de ganar es: " + ganador);
            }
            else
            {
                Console.WriteLine("Nadie ha ganado");
            }
        }
    }
}

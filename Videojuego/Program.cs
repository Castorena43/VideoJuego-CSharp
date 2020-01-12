using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Videojuego
{
    class Program
    {
        static void Main(string[] args)
        {
            int vidas = 3;
            Heroe heroe = new Heroe();
            Villano villano = new Villano();
            Console.WriteLine("Tu eres El Heroe derrota al Villano");
            while (villano.Vida1 != 0 && vidas != 0 )
            { 
                int ataque = ElegirAtaque_Heroe();
                villano.RestarVida(ataque);
                heroe.AumentarVida(CalcularBonusVida(ataque));                
                ataque = ElegirAtaque_Villano();
                heroe.RestarVida(ataque);
                Console.WriteLine("Tu vida es: " + heroe.Vida1);
                Console.WriteLine("Villano: " + villano.Vida1);
                if (heroe.Vida1 == 0)
                {
                    vidas -= 1;
                    Console.WriteLine("Perdiste.");
                    Console.WriteLine("Quieres continuar (s/n): ");
                    char op = Convert.ToChar(Console.ReadLine());
                    if(op == 's')
                    {
                        heroe.Vida1 = 5000;
                    }else
                    {
                        break;
                    }                
                }else if(villano.Vida1 == 0)
                {
                    Console.WriteLine("Ganaste");
                }
           }
            Console.ReadKey();
            Environment.Exit(1);
            
        }

        public static int ElegirAtaque_Heroe()
        {
            Heroe MiHeroe = new Heroe();
            int opcion;
            int ataque = 0;
            Console.WriteLine("Lista de Ataques");
            Console.WriteLine("1) Ataque 1(50)");
            Console.WriteLine("2) Ataque 2(150)");
            Console.WriteLine("3) Ataque 3(300)");
            Console.WriteLine("4) Ataque 4(500)");
            Console.WriteLine("5) Ataque 5(1000)");
            Console.WriteLine("6) Ataque 6(5000)");
            Console.Write("Seleccionar ataque: ");
            opcion = Convert.ToInt32(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    ataque = MiHeroe.Ataque1;
                    break;
                case 2:
                    ataque = MiHeroe.Ataque2;
                    break;
                case 3:
                    ataque = MiHeroe.Ataque3;
                    break;
                case 4:
                    ataque = MiHeroe.Ataque4;
                    break;
                case 5:
                    ataque = MiHeroe.Ataque5;
                    break;
                case 6:
                    ataque = MiHeroe.Ataque6;
                    break;

            }
            return ataque;
        }

        public static int ElegirAtaque_Villano()
        {
            int ataque = 0;
            Villano MiVillano = new Villano();
            Random random = new Random();
            int randomNumber = random.Next(1,6);
            switch (randomNumber)
            {
                case 1:
                    ataque = MiVillano.Ataque1;
                    break;
                case 2:
                    ataque = MiVillano.Ataque2;
                    break;
                case 3:
                    ataque = MiVillano.Ataque3;
                    break;
                case 4:
                    ataque = MiVillano.Ataque4;
                    break;
                case 5:
                    ataque = MiVillano.Ataque5;
                    break;
                case 6:
                    ataque = MiVillano.Ataque6;
                    break;
            }
            return ataque;

        }

        public static int CalcularBonusVida(int ataque)
        {
            int bonus = 0;
            switch (ataque)
            {
                case 50:
                    bonus = 1000;
                    break;
                case 150:
                    bonus = 600;
                    break;
                case 300:
                    bonus = 300;
                    break;
                case 500:
                    bonus = 100;
                    break;
                default:
                    bonus = 0;
                    break;
            }
            return bonus;
        }
    }
}

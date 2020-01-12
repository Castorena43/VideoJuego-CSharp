using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Videojuego
{
    class Heroe
    {
        int Vida = 5000;
        int ataque1 = 50;
        int ataque2 = 150;
        int ataque3 = 300;
        int ataque4 = 500;
        int ataque5 = 1000;
        int ataque6 = 5000;

        public int Vida1
        {
            get
            {
                return Vida;
            }

            set
            {
                Vida = value;
            }
        }

        public int Ataque1
        {
            get
            {
                return ataque1;
            }

            set
            {
                ataque1 = value;
            }
        }

        public int Ataque2
        {
            get
            {
                return ataque2;
            }

            set
            {
                ataque2 = value;
            }
        }

        public int Ataque3
        {
            get
            {
                return ataque3;
            }

            set
            {
                ataque3 = value;
            }
        }

        public int Ataque4
        {
            get
            {
                return ataque4;
            }

            set
            {
                ataque4 = value;
            }
        }

        public int Ataque5
        {
            get
            {
                return ataque5;
            }

            set
            {
                ataque5 = value;
            }
        }

        public int Ataque6
        {
            get
            {
                return ataque6;
            }

            set
            {
                ataque6 = value;
            }
        }

        public void RestarVida(int ataque)
        {
            Vida = Vida - ataque;
           
        }

        public void AumentarVida(int vida)
        {
            Vida += vida;
        }
    }
}

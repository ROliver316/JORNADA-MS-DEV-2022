using System;
using System.Collections.Generic;
using System.IO;

namespace ProjetoElevador.Model
{ public class ELEVADOR
    {
        private int CMAX; //CAPACIDADE MÁXIMA DO ELEVADOR//
        private int TOTAND; //TOTAL DE ANDARES DO PRÉDIO//
        private int QP; // QUANTIDADE DE PESSOAS NO ELEVADOR//
        private int LANDAR; //ANDAR QUE ELEVADOR ESTAR//
        public void Inicializar(int Capacidade, int ANDAR) {
            this.CMAX = Capacidade;
            this.LANDAR = ANDAR;
        
        }
        public void Entrar()
        {
            if (this.QP == this.CMAX)
            {
                Console.WriteLine("Capacidade Maxima Atingida!")
            }
            else if(this.QP < this.CMAX)
            {
                this.QP += 1;
                Console.WriteLine($"Numero de pessoas no elevador:{this.QP}");

            }
        }
        public void Sair()
        {
            if (this.QP == 0)
            {
                Console.Write("Elevador se encontra vazio");
            }
            else if(this.QP > 0)
            {
                this.QP -=1
                    Console.WriteLine($"Quantidade de Pessoas no Elevador:{this.QP}")
            }
        }

        public void Subir()
        {
            if( this.LANDAR == this.TOTAND)
            {
                Console.WriteLine("Limite máximo atingido");

            }
            else {
                this.LANDAR += 1;
                Console.WriteLine($"Elevador esta no andar:{this.LANDAR}");
                 }
        }
        
        public void Descer()
        {
            if(this.LANDAR == 0)
            {
                Console.WriteLine("Elevador no Terreo");
            }
            else
            {
                this.LANDAR -= 1;
                if(this.LANDAR == 0)
                {
                    Console.WriteLine($"Elevador Está no Terreo");
                }
                else
                {
                    Console.WriteLine($"Andar que o elevador estar:{this.LANDAR}");
                }
            }


        }
    }

}

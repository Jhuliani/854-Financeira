using System;


namespace ExercicioHerancaLets
{
    internal class Contrato
    {
        public Guid IdContrato { get; private set; }
        public string Contratante { get; private set; } 
        public double Valor { get; set; }
        public int Prazo { get; set; }

        public Contrato()
        {

        }

        public Contrato( string contratante, double valor, int prazo)
        {
            IdContrato = Guid.NewGuid();
            Contratante = contratante;
            Valor = valor;
            Prazo = prazo;

        }

        public virtual double CalcularPrestacao()
        {
            return Valor/Prazo;
        }

        public virtual void ExibirInfo()
        {
            Console.WriteLine();
            Console.WriteLine("Informações do contrato:");
            Console.WriteLine("Valor do contrato: "+ Valor);
            Console.WriteLine("Prazo: " + Prazo);
            Console.WriteLine("Valor da prestação: " + CalcularPrestacao());
        }

       



    }
}

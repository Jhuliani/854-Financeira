using System;


namespace ExercicioHerancaLets
{
    internal class ContratoPessoaFisica : Contrato
    {
        public string Cpf { get; private set; }
        public DateTime Nascimento { get; private set; }
       
       public ContratoPessoaFisica()
        {

        }
        
        public ContratoPessoaFisica(string contratante, double valor, int prazo, string cpf, int anoNasc, int mesNas, int diaNas) 
            : base(contratante,valor,prazo)
        {
            Cpf = cpf;
            Nascimento = new DateTime(anoNasc, mesNas, diaNas);
        }

        public int Idade()
        {
            return DateTime.Now.Year - this.Nascimento.Year;
        }


        public override double CalcularPrestacao()
        {
            // int hoje = int.Parse(DateTime.Now.ToString("yyyy"));
            //int anoNas = int.Parse(Nascimento.Year.ToString("F4"));
            int idade = Idade();//hoje - anoNas;
            if(idade <= 30)
            {
               return base.CalcularPrestacao() + 1;
            }
            else if (idade <= 40)
            {
               return base.CalcularPrestacao() + 2;
            }
            else if (idade <= 50)
            {
               return base.CalcularPrestacao() + 3;
            }
            else 
            {
                return base.CalcularPrestacao() + 4;
            }
        }

        public override void ExibirInfo()
        {
            base.ExibirInfo();
            Console.WriteLine($"Idade: {Idade()}");
        }





    }


    
}

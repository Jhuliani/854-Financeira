


namespace ExercicioHerancaLets
{
    internal class ContratoPessoaJuridica : Contrato
    {
        public string Cnpj { get; private set; }
        public string InscricaoEstadual { get; private set; }

        public ContratoPessoaJuridica()
        {

        }

        public ContratoPessoaJuridica(string contratante, double valor, int prazo, string cnpj, string inscricaoEstad)
            : base(contratante, valor, prazo)
        {
            Cnpj = cnpj;
            InscricaoEstadual = inscricaoEstad;
        }

        public override double CalcularPrestacao()
        {
            return base.CalcularPrestacao() +3;
        }

        public override void ExibirInfo()
        {
            base.ExibirInfo();
        }

    }
}

namespace Peak.Api.DTOs
{
    public class EmprestimoDTO
    {
        public int Parcelas { get; private set; }
        public decimal Valor { get; private set; }
        public decimal ValorFinal { get; private set; }

        public EmprestimoDTO(int parcelas, decimal valor)
        {
            if (parcelas <= 0)
                throw new Exception("Número de parcelas deve ser igual ou maior que 1.");

            if (valor <= 0)
                throw new Exception("O valor deve ser igual ou maior que 1.");

            Parcelas = parcelas;
            Valor = valor;
        }

        public void setParcelas(int parcelas)
        {
            if (parcelas <= 0)
                throw new Exception("Número de parcelas deve ser igual ou maior que 1.");

            Parcelas = parcelas;
        }

        public void setValor(decimal valor)
        {
            if (valor <= 0)
                throw new Exception("O valor deve ser igual ou maior que 1.");

            Valor = valor;
        }

        public void CalcularTaxaDeEmprestimo()
        {
            decimal valorTotal = (Valor * Parcelas);
            decimal valorFinal = valorTotal + valorTotal * new decimal(0.05);
            this.ValorFinal = valorFinal;
        }
    }
}

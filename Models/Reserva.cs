namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {   //Verifica se o numero de hospedes é maior que a capacidade
            if (hospedes.Count > Suite.Capacidade)
            {
                throw new InvalidOperationException("A quantidade de hóspedes é maior que a capacidade da suíte.");
            }

            Hospedes = hospedes;
        }


        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {   // Retorna a quantidade de hóspedes (propriedade Hospedes)
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            decimal valorDiaria = DiasReservados * Suite.ValorDiaria;

            // Se dias reservados for maior ou igual a 10, aplica 10% de desconto
            if (DiasReservados >= 10)
            {
                valorDiaria -= valorDiaria * 0.10m;
            }

            return valorDiaria;
        }
    }
}
namespace TipCalculator
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void CalcularButton_Clicked(object sender, EventArgs e)
        {
            double refeicao = Double.Parse(RefeicaoEntry.Text);
            double porcentagem = Double.Parse(PorcentagemEntry.Text);
            int qtdPessoas = Int32.Parse(QtdPessoasEntry.Text);

            double gorjeta = refeicao * (porcentagem / 100);
            double valorTotal = refeicao + gorjeta;
            double valorPessoa = valorTotal / qtdPessoas;

            GorjetaEntry.Text = gorjeta.ToString();
            ValorPorPessoaEntry.Text = valorPessoa.ToString();
            ValorTotalEntry.Text = valorTotal.ToString();
        }
    }
}

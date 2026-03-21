using System.Diagnostics;
using System.Globalization;
using System.Threading.Tasks;

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
            //outra forma de realizar conversão
            //double refeicao = Convert.ToDouble(RefeicaoEntry.Text);
            try
            {
                double refeicao = Double.Parse(RefeicaoEntry.Text);
                double porcentagem = Double.Parse(PorcentagemEntry.Text);
                int qtdPessoas = Int32.Parse(QtdPessoasEntry.Text);

                double gorjeta = refeicao * (porcentagem / 100);
                double valorTotal = refeicao + gorjeta;
                double valorPessoa = valorTotal / qtdPessoas;

                GorjetaEntry.Text = gorjeta.ToString("C");
                ValorPorPessoaEntry.Text = $"R${valorPessoa}";
                ValorTotalEntry.Text = valorTotal.ToString("C");
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            double value = e.NewValue;
            PorcentagemEntry.Text = value.ToString();
        }
    }
}

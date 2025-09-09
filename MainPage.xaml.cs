namespace TipTime
{
    public partial class MainPage : ContentPage
    {
        //int count = 0;

        public MainPage()
        {
            InitializeComponent();
            ValorTotalEntry.Text = "0";
            PorcentagemSlider.Value = 15;

        }

        private void Porcentagem15Btn_Clicked(object sender, EventArgs e)
        {
           PorcentagemSlider.Value = 15;
        }
        

        private void Porcentagem20Btn_Clicked(object sender, EventArgs e)
        {
            PorcentagemSlider.Value = 20;
        }

        private void RoundD_Clicked(object sender, EventArgs e)
        {
           
        }

        private void RoundU_Clicked(object sender, EventArgs e)
        {

        }

        private void PorcentagemSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            try {

                double porcentagem = PorcentagemSlider.Value;
                PorcentagemLabel.Text = $"{porcentagem}%";
                //double gorjeta;
                double valortotal = double.Parse(ValorTotalEntry.Text);
                //double valortotal = Convert.toDouble(ValorTotalEntry.Text); outro jeito de definir a variável valortotal :)
                //Convert é uma classe
                double valorfinal;
                double gorjeta = valortotal * (porcentagem / 100);
                //ValorGorjeta.Text = $"R$ {gorjeta}";
                ValorGorjeta.Text = gorjeta.ToString("C");
                //TotalFinal.Text = $"R$ {valortotal}";
                TotalFinal.Text = valortotal.ToString("C");
            }
            catch (Exception ex)
            {
                //toda vez que uso o comandoi Console.WriteLine a saída vai para a 
                //console na aba output
                Console.WriteLine(ex.ToString());
                DisplayAlert("Erro", "Digite um valor numérico", "OK");
            }

        }
    }

}

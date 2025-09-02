namespace TipTime
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
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
            float 


        }
    }

}

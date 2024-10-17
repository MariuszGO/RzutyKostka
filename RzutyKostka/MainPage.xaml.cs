namespace RzutyKostka
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }
       



        private void Button_Clicked(object sender, EventArgs e)
        {
            Random los = new Random();
            int [] tab = new int [5];
            int suma_calosc = 0;
            int suma_gry = 0;


            for (int i = 0; i < 5; i++)
            {

                tab[i] = los.Next(1,7);
                suma_gry = suma_gry + tab[i];
            }
            suma_calosc = suma_calosc + suma_gry;

            z1.Source = ImageSource.FromFile($"z{tab[0]}.png");
            z2.Source = ImageSource.FromFile($"z{tab[1]}.png");
            z3.Source = ImageSource.FromFile($"z{tab[2]}.png");
            z4.Source = ImageSource.FromFile($"z{tab[3]}.png");
            z5.Source = ImageSource.FromFile($"z{tab[4]}.png");



        }
    }

}

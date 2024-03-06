namespace Operaciones
{
    public partial class MainPage : ContentPage
    {
        int inicio, fin = 0;

        public MainPage()
        {
            InitializeComponent();
            inicio = Convert.ToInt16(Inicia.Text);
            fin = Convert.ToInt16(Fin.Text);


        }

        private void Aceptar_Clicked(object sender, EventArgs e)
        {
            if (inicio != 0 && fin != 0)
            {
                if( Par.IsChecked)
                {
                    for (int i = inicio; i <= fin; i++)
                    {
                        if (i % 2 == 0)
                        {
                            numero1.Items.Add(i.ToString());
                            numero2.Items.Add(i.ToString());
                        }
                    }
                }
                if (impar.IsChecked) {
                    for (int i = inicio; i <= fin; i++)
                    {
                        if (i % 2 != 0)
                        {
                            numero1.Items.Add(i.ToString());
                            numero2.Items.Add(i.ToString());
                        }
                    }
                }
                else
                {
                    DisplayAlert("Alerta", "Seleccionar Par o Impar", "Aceptar");
                }
            }
            else
            {
                DisplayAlert("Alerta", "Ingresar Ambos Valores", "Aceptar");

            }
        }

        private void numero1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numero2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void operar_Clicked(object sender, EventArgs e)
        {

        }
    }

}

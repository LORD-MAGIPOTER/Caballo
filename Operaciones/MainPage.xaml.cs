namespace Operaciones
{
    public partial class MainPage : ContentPage
    {
        int inicio, fin = 0;
        int n1, n2, resultado;


        public MainPage()
        {
            InitializeComponent();
        }

        private void Aceptar_Clicked(object sender, EventArgs e)
        {
            try 
            {
                inicio = Convert.ToInt16(Inicia.Text);
                fin = Convert.ToInt16(Fin.Text);



                if (inicio != 0 && fin != 0)
                {
                    if (fin <= -1 || inicio <= -1)
                    {
                        DisplayAlert("Alerta", "Seleccionar Valores positivos", "Aceptar");
                    }
                    else {
                        if (fin < inicio)
                        {
                            DisplayAlert("Alerta", "El Valor final no puede ser menor al inicial", "Aceptar");
                        }
                        else 
                        {
                            
                            if (Par.IsChecked)
                            {
                                
                                for (int i = inicio; i <= fin; i++)
                                {

                                    if (i % 2 == 0)
                                    {
                                        numero1.Items.Add(i.ToString());
                                        numero2.Items.Add(i.ToString());
                                    }
                                }
                                Aceptar.IsEnabled = false;
                            }
                            else if (impar.IsChecked)
                            {
                               
                                for (int i = inicio; i <= fin; i++)
                                {
                                    if (i % 2 != 0)
                                    {
                                        numero1.Items.Add(i.ToString());
                                        numero2.Items.Add(i.ToString());
                                    }
                                }
                                Aceptar.IsEnabled = false;
                            }
                            else
                            {
                                DisplayAlert("Alerta", "Seleccionar Par o Impar", "Aceptar");
                            }

                        }
                    }
                }
                else
                {
                    DisplayAlert("Alerta", "Ingresar Ambos Valores", "Aceptar");

                }
                

            }
            catch (Exception ex) {
                DisplayAlert("Alerta", ex.Message, "Aceptar");
            }
        }

        private void numero1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(numero1.SelectedIndex != -1)
            {
                n1 = Convert.ToInt32(numero1.SelectedItem);
            }
        }

        private void numero2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (numero2.SelectedIndex != -1)
            {
                n2 = Convert.ToInt32(numero2.SelectedItem);
            }
        }

        // operacines a realizar
        public int suma(int number1, int number2)
        {
            return (number1 + number2);
        }

        private void Limpiar_Clicked(object sender, EventArgs e)
        {
            Inicia.Text = "";
            Fin.Text = "";
            numero1.Items.Clear();
            numero2.Items.Clear();
            rsuma.Text = "";
            rresta.Text = "";
            rmultiplica.Text = "";
            Par.IsChecked = false;
            impar.IsChecked = false;
            Suma.IsChecked = false;
            Resta.IsChecked = false;
            Multiplicacion.IsChecked = false;
            Aceptar.IsEnabled = true;
        }

        public int resta(int number1, int number2)
        {
            return (number1 - number2);
        }
        public int multi(int number1, int number2)
        {
            return (number1 * number2);
        }
        //metodo que regresa los resultados
        private void operar_Clicked(object sender, EventArgs e)
        {
            if (n1 != 0 && n2 != 0)
            {
                if (Suma.IsChecked && Resta.IsChecked && Multiplicacion.IsChecked)
                {

                    rsuma.Text = "Resultado de suma " + suma(n1, n2).ToString();
                    rresta.Text = "Resultado de resta " + resta(n1, n2).ToString();
                    rmultiplica.Text = "Resultado de multiplicación " + multi(n1, n2).ToString();
                }
                else if (Suma.IsChecked && Resta.IsChecked)
                {

                    rsuma.Text = "Resultado de suma " + suma(n1, n2).ToString();
                    rresta.Text = "Resultado de resta " + resta(n1, n2).ToString();
                }
                else if (Resta.IsChecked && Multiplicacion.IsChecked)
                {
                    rresta.Text = "Resultado de resta " + resta(n1, n2).ToString();
                    rmultiplica.Text = "Resultado de multiplicacion " + multi(n1, n2).ToString();
                }
                else if (Suma.IsChecked && Multiplicacion.IsChecked)
                {

                    rsuma.Text = "Resultado de suma " + suma(n1, n2).ToString();
                    rmultiplica.Text = "Resultado de multiplicacion " + multi(n1, n2).ToString();
                }
                else if (Suma.IsChecked)
                {
                    rsuma.Text = "Resultado de suma " + suma(n1, n2).ToString();
                }
                else if (Resta.IsChecked)
                {
                    rresta.Text = "Resultado de resta " + resta(n1, n2).ToString();
                }
                else if (Multiplicacion.IsChecked)
                {
                    rmultiplica.Text = "Resultado de multiplicación " + multi(n1, n2).ToString();
                }
                else
                {
                    DisplayAlert("Alerta", "Seleccionar operación a realizar","Aceptar");
                }

            }
            else {
                DisplayAlert("Alerta", "Seleccionar Ambos Valores", "Aceptar");
            }

        }
    }

}

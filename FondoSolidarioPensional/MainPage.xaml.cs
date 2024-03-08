using Microsoft.Win32.SafeHandles;

namespace FondoSolidarioPensional
{
    public partial class MainPage : ContentPage
    {
        private const int SALARIO_MINIMO = 1160000;
        private const decimal CUATRO = 0.04m;
        private const decimal UNO = 0.01m;
        private const decimal DOCE = 0.12m;
        private const decimal KTORCE = 0.14m;
        private const decimal DIECISEIS = 0.16m;
        private const decimal DIECIOCHO = 0.18m;
        private const decimal VEINTE = 0.2m;


        public MainPage()
        {
            InitializeComponent();
        }

        private void Calcular_Clicked(object sender, EventArgs e)
        {
            
            var salario = Convert.ToDecimal(EntrySalario.Text);
            Calcular1(salario);
            Calcular2(salario);
             
            

        }

        
        private void Calcular1(decimal salario)
        {
            

            var Asaludpension = salario * CUATRO;

            EntryAsalud.Text = Asaludpension.ToString("F1");
            EntryApension.Text = Asaludpension.ToString("F1");
        }


        private void Calcular2(decimal salario)
        {
            if (salario >= 4 * SALARIO_MINIMO && salario < 16 * SALARIO_MINIMO)
            {
                var fps = salario * UNO;

                EntryFps.Text = fps.ToString();
            } else if (salario >= 16 * SALARIO_MINIMO && salario < 17 * SALARIO_MINIMO)
            {
                var fps = salario * DOCE;

                EntryFps.Text = fps.ToString();
            } else if (salario >= 17 * SALARIO_MINIMO && salario < 18 * SALARIO_MINIMO )
            {
                var fps = salario * KTORCE;

                EntryFps.Text = fps.ToString();
            }else if ( salario >= 18 * SALARIO_MINIMO && salario < 19 * SALARIO_MINIMO)
            {
                var fps = salario * DIECISEIS;

                EntryFps.Text = fps.ToString();
            }else if ( salario >= 19 * SALARIO_MINIMO && salario < 20 * SALARIO_MINIMO)
            {
                var fps = salario * DIECIOCHO;

                EntryFps.Text = fps.ToString();
            }else if ( salario >= 20 * SALARIO_MINIMO)
            {
                var fps = salario * VEINTE;

                EntryFps.Text = fps.ToString();
            }

        }
        

    }

}

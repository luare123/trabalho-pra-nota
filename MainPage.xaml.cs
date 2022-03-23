using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace nota
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            double peso = Convert.ToDouble(txt_peso.Text);
            double altura = Convert.ToDouble(txt_altura.Text);

            double imc = peso / (altura * altura);

            txt_imc.Text = $"Seu IMC é de: {imc.ToString("0.00")}";
            if (imc < 18.5)
            {
                tabela.Text = "Voce esta abaixo do peso";
            }
            else if (imc >= 18.5 && imc < 25)
            {
                tabela.Text = "Voce esta com o peso normal";
            }
            else if (imc >= 25 && imc < 30)
            {
                tabela.Text = "Voce esta com sobrepeso";
            }
            else if (imc >= 30 && imc < 35)
            {
                tabela.Text = "Voce esta com obesidade grau 1";
            }
            else if (imc >= 35 && imc < 40)
            {
                tabela.Text = "Voce esta com obesidade grau 2";
            }
            else
            {
                tabela.Text = "Voce esta com obesidade grau 3";
            }

            //referencia

            txt_referencia.Text = "Abaixo de 18.5//Abaixo do peso" +
                "\nEntre o imc 18.5 e 25 // Peso normal" +
                "\nEntre o imc 25 e 30 // Sobrepeso" +
                "\nEntre o imc 30 e 35 // Obesidade grau 1" +
                "\nEntre o imc 35 e 40 // Obesidade grau 2" +
                "\nAcima do imc de 40 // Obesidade grau 3";

        }
    }
}

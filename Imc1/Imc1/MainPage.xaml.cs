using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Imc1
{
    public partial class MainPage : ContentPage
    {
            public MainPage()
            {
                InitializeComponent();
            }

            private void Button_Clicked(object sender, EventArgs e)
            {
                Double altura = Convert.ToDouble(Altura.Text);

                Double peso = Convert.ToDouble(Peso.Text);

                Double imc;

                altura = altura * altura;
                imc = peso / altura;

                DisplayAlert("Calculo do IMC", "O seu IMC é: " + imc.ToString("0.00"), "Ok");
                string classif = "";

                if (imc < 18.5)
                {
                    classif = "Abaixo do Peso!!!";
                }
                else if (imc >= 18.5 && imc <= 24.9)
                {
                    classif = "Normal!!";
                }
                else if (imc >= 25 && imc <= 29.9)
                {
                    classif = "Sobrepeso!!";
                }
                else if (imc >= 30 && imc <= 34.9)
                {
                    classif = "Obesidade grau I!";
                }
                else if (imc >= 35 && imc <= 39.9)
                {
                    classif = "Obesidade grau II! / Cuidado!!";
                }
                else if (imc >= 40)
                {
                    classif = "Obesidade grau III / Mórbida / Perigo de vida!!";
                }

                DisplayAlert("Classificação", classif, "Ok!");
            }
        }
    }

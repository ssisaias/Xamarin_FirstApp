using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Exerc_Sec2_Aula20_Udemy_xamarin_form
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QuotesPage : ContentPage
    {
        int quote = 0;
        String[] quotes = { "you can't blame gravity for falling in love", "Life's like riding a bicycle. To keep" +
                " your balance, you must keep moving.", "Look deep into nature, and then you will understand everything better." };
        public QuotesPage()
        {
            InitializeComponent();

            font_size.Value = 16;
            frase.Text = quotes[quote];
        }

        private void font_size_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            frase.FontSize = e.NewValue;
        }

        private void next_Clicked(object sender, EventArgs e)
        {
            frase.Text = quotes[++quote];
            if (quote >= 2) { quote = 0; }
        }
    }
}

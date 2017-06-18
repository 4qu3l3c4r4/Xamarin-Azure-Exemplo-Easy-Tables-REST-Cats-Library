using Cats.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Cats.View
{
	public partial class CatsPage : ContentPage
	{
		public CatsPage ()
		{
			InitializeComponent ();
            ListViewCats.ItemSelected += ListViewCats_ItemSelectedAsync;
        }

        private async void ListViewCats_ItemSelectedAsync(object sender, SelectedItemChangedEventArgs e)
        {
            //armazena gato selecionado
            Cat selectedCat = e.SelectedItem as Cat;

            //checa se o gato esta vazio
            if (selectedCat != null)
            {
                //Cria nova janela na navigation passando o selectedCat de referencia
                await Navigation.PushAsync(new DetailsPage(selectedCat));
            }
        }
    }
}

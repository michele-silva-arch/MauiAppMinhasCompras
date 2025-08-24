using System.Threading.Tasks;
using MauiAppMinhasCompras.Models;

namespace MauiAppMinhasCompras.Views;

public partial class NovoProduto : ContentPage
{
	public NovoProduto()
	{
		InitializeComponent();
	}

    private async void ToolbarItem_Clicked(object sender, EventArgs e)
    {
		try
		{
			Produto p = new Produto
			{
				Descricao = txt_Descricao.Text,
				Quantidade = Convert.ToDouble(txt_Quantidade.Text),
				Preço = Convert.ToDouble(txt_Preco.Text)
			};

			await App.Db.Insert(p);
			await DisplayAlert("Sucesso!", "Registro Inserido", "Ok");

		} catch(Exception ex)
		{
			await DisplayAlert("Ops", ex.Message, "Ok");
		}
    }
}
using RevisaoAula.paginas;

namespace RevisaoAula;

public partial class Page1 : ContentPage
{
	public Page1()
	{
		InitializeComponent();
	}

    public void Calculadora(object sender, EventArgs e)
    {
        App.Current.MainPage=new calculadora();
    }

    public void Texto(object sender, EventArgs e)
    {
        App.Current.MainPage=new Texto();
    }

    public void Troca(object sender, EventArgs e)
    {
        App.Current.MainPage=new Troca();
    }
}
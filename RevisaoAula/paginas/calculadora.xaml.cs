namespace RevisaoAula.paginas;

public partial class calculadora : ContentPage
{
	public calculadora()
	{
		InitializeComponent();
	}
    public void Voltar(object sender, EventArgs e)
    {
        App.Current.MainPage=new Page1();
    }

    private void Calcular(object sender, EventArgs e)
    {

    }
}
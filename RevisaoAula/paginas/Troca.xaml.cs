namespace RevisaoAula.paginas;

public partial class Troca : ContentPage
{
	public Troca()
	{
		InitializeComponent();
	}
    public void Voltar(object sender, EventArgs e)
    {
        App.Current.MainPage=new Page1();
    }
}
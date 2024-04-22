namespace RevisaoAula.paginas;

public partial class Texto : ContentPage
{
	public Texto()
	{
		InitializeComponent();
	}
    public void Voltar(object sender, EventArgs e)
    {
        App.Current.MainPage=new Page1();
    }
}
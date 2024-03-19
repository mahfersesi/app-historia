namespace atravesdaminhajanela;

public partial class Historia08Page : ContentPage
{


	public Historia08Page()
	{
		InitializeComponent();
	}

	private void Prz(object sender, EventArgs args)
  {
      Application.Current.MainPage = new MainPage();
  }
}
namespace atravesdaminhajanela;

public partial class Historia03Page : ContentPage
{


	public Historia03Page()
	{
		InitializeComponent();
	}

	private void Promo(object sender, EventArgs args)
  {
      Application.Current.MainPage = new Historia04Page();
  }
}
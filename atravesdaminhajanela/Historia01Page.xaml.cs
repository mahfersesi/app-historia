namespace atravesdaminhajanela;

public partial class Historia01Page : ContentPage
{


	public Historia01Page()
	{
		InitializeComponent();
	}
    private void Calm(object sender, EventArgs args)
  {
      Application.Current.MainPage = new Historia02Page();
  }

  private void estressada(object sender, EventArgs args)
  {
      Application.Current.MainPage = new Historia03Page();
  }
}
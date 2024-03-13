namespace atravesdaminhajanela;

public partial class Historia02Page : ContentPage
{


	public Historia02Page()
	{
		InitializeComponent();
	}

 private void Prox(object sender, EventArgs args)
  {
      Application.Current.MainPage = new Historia04Page();
  }
}
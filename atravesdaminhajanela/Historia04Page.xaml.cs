namespace atravesdaminhajanela;

public partial class Historia04Page : ContentPage
{


	public Historia04Page()
	{
		InitializeComponent();
	}

	private void Proxim(object sender, EventArgs args)
  {
      Application.Current.MainPage = new Historia05Page();
  }
}
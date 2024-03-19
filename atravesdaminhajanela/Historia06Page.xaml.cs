namespace atravesdaminhajanela;

public partial class Historia06Page : ContentPage
{


	public Historia06Page()
	{
		InitializeComponent();
	}

	private void Prm(object sender, EventArgs args)
  {
      Application.Current.MainPage = new Historia09Page();
  }
}
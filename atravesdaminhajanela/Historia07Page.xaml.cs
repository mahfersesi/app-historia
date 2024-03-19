namespace atravesdaminhajanela;

public partial class Historia07Page : ContentPage
{


	public Historia07Page()
	{
		InitializeComponent();
	}

	private void Pr(object sender, EventArgs args)
  {
      Application.Current.MainPage = new Historia08Page();
  }

}
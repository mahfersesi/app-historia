namespace atravesdaminhajanela;

public partial class Historia05Page : ContentPage
{


	public Historia05Page()
	{
		InitializeComponent();
	}

    private void Pro(object sender, EventArgs args)
  {
      Application.Current.MainPage = new Historia06Page();
  }

  private void Pri(object sender, EventArgs args)
  {
      Application.Current.MainPage = new Historia07Page();
  }
}
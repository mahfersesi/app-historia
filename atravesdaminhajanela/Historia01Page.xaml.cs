namespace atravesdaminhajanela;

public partial class Historia01Page : ContentPage
{


	public Historia01Page()
	{
		InitializeComponent();
	}
    private void ClickAndGoToTheNext(object sender, EventArgs args)
  {
      Application.Current.MainPage = new OnePage();
  }
}
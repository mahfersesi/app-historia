namespace atravesdaminhajanela;

public partial class TwoPage : ContentPage
{

    int count = 0;

	public TwoPage()
	{
		InitializeComponent();
	}

	private void NextOne(object sender, EventArgs args)
  {
    Application.Current.MainPage = new Historia01Page ();
  }

}
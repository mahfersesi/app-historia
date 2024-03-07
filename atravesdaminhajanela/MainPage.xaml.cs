using Microsoft.Maui.Controls;

namespace atravesdaminhajanela;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	 private void ClickAndGoToTheNext(object sender, EventArgs args)
  {
      Application.Current.MainPage = new OnePage();
  }

  private void 
  AboutNext(object sender, EventArgs args)
  {
      Application.Current.MainPage = new TwoPage();
  }
}


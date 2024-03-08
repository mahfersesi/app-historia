using Microsoft.Maui.Controls;

namespace atravesdaminhajanela;

public partial class OnePage : ContentPage
{

    int count = 0;

	public OnePage()
	{
		InitializeComponent();
	}

private void ReturnHome(object sender, EventArgs args)
  {
    IsVisible = true;
  }



}
namespace DataTriggerBugInMaui;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		BindingContext = new ViewModel();
	}

	private void OnSwitchBoth(object sender, EventArgs e)
	{
		(BindingContext as ViewModel).OnSwitchBoth();
	}
}



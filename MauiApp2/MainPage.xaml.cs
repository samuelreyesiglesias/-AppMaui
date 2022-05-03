namespace MauiApp2;

public partial class MainPage : ContentPage
{
	int count = 0;

	public Command CounterClickCommand3 { get; set; }

	public void testMethod()
    {
		App.Current.MainPage.DisplayAlert("testing 3 UI UX MAUI", "testing a message", "ok");

	}

	public void methodCommand()
	{

		count++;
		CounterLabel.Text = $"Current count: {count}";
		App.Current.MainPage.DisplayAlert("testing UI UX MAUI", "testing a message", "ok");
		SemanticScreenReader.Announce(CounterLabel.Text);
	}
	public MainPage()
	{
		InitializeComponent();
		BindingContext =  new MauiApp2.Services.ComandosPrueba();
		//CounterClickCommand3  = new Command(testMethod);
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		this.methodCommand();
	}

	
}


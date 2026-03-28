namespace TipCalculator;

public partial class SobrePage : ContentPage
{
	public SobrePage()
	{
		InitializeComponent();
	}


    private void GithubButton_Clicked(object sender, EventArgs e)
    {
		Launcher.OpenAsync("https://github.com/");
    }
}
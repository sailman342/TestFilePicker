
namespace GestionClub;

public partial class MainPage : ContentPage
{
	public MainPage()
    {
        InitializeComponent();

        Appearing += MainPageAppearing;
    }

    private async void MainPageAppearing(object sender, EventArgs e)
    {
        // Workaround, uncomment next statement
        //await Task.Delay(1000);

        FileResult result = await FilePicker.Default.PickAsync();
    }
}


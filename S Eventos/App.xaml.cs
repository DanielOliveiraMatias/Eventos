namespace S_Eventos;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new NavigationPage(new Views.Cadastro());
    }
}

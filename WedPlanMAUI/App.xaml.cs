using WedPlanMAUI.Screens.home;

namespace WedPlanMAUI
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			MainPage = new HomeScreen();
		}
	}
}

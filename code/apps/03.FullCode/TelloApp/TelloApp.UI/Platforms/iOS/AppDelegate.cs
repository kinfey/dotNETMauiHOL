using Foundation;
using Microsoft.Maui.Hosting;

namespace TelloApp.UI;

[Register("AppDelegate")]
public class AppDelegate : MauiUIApplicationDelegate
{
	protected override MauiApp CreateMauiApp() => App.CreateMauiApp();
}


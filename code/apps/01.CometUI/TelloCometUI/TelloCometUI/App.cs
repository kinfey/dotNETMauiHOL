using Microsoft.Maui.Hosting;

namespace TelloCometUI;
public class App : CometApp
{
	[Body]
	View view() => new ControlView();

	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder.UseCometApp<App>()
			.ConfigureFonts(fonts => {
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});
		//-:cnd
#if DEBUG
		builder.EnableHotReload();
#endif
		//+:cnd
		return builder.Build();
	}
}

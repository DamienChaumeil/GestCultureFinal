﻿using AppGestCulture.Data;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace AppGestCulture;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		//potentiellement à enlever 
			builder.Services.AddSingleton<Views.MainPage>();
			builder.Services.AddSingleton<Database>();


#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}

using Avalonia;
using Avalonia.Media;
using System;

namespace testLinux
{
    internal sealed class Program
    {
        // Initialization code. Don't use any Avalonia, third-party APIs or any
        // SynchronizationContext-reliant code before AppMain is called: things aren't initialized
        // yet and stuff might break.
        [STAThread]
        public static void Main(string[] args) => BuildAvaloniaApp()
            .StartWithClassicDesktopLifetime(args);

        // Avalonia configuration, don't remove; also used by visual designer.
        public static AppBuilder BuildAvaloniaApp()
        {
            FontManagerOptions options = new();
            if (OperatingSystem.IsLinux())
            {
                options.DefaultFamilyName = "Noto Sans CJK SC";
            }

            return AppBuilder.Configure<App>()
                .UsePlatformDetect()
                .LogToTrace()
                .With(options);
        }
    }
}

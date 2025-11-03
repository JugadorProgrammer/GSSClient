using Avalonia;
using Avalonia.Markup.Xaml;
using GSSClient.Views;
using Prism.DryIoc;
using Prism.Ioc;

namespace GSSClient
{
    public partial class App : PrismApplication
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
            base.Initialize();
        }

        protected override AvaloniaObject CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }
    }
}
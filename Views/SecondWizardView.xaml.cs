using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;
using ReactiveUI;
using RescuerLaApp.ViewModels;

namespace RescuerLaApp.Views
{
    public class SecondWizardView : ReactiveUserControl<SecondWizardViewModel>
    {
        public SecondWizardView()
        {
            this.WhenActivated(disposables => { });
            AvaloniaXamlLoader.Load(this);
        }
    }
}
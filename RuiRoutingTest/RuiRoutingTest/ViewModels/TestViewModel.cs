using ReactiveUI;
using RuiRoutingTest.Interfaces;
using Splat;

namespace RuiRoutingTest.ViewModels
{
    public class TestViewModel : ReactiveObject, IRoutableViewModel, ITestViewModel
    {
        private string _text;

        public string Text
        {
            get { return _text; }
            set { this.RaiseAndSetIfChanged(ref _text, value); }
        }

        public TestViewModel()
        {
            HostScreen = Locator.Current.GetService<IScreen>();
            Text = "ReactiveUI.RoutingTest";
        }

        public string UrlPathSegment => "Test";
        public IScreen HostScreen { get; }
    }
}
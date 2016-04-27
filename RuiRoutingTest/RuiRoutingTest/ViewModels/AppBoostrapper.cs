using ReactiveUI;
using ReactiveUI.XamForms;
using RuiRoutingTest.Views;
using Splat;
using Xamarin.Forms;

namespace RuiRoutingTest.ViewModels
{
    public class AppBootstrapper : ReactiveObject, IScreen
    {
        public AppBootstrapper()
        {
            Router = new RoutingState();
        }

        public void Init()
        {
            Locator.CurrentMutable.RegisterConstant(this, typeof(IScreen));

            // I had to do this because mapping to typeof(IViewFor<ITestViewModel>) does not find the view
            // even if the view implements IViewFor<ITestViewModel>
            Locator.CurrentMutable.Register(() => new TestPage(), typeof(IViewFor<TestViewModel>));
            Router.Navigate.Execute(new TestViewModel());
        }

        public Page CreateMainPage()
        {
            return new RoutedViewHost();
        }

        public RoutingState Router { get; }
    }
}
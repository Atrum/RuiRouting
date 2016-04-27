using ReactiveUI;
using RuiRoutingTest.Interfaces;
using Xamarin.Forms;

namespace RuiRoutingTest.Views
{
    public partial class TestPage : ContentPage, IViewFor<ITestViewModel>
    {
        object IViewFor.ViewModel
        {
            get { return ViewModel; }
            set { ViewModel = (ITestViewModel)value; }
        }

        public static readonly BindableProperty ViewModelProperty = BindableProperty.Create("ViewModel",
            typeof(ITestViewModel), typeof(TestPage), default(ITestViewModel));

        public ITestViewModel ViewModel
        {
            get { return (ITestViewModel)GetValue(ViewModelProperty); }
            set { SetValue(ViewModelProperty, value); }
        }

        public TestPage()
        {
            InitializeComponent();
            BindingContext = ViewModel;
        }
    }
}

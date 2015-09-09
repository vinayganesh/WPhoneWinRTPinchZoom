using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace Zoom
{
    public sealed partial class MainPage : Page
    {
        public MainPageViewModel ViewModel { get; set; }

        public MainPage()
        {
            this.InitializeComponent();
            this.ViewModel = new MainPageViewModel();
            this.DataContext = ViewModel;

            this.NavigationCacheMode = NavigationCacheMode.Required;
        }

        private void Page_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            this.ViewModel.PageWidth = e.NewSize.Width;
            this.ViewModel.PageHeight = e.NewSize.Height;
        }
    }
}

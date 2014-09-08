using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Lotto.Model;
namespace Lotto
{
    public partial class Joker : PhoneApplicationPage
    {
        LottoViewModel viewModel;
        public Joker()
        {
            InitializeComponent();
            viewModel = new LottoViewModel();

            GetJokerData();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            SystemTray.ProgressIndicator = new ProgressIndicator();
            SystemTray.ProgressIndicator.Text = "Henter resultater";
            SetProgressIndicator(true);
        }

        private async void GetJokerData()
        {
            await viewModel.RetrieveJokerDataAsync();
            ContentPanel.Visibility = Visibility.Visible;
            this.DataContext = viewModel;
            SetProgressIndicator(false);
        }

        private void SetProgressIndicator(bool value)
        {
            SystemTray.ProgressIndicator.IsIndeterminate = value;
            SystemTray.ProgressIndicator.IsVisible = value;
        }
    }
}
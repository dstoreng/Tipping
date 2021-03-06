﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Lotto.Resources;
using Lotto.Model;
using System.ComponentModel;
using System.Threading.Tasks;

namespace Lotto
{
    public partial class Lotto : PhoneApplicationPage
    {
        LottoViewModel viewModel;

        // Constructor
        public Lotto()
        {
            InitializeComponent();

            viewModel = new LottoViewModel();
            GetLottoData(); 
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            SystemTray.ProgressIndicator = new ProgressIndicator();
            SystemTray.ProgressIndicator.Text = "Henter resultater";
            SetProgressIndicator(true);
        }

        private async void GetLottoData()
        {
            await viewModel.RetrieveLottoDataAsync();
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
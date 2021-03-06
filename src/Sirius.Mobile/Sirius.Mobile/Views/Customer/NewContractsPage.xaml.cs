﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Sirius.Mobile.Views.Customer
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewContractsPage : ContentPage
    {
        public NewContractsPage()
        {
            InitializeComponent();
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            App.Current.MainPage.Navigation.PushAsync(new DetailContractPage()
            {
                BindingContext = this.BindingContext
            });
        }
    }
}
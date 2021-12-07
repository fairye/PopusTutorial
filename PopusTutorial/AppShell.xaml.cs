using PopusTutorial.ViewModels;
using PopusTutorial.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace PopusTutorial
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}

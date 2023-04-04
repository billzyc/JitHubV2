﻿using JitHub.ViewModels.ActivityViewModels;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace JitHub.Views.Controls.Activity
{
    public sealed partial class IssueActivity : UserControl
    {
        public static DependencyProperty ViewModelProperty = DependencyProperty.Register(
            nameof(ViewModel),
            typeof(IssueActivityViewModel),
            typeof(IssueActivity),
            new PropertyMetadata(default(IssueActivityViewModel), null)
        );

        public static void OnViewModelChange(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is IssueActivity self && e.NewValue != null)
            {
                self.DataContext = self.ViewModel;
            }
        }

        public IssueActivityViewModel ViewModel
        {
            get => (IssueActivityViewModel)GetValue(ViewModelProperty);
            set => SetValue(ViewModelProperty, value);
        }
        public IssueActivity()
        {
            this.InitializeComponent();
        }
    }
}

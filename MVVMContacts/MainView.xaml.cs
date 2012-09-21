using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using Apex.MVVM;

namespace MVVMContacts
{
    /// <summary>
    /// Interaction logic for MainView.xaml
    /// </summary>
    [View(typeof(MainViewModel))]
    public partial class MainView : UserControl
    {
        public MainView()
        {
            InitializeComponent();
        }
    }
}

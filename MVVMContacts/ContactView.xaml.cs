using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using Apex.MVVM;

namespace MVVMContacts
{
    /// <summary>
    /// Interaction logic for ContactView.xaml
    /// </summary>
    [View(typeof(object))]
    public partial class ContactView : UserControl
    {
        public ContactView()
        {
            InitializeComponent();
        }
    }
}

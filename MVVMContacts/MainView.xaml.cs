using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using Apex.MVVM;
using System.Windows;

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

            viewModel.AddContactCommand.Executed += new CommandEventHandler(AddContactCommand_Executed);

            viewModel.DeleteContactCommand.Executing += new CancelCommandEventHandler(DeleteContactCommand_Executing);

            Loaded += new RoutedEventHandler(MainView_Loaded);
        }

        void MainView_Loaded(object sender, RoutedEventArgs args)
        {
            viewModel.AddContactCommand.DoExecute(null);
        }

        void AddContactCommand_Executed(object sender, CommandEventArgs args)
        {
            contactView.FocusContactName();
        }

        void DeleteContactCommand_Executing(object sender, CancelCommandEventArgs args)
        {
            args.Cancel = MessageBox.Show("Are you sure?", "Sure?", MessageBoxButton.YesNoCancel) != MessageBoxResult.Yes;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Apex.MVVM;

namespace MVVMContacts
{
    /// <summary>
    /// The MainViewModel ViewModel class.
    /// </summary>
    [ViewModel]
    public class MainViewModel : ViewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MainViewModel"/> class.
        /// </summary>
        public MainViewModel()
        {
            //  TODO: Use the following snippets to help build viewmodels:
            //      apexnp - Creates a Notifying Property
            //      apexc - Creates a Command.

            AddContactCommand = new Command(DoAddContactCommand);
            DeleteContactCommand = new Command(DoDeleteContactCommand, false);

            /*Contacts.Add(new ContactViewModel() { Name = "Homer" });
            Contacts.Add(new ContactViewModel() { Name = "Marge" });
            Contacts.Add(new ContactViewModel() { Name = "Maggie" });*/
        }




        /// <summary>
        /// Performs the DeleteContact command.
        /// </summary>
        /// <param name="parameter">The DeleteContact command parameter.</param>
        private void DoDeleteContactCommand(object parameter)
        {
            Contacts.Remove(SelectedContact);

            SelectedContact = null;
        }

        /// <summary>
        /// Gets the DeleteContact command.
        /// </summary>
        /// <value>The value of .</value>
        public Command DeleteContactCommand
        {
            get;
            private set;
        }

        /// <summary>
        /// Performs the AddContact command.
        /// </summary>
        /// <param name="parameter">The AddContact command parameter.</param>
        private void DoAddContactCommand(object parameter)
        {
            ContactViewModel newContact = new ContactViewModel()
            {
                Name = "New Contact"
            };

            Contacts.Add(newContact);

            SelectedContact = newContact;
        }

        /// <summary>
        /// Gets the AddContact command.
        /// </summary>
        /// <value>The value of .</value>
        public Command AddContactCommand
        {
            get;
            private set;
        }

        
        /// <summary>
        /// The Contacts observable collection.
        /// </summary>
        private ObservableCollection<ContactViewModel> ContactsProperty =
          new ObservableCollection<ContactViewModel>();

        /// <summary>
        /// Gets the Contacts observable collection.
        /// </summary>
        /// <value>The Contacts observable collection.</value>
        public ObservableCollection<ContactViewModel> Contacts
        {
            get { return ContactsProperty; }
        }


        
        /// <summary>
        /// The NotifyingProperty for the SelectedContact property.
        /// </summary>
        private readonly NotifyingProperty SelectedContactProperty =
          new NotifyingProperty("SelectedContact", typeof(ContactViewModel), default(ContactViewModel));

        /// <summary>
        /// Gets or sets SelectedContact.
        /// </summary>
        /// <value>The value of SelectedContact.</value>
        public ContactViewModel SelectedContact
        {
            get { return (ContactViewModel)GetValue(SelectedContactProperty); }
            set { 
                SetValue(SelectedContactProperty, value);

                DeleteContactCommand.CanExecute = value != null;
            }
        }

    }
}

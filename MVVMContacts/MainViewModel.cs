﻿using System;
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
            set { SetValue(SelectedContactProperty, value); }
        }

    }
}
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Apex.MVVM;

namespace MVVMContacts
{
    /// <summary>
    /// The ContactViewModel ViewModel class.
    /// </summary>
    [ViewModel]
    public class ContactViewModel : ViewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactViewModel"/> class.
        /// </summary>
        public ContactViewModel()
        {
            //  TODO: Use the following snippets to help build viewmodels:
            //      apexnp - Creates a Notifying Property
            //      apexc - Creates a Command.

        }

        
        /// <summary>
        /// The NotifyingProperty for the Name property.
        /// </summary>
        private readonly NotifyingProperty NameProperty =
          new NotifyingProperty("Name", typeof(string), default(string));

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        /// <value>The value of Name.</value>
        public string Name
        {
            get { return (string)GetValue(NameProperty); }
            set { SetValue(NameProperty, value); }
        }

        
        /// <summary>
        /// The NotifyingProperty for the Birthday property.
        /// </summary>
        private readonly NotifyingProperty BirthdayProperty =
          new NotifyingProperty("Birthday", typeof(DateTime), default(DateTime));

        /// <summary>
        /// Gets or sets Birthday.
        /// </summary>
        /// <value>The value of Birthday.</value>
        public DateTime Birthday
        {
            get { return (DateTime)GetValue(BirthdayProperty); }
            set { SetValue(BirthdayProperty, value); }
        }

        
        /// <summary>
        /// The NotifyingProperty for the EmailAddress property.
        /// </summary>
        private readonly NotifyingProperty EmailAddressProperty =
          new NotifyingProperty("EmailAddress", typeof(string), default(string));

        /// <summary>
        /// Gets or sets EmailAddress.
        /// </summary>
        /// <value>The value of EmailAddress.</value>
        public string EmailAddress
        {
            get { return (string)GetValue(EmailAddressProperty); }
            set { SetValue(EmailAddressProperty, value); }
        }

    }
}

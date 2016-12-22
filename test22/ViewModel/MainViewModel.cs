using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test22.Model;
using System.Windows;
using System.Windows.Input;

namespace test22.ViewModel
{
    class MainViewModel
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        public MainViewModel()
        {
            ClickCommand = new Command(arg => ClickMethod());
            People = new PeopleModel
            {
                FirstName = "First name",
                LastName = "Last name"
            };
        }

        /// <summary>
        /// Get or set people.
        /// </summary>
        public PeopleModel People { get; set; }

        /// <summary>
        /// Get or set ClickCommand.
        /// </summary>
        public ICommand ClickCommand { get; set; }

        /// <summary>
        /// Click method.
        /// </summary>
        private void ClickMethod()
        {
            MessageBox.Show("This is click command.");
        }

       
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace session7_projects
{
    /// <summary>
    /// Interaction logic for UpdateSourceTriggerExample.xaml
    /// </summary>
    public partial class UpdateSourceTriggerExample : Window
    {
        public UpdateSourceTriggerExample()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        private void btnUpdateSource_Click(object sender, RoutedEventArgs e)
        {
            BindingExpression binding = 
                txtWindowTitle.GetBindingExpression(TextBox.TextProperty);

            binding.UpdateSource();
        }
    }
}

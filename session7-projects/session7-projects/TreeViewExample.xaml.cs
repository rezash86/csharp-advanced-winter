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
    /// Interaction logic for TreeViewExample.xaml
    /// </summary>
    public partial class TreeViewExample : Window
    {
        TreeViewItem item = new TreeViewItem();
        public TreeViewExample()
        {
            InitializeComponent();
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            this.item =  getTreeItem();
            tvChars.Items.Add(this.item);
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            if (tvChars.Items.Contains(this.item)){
                tvChars.Items.Remove(this.item);
            }
        }

        public TreeViewItem getTreeItem()
        {
            TreeViewItem treeViewItem = new TreeViewItem();
            treeViewItem.Header = "C";
            treeViewItem.Items.Add(new TreeViewItem() { Header = "CC1" });
            treeViewItem.Items.Add(new TreeViewItem() { Header = "CC2" });

            return treeViewItem;
        }
    }
}

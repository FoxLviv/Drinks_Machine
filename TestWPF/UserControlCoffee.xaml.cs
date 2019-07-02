using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TestWPF
{
    /// <summary>
    /// Логика взаимодействия для UserControlCoffee.xaml
    /// </summary>
    public partial class UserControlCoffee : UserControl
    {
        public UserControlCoffee()
        {
            InitializeComponent();
        }

        private void ListViewOptions_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index = ListViewOptions.SelectedIndex;
            
            switch(index)
            {
                case 0:
                    break;
                default:
                    break;
                    
            }
        }
    }
}

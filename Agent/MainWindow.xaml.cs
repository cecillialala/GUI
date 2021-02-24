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
using System.Windows.Navigation;
using System.Windows.Shapes;
using AgentAssignment;

namespace Agent
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {         
        public MainWindow()
        {


        }

        private void buttonBack_Click(object sender, RoutedEventArgs e)
        {
            if (ListboxAgentnames.SelectedIndex > 0)
            {
                ListboxAgentnames.SelectedIndex = --ListboxAgentnames.SelectedIndex;
            }
        }

        private void buttonForward_Click(object sender, RoutedEventArgs e)
        {
            if (ListboxAgentnames.SelectedIndex < ListboxAgentnames.Items.Count-1)
            {
                ListboxAgentnames.SelectedIndex = ++ListboxAgentnames.SelectedIndex;
            }
        }

        private void buttonAdd_Click(object sender, RoutedEventArgs e)
        {
            var addEnAgent = DataContext as MainWindowViewModel;
            addEnAgent.addNewAgent();
            ListboxAgentnames.SelectedIndex = ListboxAgentnames.Items.Count - 1;
            ListboxAgentnames.Focus();
        }
    }
}

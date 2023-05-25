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

namespace RepairRequests2
{
    /// <summary>
    /// Логика взаимодействия для ChangeRequestWindow.xaml
    /// </summary>
    public partial class ChangeRequestWindow : Window
    {
        public ChangeRequestWindow()
        {
            InitializeComponent();
        }

        private void ChangeRequest_Click(object sender, RoutedEventArgs e)
        {

        }

        public void ChangeRequest(Request request)
        {
            //request.fio = 
        }
    }
}

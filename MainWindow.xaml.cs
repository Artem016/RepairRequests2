using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace RepairRequests2
{       
    public partial class MainWindow : Window
    {
        public SerialiseRequst serialiseRequst = new SerialiseRequst();
        public static MainWindow mainWindow;
        public List<Request> ListOfRequest;

        public MainWindow()
        {
            mainWindow = this;
            InitializeComponent();
            ListOfRequest = serialiseRequst.DeserializeListOfRequest();
            AddOldRequests();
        }

        private void AddRequest_Click(object sender, RoutedEventArgs e) //открытие окна для добавления заявки
        {           
            AddRequestWindow addRequestWindow = new AddRequestWindow();
            addRequestWindow.Show();
            addRequestWindow.Owner = this;
        }

        public void AddOldRequests() //добавление страрых заявок при запуске программы.
        {
            foreach (var request in ListOfRequest)
            {
                Request.AddButtonRequest(request);
            }
        }
    }
}

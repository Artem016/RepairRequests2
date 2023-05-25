using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace RepairRequests2
{
    /// <summary>
    /// Логика взаимодействия для AddRequest.xaml
    /// </summary>
    public partial class AddRequestWindow : Window
    {
        SerialiseRequst serialiseRequst = new SerialiseRequst();

        public AddRequestWindow()
        {
            InitializeComponent();
        }

        private void SaveRequest_Click(object sender, RoutedEventArgs e)
        {
            Request request = new Request(FioTextBox.Text,
                TypeEquipmenTextBox.Text,
                BrandEquimenTextBox.Text,
                ModelEquimenTextBox.Text,
                DiscriptionProblemTextBox.Text,
                false, 
                DateTime.Now);//создание обьекта заявки.

            MainWindow.mainWindow.ListOfRequest.Add(request);
            serialiseRequst.SerialiseListOfRequst(MainWindow.mainWindow.ListOfRequest);

            Request.AddButtonRequest(request);
            this.Close();
        }
    }
}

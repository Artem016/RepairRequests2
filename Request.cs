using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace RepairRequests2
{

    [Serializable] public class Request
    {
        public string fio;
        public string typeEquipmen;
        public string brandEquimen;
        public string modelEquimen;
        public string discriptionProblem;
        public bool isDone;
        DateTime dateRequest;

        public Request(string fio, string typeEquipmen, string brandEquimen, string modelEquimen, string discriptionProblem, bool isDone, DateTime dateRequest)
        {
            this.fio = fio;
            this.typeEquipmen = typeEquipmen;
            this.brandEquimen = brandEquimen;
            this.modelEquimen = modelEquimen;
            this.discriptionProblem = discriptionProblem;
            this.isDone = isDone;
            this.dateRequest = dateRequest;
        }

        public static void AddButtonRequest(Request request)
        {
            Button newButtonRequest = new Button();
            newButtonRequest.Content = $"{request.fio} --> {request.typeEquipmen}";
            MainWindow.mainWindow.StackOfRequst.Children.Add(newButtonRequest);
        }

        private void RequestButton_Click(object sender, RoutedEventArgs e)
        {
            AddRequestWindow addRequestWindow = new AddRequestWindow();
            addRequestWindow.Show();
            addRequestWindow.Owner = MainWindow.mainWindow;
        }

    }
}

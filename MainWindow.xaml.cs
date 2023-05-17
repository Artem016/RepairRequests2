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

namespace RepairRequests2
{       
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }//Стандартаная команда появления главного окна

        private void AddRequest_Click(object sender, RoutedEventArgs e)
        {
            //С помощья Cntr + Shift + A мы создаем новое окно для программы.
            AddRequestWindow addRequestWindow = new AddRequestWindow();
            //Создаем обьект данного окна, при нажатии на кнопку, чтобы можно было показать его пользователю.
            addRequestWindow.Show();//показываем пользователю окно
            addRequestWindow.Owner = this;//иницаализация окна MainWindow как владельца окна AddRequestWindow, то есть при закрытии галвног окна, закрывается и дочернее, но не наоборот.
        }

        internal bool isDoneShow;

        private void IsDoneShow_Checked(object sender, RoutedEventArgs e)
        {
            isDoneShow = true;
        }
    }
}

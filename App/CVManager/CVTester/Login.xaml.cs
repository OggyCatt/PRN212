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

namespace CVTester
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("Login Successful", "Đăng nhập thành công rùi", MessageBoxButton.OK, MessageBoxImage.Hand);
            //gọi màn hình mycv
            //mỗi class mỗi màn hình là 1 class có thêm phần render, vậy ta cứ oop như truyền thống
            //tạo biến object và new, và khi new tức là show ra màn hình
            MyCV mycv = new MyCV(); //1 cửa sổ đã vào ram, hàm show để render UI
            //mycv.Show();
            //Hàm show() của 1 cửa sổ xong cửa này mới ra cửa khác Show Dialog
            mycv.ShowDialog();


        }

        private void CanncelButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult answer = MessageBox.Show("Sure?", "Exit", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if(answer == MessageBoxResult.Yes)
            {
                Application.Current.Shutdown();
            }
        }
    }
}

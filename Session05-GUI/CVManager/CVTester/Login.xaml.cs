using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.RightsManagement;
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

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("HELLO WPF", "Xin chào", MessageBoxButton.OK, MessageBoxImage.Hand);
            //gọi màn hình MyCV show lên
            //mỗi màn hình là 1 class, có thêm phần render mà thôi. Vậy ta cứ OOP như truyền thống
            //tạo biến object và new, khi new màn hình tức là show ra màn hình
            //hàm set của ô nhập

            //BẮT Ô NHẬP USERNAME, ĐANG MANG TÊN LÀ USERNAMETEXTBOX
            UserNameTextBox.Text = "NGOC TRINH EM OI";
            string username = UserNameTextBox.Text;
            MessageBox.Show("Bạn vừa gõ username " + username);

            MyCV myCV = new MyCV(); //1 cửa sổ đã vào ram và gọi hàm của vùng new, hàm show, để render UI
            //myCV.Show();
            //hàm Show() của 1 cửa sổ vẫn cho phép mình vòng về cửa sổ trc đó
            //nêú ta muốn, xong cửa sổ này mới trở ra cửa sổ khác, ta cần chọn chế độ show Dialog - chế độ hội thoại - xong rồi mới quay về
            myCV.ShowDialog();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
              MessageBoxResult answer = MessageBox.Show("Do you really want to exit?", "Exit?", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (answer == MessageBoxResult.Yes)
            {
                Application.Current.Shutdown();
            }
            
        }

      
    }
}

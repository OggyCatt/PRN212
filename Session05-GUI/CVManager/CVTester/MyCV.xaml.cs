using CVTester.Entities;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CVTester
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MyCV : Window
    {
        public MyCV()
        {
            InitializeComponent();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void LoadButton_Click(object sender, RoutedEventArgs e)
        {
            //chuẩn bị ds ứng viên, đưa vào data grid
            // grid nó chuyên cho việc: ai đưa 1 List, là nó hiển thị
            // ta cần có ds ứng viên, List<Candidate>
            // list này thg lấy từ db, table Candidae Tương ứng. Bay h hard-coded trc,  lấy db sau

            List<Candidate> arr = new List<Candidate>();

            arr.Add(new Candidate() { Id = "CFE01", Name = "AN NGUYEN", Yob = 2000, Position = "Front-end intern"});
            arr.Add(new Candidate() { Id = "CBE02", Name = "BINH LE", Yob = 2000, Position = "Back-end intern" });
            arr.Add(new Candidate() { Id = "CNETF01", Name = "CUONG VO", Yob = 2000, Position = ".NET Full-stack" });

            CandidateListDataGrid.ItemsSource = arr;
            


        }
    }
}
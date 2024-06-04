using System.IO;
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

namespace WpfApp5;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private IList<string> _listStudent = new List<string>();
    public MainWindow()
    {
        InitializeComponent();
    }

    private void BtnGenerate_OnClick(object sender, RoutedEventArgs e)
    {
        if(!File.Exists("List.txt"))
            return;
        var text = File.ReadAllText("List.txt");
        var listStudent = text.Split('\n');
        Random rnd = new Random();
        int index = rnd.Next(0, listStudent.Length);
        string currentFio = listStudent[index];
        if (!StudentList.Items.Contains(currentFio))
            StudentList.Items.Add(currentFio);
    }

    private void BtnClear_OnClick(object sender, RoutedEventArgs e)
    {
        StudentList.Items.Clear();
    }
}
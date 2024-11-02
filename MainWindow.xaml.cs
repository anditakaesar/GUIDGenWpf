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

namespace GUIDGenWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            prefillControls();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Guid guid = Guid.NewGuid();
            textGuid1.Text = guid.ToString();
            textGuid1.Focus();
            string originalText = textBoxHistory.Text;
            textBoxHistory.Text = guid.ToString() + Environment.NewLine + originalText;
        }

        private void textGuid_GotFocus(object sender, RoutedEventArgs e)
        {
            var textBox = sender as TextBox;
            if (textBox != null)
            {
                textBox.SelectAll();
                textBox.Copy();
            }
        }

        private void prefillControls()
        {
            Guid guid = Guid.NewGuid();
            textGuid1.Text = guid.ToString();
            textGuid1.Focus();
            string originalText = textBoxHistory.Text;
            textBoxHistory.Text = guid.ToString() + Environment.NewLine + originalText;
        }

        private void checkBoxOnTop_Toggled(object sender, RoutedEventArgs e)
        {
            if (checkBoxOnTop.IsChecked == true)
            {
                this.Topmost = true;
                return;
            }
            this.Topmost = false;
        }
    }
}

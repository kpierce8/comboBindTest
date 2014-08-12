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

namespace ComboBindTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Button1.Click += Button3_Click;
            Button2.Click += Button3_Click;
            Button3.Click += Button3_Click;
        }

        void Button3_Click(object sender, RoutedEventArgs e)
        {
            string lcNow;
            if (sender.GetType().Name.Equals("Button"))
            {
                lcNow = ((Button)sender).CommandParameter.ToString();
            }
            else
            {
                lcNow = LandCoverTextBlock.Text;
            }

            LandCoverButtonHighlight(lcNow);
        }

       



        private void TextBlock_TextInput(object sender, TextCompositionEventArgs e)
        {
            MessageBox.Show("yo");
        }

        private void TextBlock_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            MessageBox.Show("yo2");
        }

        private void mainLB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            LandCoverButtonHighlight(LandCoverTextBlock.Text);
        }


        private void LandCoverButtonHighlight(string lc)
        {

            Style st1 = (Style)this.FindResource("ButtonStyle1");
            Style st2 = (Style)this.FindResource("ButtonStyle2");

            if (Button1.CommandParameter.Equals(lc))
            {
                Button1.Style = st1;
            }
            else { Button1.Style = st2; }

            if (Button2.CommandParameter.Equals(lc))
            {
                Button2.Style = st1;
            }
            else { Button2.Style = st2; }

            if (Button3.CommandParameter.Equals(lc))
            {
                Button3.Style = st1;
            }
            else { Button3.Style = st2; }
        }

    }
}

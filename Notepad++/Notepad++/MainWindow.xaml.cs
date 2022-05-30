using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.IO;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Diagnostics;
using System.Windows.Navigation;
using System.Collections.ObjectModel;
using Microsoft.Win32;

namespace Notepad__
{
    public partial class MainWindow : Window
    {
        private ObservableCollection<TabItem> tabitems;
        private TabItem AddTab;
       
        public MainWindow()
        {           
                InitializeComponent();

                tabitems = new ObservableCollection<TabItem>();           

                this.AddTabItem();
        
                tabDynamic.DataContext = tabitems;

                tabDynamic.SelectedIndex = 0;          
        }

        private TabItem AddTabItem()
        {
            int count = tabitems.Count+1;

            TabItem tab = new TabItem();

            tab.Header = string.Format("File {0}", count);
            tab.Name = string.Format("file{0}", count);
            tab.HeaderTemplate = tabDynamic.FindResource("TabHeader") as DataTemplate;
            tab.MouseDoubleClick += new MouseButtonEventHandler(tab_MouseDoubleClick);

            TextBox txt = new TextBox();
            txt.Name = "txt";

            tab.Content = txt;

            tabitems.Insert(count - 1, tab);

            return tab;
        }

        private void tab_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            TabItem tab = sender as TabItem;

            TabProperty dlg = new TabProperty();

            dlg.txtTitle.Text = tab.Header.ToString();

            if (dlg.ShowDialog() == true)
            {
                tab.Header = dlg.txtTitle.Text;
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            string tabName = (sender as Button).CommandParameter.ToString();
           
            TabItem tab = tabDynamic.SelectedItem as TabItem;

            if (tab != null)
            {              
                MessageBox.Show("This tab content is not saved");

                SaveAsButton_Click(sender, e);

                TabItem selectedTab = tabDynamic.SelectedItem as TabItem;

                tabDynamic.DataContext = null;

                tabitems.Remove(tab);

                tabDynamic.DataContext = tabitems;

                tabDynamic.SelectedItem = selectedTab;
            }
        }

        private void AboutButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Toader Adrian\n" +
               "Grupa 10LF303");
        }

        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Uri.AbsoluteUri);
        }
        
        private void NewButton_Click(object sender, RoutedEventArgs e)
        {
            tabDynamic.DataContext = null;

            TabItem newTab = this.AddTabItem();

            tabDynamic.DataContext = tabitems;

            tabDynamic.SelectedItem = newTab;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();

            if (tabDynamic.SelectedItem == null)
            {
                MessageBox.Show("Tab inexistent");
            }
            else
            {
                dialog.FileName = (tabDynamic.SelectedItem as TabItem).Header.ToString();

                dialog.DefaultExt = ".txt";

                File.WriteAllText(dialog.FileName, (tabDynamic.SelectedItem as TabItem).Content.ToString());
            }
        }

        private void OpenButton_Click(object sender, RoutedEventArgs e)
        {                    
                OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == true)
            {
                tabDynamic.DataContext = null;

                TabItem newTab = this.AddTabItem();

                tabDynamic.DataContext = tabitems;

                newTab.Content= File.ReadAllText(openFileDialog.FileName);

                newTab.Header = openFileDialog.FileName;

                tabDynamic.SelectedItem = newTab;               
            }
        }

        private void SaveAsButton_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "Text file (*.txt)|*.txt|C# file (*.cs)|*.cs|All Files (*.*)|*.*";

            saveFileDialog.FileName= (tabDynamic.SelectedItem as TabItem).Header.ToString();

            if (saveFileDialog.ShowDialog() == true)
                File.WriteAllText(saveFileDialog.FileName, (tabDynamic.SelectedItem as TabItem).Content.ToString());
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void FindButton_Click(object sender, RoutedEventArgs e)
        {
            FindMenu fd = new FindMenu();
            fd.ShowDialog();
            if ((tabDynamic.SelectedItem as TabItem).Content.ToString().Contains(fd.text.Text).ToString() == "True")
            {
                MessageBox.Show("String found");
            }
            else
                MessageBox.Show("String doesn't exist");
        }

        private void ReplaceButton_Click(object sender, RoutedEventArgs e)
        {
            ReplaceMenu rep = new ReplaceMenu();
            rep.ShowDialog();
        
            TabItem tab = (tabDynamic.SelectedItem as TabItem);

            if ((tabDynamic.SelectedItem as TabItem).Content.ToString().Contains(rep.find.Text).ToString() == "True")
            {
                tab.Content.ToString().Replace(rep.find.Text, rep.replace.Text);
                //(tabDynamic.SelectedItem as TabItem).Content = tab.Content;
                MessageBox.Show(tab.Content.ToString());
            }
            else
                MessageBox.Show("The given word doesn't exist");

        }

        private void ReplaceAllButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

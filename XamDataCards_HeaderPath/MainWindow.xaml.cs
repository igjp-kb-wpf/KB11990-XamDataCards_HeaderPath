using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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

namespace XamDataCards_HeaderPath
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<TestData> testData = null;
        public MainWindow()
        {
            InitializeComponent();

            testData = new ObservableCollection<TestData>();


            for (int i = 0; i < 10; i++)
            {
                testData.Add(new TestData { Id = "item " + i, Test1 = "Test" + i, Test2 = i  });
            }

            this.DataContext = testData;
        }
    }

    public class TestData : INotifyPropertyChanged
    {
        private String m_id;
        public String Id
        {
            get { return m_id; }
            set
            {
                m_id = value;
                NotifyPropertyChanged("Id");
            }
        }

        private String m_test1;
        public String Test1
        {
            get { return m_test1; }
            set
            {
                m_test1 = value;
                NotifyPropertyChanged("Test1");
            }
        }

        private int m_test2;
        public int Test2
        {
            get { return m_test2; }
            set
            {
                m_test2 = value;
                NotifyPropertyChanged("Test2");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
    }
}

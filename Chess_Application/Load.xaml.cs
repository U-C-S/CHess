using System;
using System.Windows;
using System.Windows.Threading;

namespace Chess_Application
{
    /// <summary>
    /// Interaction logic for Load.xaml
    /// </summary>
    public partial class Load : Window
    {
        private void Draggable(object sender, RoutedEventArgs e) => DragMove();

        private DispatcherTimer loadtime = new DispatcherTimer();
        public Load()
        {
            InitializeComponent();
            loadtime.Tick += new EventHandler(LoadFinish);
            loadtime.Interval = new TimeSpan(0, 0, 7);
            loadtime.Start();
        }
        private void LoadFinish(object sender, EventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            loadtime.Stop();
            this.Close();
        }
    }
}

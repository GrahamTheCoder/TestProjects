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

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for VsWindow.xaml
    /// </summary>
    public partial class VsWindow : Window, IActivatable
    {
        public VsWindow()
        {
            InitializeComponent();
            m_Beaky.TieToControl(this);
        }

  
        private void bob3_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }



        
    }

    public interface IActivatable
    {
        WindowState WindowState { get; set; }
        event EventHandler StateChanged;
        event EventHandler Activated;
        event EventHandler Deactivated;
        event RoutedEventHandler Loaded;
        event RoutedEventHandler Unloaded;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
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

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for Beaky.xaml
    /// </summary>
    public partial class Beaky 
    {
        public Beaky()
        {
            InitializeComponent();
        }

        public void TieToControl(IActivatable parent)
        {
            parent.StateChanged += (_, __) => IsOpen = parent.WindowState != WindowState.Minimized;
            parent.Activated += (_, __) => IsOpen = true;
            parent.Deactivated += (_, __) => IsOpen = false;
        }

    }

}

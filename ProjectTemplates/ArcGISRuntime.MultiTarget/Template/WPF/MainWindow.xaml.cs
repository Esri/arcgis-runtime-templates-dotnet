using Esri.ArcGISRuntime.UI;
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

namespace $ext_safeprojectname$.WPF
{
    /// <summary>
    /// Interaction logic for $safeitemrootname$.xaml
    /// </summary>
    public partial class $safeitemrootname$ : Window
    {
        public $safeitemrootname$()
        {
            InitializeComponent();
            this.DataContext = new $ext_safeprojectname$.MapViewModel();
        }

        // Map initialization logic is contained in MapViewModel.cs
    }
}

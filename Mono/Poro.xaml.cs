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

namespace Mono
{
    /// <summary>
    /// Interaction logic for Poro.xaml
    /// </summary>
    public partial class Poro : UserControl
    {
        public Poro()
        {
            InitializeComponent();
        }

        public void Add(string player)
        {
            listBox.Items.Add(player);
        }

        public Brush Position
        {
            set
            {

            }
        }
    }
}

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
    /// Interaction logic for Token.xaml
    /// </summary>
    public partial class Token : UserControl
    {
        public List<int> Player { get; set; }
        public int Position { get; set; }
        public int State
        {
            set
            {
                switch (value)
                {
                    case 1:

                        break;
                }
            }
        }

        public Token()
        {
            InitializeComponent();

            Position = 1;
        }
    }
}

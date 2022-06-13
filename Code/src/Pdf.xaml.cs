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

namespace ProjekatSIMS
{
    /// <summary>
    /// Interaction logic for Pdf.xaml
    /// </summary>
    public partial class Pdf : Window
    {
        public Pdf()
        {
            InitializeComponent();
            pdfWebViewer.Navigate(new Uri("about:blank"));
            pdfWebViewer.Navigate(@"C:\Users\Ryzen\Desktop\FAX\SIMS\SIMS\Code\src\Reports\MedicineReport.pdf");
        }
    }
}

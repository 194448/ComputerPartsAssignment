/* Thomas Tipper Festing
 * Feb 21, 2020
 * Computer Build Assignment
 */
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

namespace ComputerAssignment
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //information about phone battery and desktop
            lblCostOutput.Content = "Subtotal: $775.55 ";
            lblExplanationOutput.Content = "In the case of picking a new battery as opposed to a new phone, a new battery is " +
                Environment.NewLine + "much more affordable while also being more enviormentally friendly. " +
                Environment.NewLine + "For the desktop parts: there is enough power to run programs such " +
                Environment.NewLine + "as CAD without wasting too much money on a high-end GPU, Decent RAM with room for upgrades, " +
                Environment.NewLine + "a good motherboard, a CPU that can be overclocked if needed, " +
                Environment.NewLine + "and a power supply that can provide enough energy and still have room for more consumtion." +
                Environment.NewLine + "All within an affordable budget!";
            lblPartsOutput.Content = "The parts used for the desktop include:" +
                Environment.NewLine + "- A Cooler Master MasterBox E500L Case" +
                Environment.NewLine + "(https://www.canadacomputers.com/product_info.php?cPath=6_112&item_id=137212)" +
                Environment.NewLine + Environment.NewLine + "- A GIGABYTE H370 HD3 Motherboard" +
                Environment.NewLine + "(https://www.canadacomputers.com/product_info.php?cPath=26_1842_1846&item_id=121074)" +
                Environment.NewLine + Environment.NewLine + "- An Intel i5-9400F Coffee Lake 6-Core CPU" +
                Environment.NewLine + "(https://www.canadacomputers.com/product_info.php?cPath=4_65&item_id=132428)" +
                Environment.NewLine + Environment.NewLine + "- 8GB of Corsair Vengeance RAM" +
                Environment.NewLine + "(https://www.canadacomputers.com/product_info.php?cPath=24_311_1326&item_id=098182)" +
                Environment.NewLine + Environment.NewLine + "- A ASUS GeForce GT 1030 GPU with 2GB of memory" +
                Environment.NewLine + "(https://www.canadacomputers.com/product_info.php?cPath=43_557_559&item_id=108604)" +
                Environment.NewLine + Environment.NewLine + "- A 600W Cooler Master MasterWatt Lite Powe Supply" +
                Environment.NewLine + "(https://www.canadacomputers.com/product_info.php?cPath=33_442&item_id=109062)" +
                Environment.NewLine + Environment.NewLine + "- 1TB of seagate HHD storage" +
                Environment.NewLine + "(https://www.canadacomputers.com/product_info.php?cPath=15_1086_210_212&item_id=100444)" +
                Environment.NewLine + Environment.NewLine + "- a Asus 24x DVD-RW Disc Drive" +
                Environment.NewLine + "(https://www.amazon.ca/Asus-Serial-ATA-Internal-Optical-DRW-24B1ST/dp/B0033Z2BAQ/ref=sr_1_6?keywords=disk+drive+internal&qid=1581525094&sr=8-6)" +
                Environment.NewLine + Environment.NewLine + Environment.NewLine + "and a new phone battery" +
                Environment.NewLine + "(https://www.amazon.ca/BEST-SHOPPER-Replacement-Rechargeable-Lithium-ion/dp/B07HFH5FZR)";
        }
        //radiobuttons to toggle visibility of the different texts
        private void rbtnPartsList_Checked(object sender, RoutedEventArgs e)
        {
            lblPartsOutput.Visibility = Visibility.Visible;
        }

        private void rbtnExplanation_Checked(object sender, RoutedEventArgs e)
        {
            lblExplanationOutput.Visibility = Visibility.Visible;
        }

        private void rbtnCost_Checked(object sender, RoutedEventArgs e)
        {
            lblCostOutput.Visibility = Visibility.Visible;
            btnTotal.Visibility = Visibility.Visible;
        }

        private void rbtnCost_Unchecked(object sender, RoutedEventArgs e)
        {
            lblCostOutput.Visibility = Visibility.Collapsed;
            btnTotal.Visibility = Visibility.Collapsed;
            lblTotal.Content = null;
        }

        private void rbtnExplanation_Unchecked(object sender, RoutedEventArgs e)
        {
            lblExplanationOutput.Visibility = Visibility.Collapsed;
        }

        private void rbtnPartsList_Unchecked(object sender, RoutedEventArgs e)
        {
            lblPartsOutput.Visibility = Visibility.Collapsed;
        }


        //button to calculate total cost of parts from the subtotal
        private void btnTotal_Click(object sender, RoutedEventArgs e)
        {
            double sub;
            double Total;
            sub = 775.55;
            Total = sub * 1.13;
            lblTotal.Content = "Total: " + Total.ToString("#.00");
        }
    }
}
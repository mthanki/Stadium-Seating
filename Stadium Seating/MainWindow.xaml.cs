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

namespace Stadium_Seating
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        const decimal CLASS_A_COST = 15;
        const decimal CLASS_B_COST = 12;
        const decimal CLASS_C_COST = 9;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void CalculateTotalIncome_Click(object sender, RoutedEventArgs e)
        {
            decimal NumberOfClassATicketsSold = int.Parse(ClassAticketsBox.Text);
            decimal NumberOfClassBTicketsSold = int.Parse(ClassBticketsBox.Text);
            decimal NumberOfClassCTicketsSold = int.Parse(ClassCticketsBox.Text);

            decimal TotalIncomeFromClassAsales = NumberOfClassATicketsSold * CLASS_A_COST;
            decimal TotalIncomeFromClassBsales = NumberOfClassBTicketsSold * CLASS_B_COST;
            decimal TotalIncomeFromClassCsales = NumberOfClassCTicketsSold * CLASS_C_COST;

            decimal TotalIncomeFromAllSales = TotalIncomeFromClassAsales + TotalIncomeFromClassBsales + TotalIncomeFromClassCsales;

            ClassAticketsTotalIncome.Content = TotalIncomeFromClassAsales;
            ClassBticketsTotalIncome.Content = TotalIncomeFromClassBsales;
            ClassCticketsTotalIncome.Content = TotalIncomeFromClassCsales;

            TotalTicketsIncome.Content = TotalIncomeFromAllSales;
        }
    }
}

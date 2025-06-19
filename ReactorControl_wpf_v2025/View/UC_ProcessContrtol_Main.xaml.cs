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
using ReactorControl.View;

namespace ReactorControl.View
{
	/// <summary>
	/// UC_ProcessContrtol_Main.xaml에 대한 상호 작용 논리
	/// </summary>
	public partial class UC_ProcessContrtol_Main : UserControl
	{
		public UC_ProcessContrtol_Main()
		{
			InitializeComponent();
		}

		private void SSDM_Click(object sender, RoutedEventArgs e)
		{
			MainWindow.mainWindow.ContentsArea.Content = new UC_SSDM();
		}

		private void BPID_Click(object sender, RoutedEventArgs e)
		{
			MainWindow.mainWindow.ContentsArea.Content = new UC_BP_ID();
		}

		private void RWS_Click(object sender, RoutedEventArgs e)
		{
			MainWindow.mainWindow.ContentsArea.Content = new UC_RWS();
		}

		private void DWPF_Click(object sender, RoutedEventArgs e)
		{
			MainWindow.mainWindow.ContentsArea.Content = new UC_DWPF1();
		}

		private void SCS_Click(object sender, RoutedEventArgs e)
		{
			MainWindow.mainWindow.ContentsArea.Content = new UC_SCS1();
		}

		private void EWSS_Click(object sender, RoutedEventArgs e)
		{
			MainWindow.mainWindow.ContentsArea.Content = new UC_EWSS();
		}

		private void PCS_Click(object sender, RoutedEventArgs e)
		{
			MainWindow.mainWindow.ContentsArea.Content = new UC_PCS1();
		}

		private void SWS_Click(object sender, RoutedEventArgs e)
		{
			MainWindow.mainWindow.ContentsArea.Content = new UC_SWS1();
		}

		private void HGSS_Click(object sender, RoutedEventArgs e)
		{
			MainWindow.mainWindow.ContentsArea.Content = new UC_HGSS();
		}

		private void HWLS_Click(object sender, RoutedEventArgs e)
		{
			MainWindow.mainWindow.ContentsArea.Content = new UC_HWLS1();
		}

		private void HWS_Click(object sender, RoutedEventArgs e)
		{
			MainWindow.mainWindow.ContentsArea.Content = new UC_HWS();
		}

		private void CAS_Click(object sender, RoutedEventArgs e)
		{
			MainWindow.mainWindow.ContentsArea.Content = new UC_CAS1();
		}

		private void SRS_Click(object sender, RoutedEventArgs e)
		{
			MainWindow.mainWindow.ContentsArea.Content = new UC_SRS1();
		}

		private void LRS_Click(object sender, RoutedEventArgs e)
		{
			MainWindow.mainWindow.ContentsArea.Content = new UC_LRS1();
		}

		private void PC_Click(object sender, RoutedEventArgs e)
		{
			Button btn = sender as Button;
			if (btn.Tag.ToString() == "ADS")
			{
				MainWindow.mainWindow.ContentsArea.Content = new UC_PC_ADS1();
			}
			else if (btn.Tag.ToString() == "EPSS")
			{
				MainWindow.mainWindow.ContentsArea.Content = new UC_EPSS1();
			}
		}
	}
}

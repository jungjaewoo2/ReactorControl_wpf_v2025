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

namespace ReactorControl.View
{
    /// <summary>
    /// UC_EPSS1.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class UC_EPSS1 : UserControl
    {
        public UC_EPSS1()
        {
            InitializeComponent();
        }

        private void Btn_CLD_Click(object sender, RoutedEventArgs e)
        {
            // CLD(Control Logic Diagram) 버튼 클릭 처리
        }

        private void PumpObject_Click(object sender, MouseButtonEventArgs e)
        {
            // 펌프 객체 클릭 처리
            if (sender is Image)
            {
                Image pumpImage = sender as Image;
                string pumpTag = pumpImage.Tag.ToString();
                
                // 펌프 상태 토글
                if (pumpImage.Source.ToString().Contains("pump_on"))
                {
                    pumpImage.Source = new BitmapImage(new Uri("/Images/obj_pump_off.png", UriKind.Relative));
                }
                else
                {
                    pumpImage.Source = new BitmapImage(new Uri("/Images/obj_pump_on.png", UriKind.Relative));
                }
            }
        }

        private void Btn_SLD_Click(object sender, RoutedEventArgs e)
        {
            // SLD(System Logic Diagram) 버튼 클릭 처리
        }

        private void Btn_PID_Click(object sender, RoutedEventArgs e)
        {
            // PID(Process & Instrumentation Diagram) 버튼 클릭 처리
        }
    }
} 
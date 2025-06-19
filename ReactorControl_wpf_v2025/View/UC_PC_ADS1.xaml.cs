using ReactorControl.Popup;
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
using static System.Net.Mime.MediaTypeNames;

namespace ReactorControl.View
{
	/// <summary>
	/// UC_ProcessControl.xaml에 대한 상호 작용 논리
	/// </summary>
	public partial class UC_PC_ADS1 : UserControl
	{
		public UC_PC_ADS1()
		{
			InitializeComponent();
		}

		private void Btn_CLD_Click(object sender, RoutedEventArgs e)
		{
			Console.WriteLine("Btn_CLD_Click");

			//pp_001.Source = new BitmapImage(new Uri("pack://application:,,,/Images/obj_pump_on.png"));
			//pp_001.InvalidateVisual(); // 수동으로 다시 그리기 요청

			// 갱신이 되지 않음
			//pp_001.Dispatcher.Invoke(System.Windows.Threading.DispatcherPriority.Render, new Action(() => { }));

		}

		private void Btn_SLD_Click(object sender, RoutedEventArgs e)
		{
			Console.WriteLine("Btn_SLD_Click");
			//pp_001.Source = new BitmapImage(new Uri("pack://application:,,,/Images/obj_pump_off.png"));
			//pp_001.InvalidateVisual(); // 수동으로 다시 그리기 요청

			// 갱신이 되지 않음
			//pp_001.Dispatcher.Invoke(System.Windows.Threading.DispatcherPriority.Render, new Action(() => { }));
		}

		private void Btn_PID_Click(object sender, RoutedEventArgs e)
		{
			Console.WriteLine("Btn_PID_Click");
		}

		private void PumpObject_Click(object sender, RoutedEventArgs e)
		{
			// case2. 미리 작성한 xaml사용
			Popup_ProcessControl1 popup = new Popup_ProcessControl1(this);
			popup.ShowDialog();
		}


		// public으로 보안에 취약 하므로
		public System.Windows.Controls.Image PUBLIC_pp001 => pp_001;

		public BitmapImage UpdatePumpImage(string imagePath)
		{
			Console.WriteLine("UpdatePumpImage()-imagePath={0}", imagePath);
			var bitmap = new BitmapImage();
			try
			{
				bitmap.BeginInit();
				bitmap.UriSource = new Uri(imagePath, UriKind.Relative);
				bitmap.CacheOption = BitmapCacheOption.OnLoad; // 즉시 로드
				bitmap.CreateOptions = BitmapCreateOptions.IgnoreImageCache; // 캐시 무시
				bitmap.EndInit();
				pp_001.Source = bitmap;
				return bitmap;
			}
			catch (Exception ex)
			{
				MessageBox.Show("이미지 로딩 실패: " + ex.Message);
				return bitmap;
			}
		}



		/// <summary>
		/// 밸브 열림/닫힘에 따라 이미지 변경
		/// </summary>
		/// <param name="_objectName"></param>
		/// <param name="_value"></param>
		public void ValueControl(String _objectName, String _value)
		{
			// _objectName=PP-001,_value=open
			Console.WriteLine("_objectName={0},_value={1}", _objectName, _value);

			if (_objectName == "PP-001")
			{
				if (_value == "open")
				{
					// 이미지 파일의 속성이 Resource 로 변경 -> 변경되지 않음 ㅠㅠ
					pp_001.Source = new BitmapImage(new Uri("pack://application:,,,/Images/obj_pump_on.png"));
					pp_001.InvalidateVisual(); // 수동으로 다시 그리기 요청

					// 갱신이 되지 않음
					pp_001.Dispatcher.Invoke(System.Windows.Threading.DispatcherPriority.Render, new Action(() => { }));

					return;



					// 파일 없음 -> 속성을 "빌드 컨텐츠" 로 변경 -> Debug아래 생성은 되지만 xaml에서 사용할수 없음 ㅠㅠ -> 빌등작업: 내용으로 변경 -> 정상적으로 Images폴더가 생성됨
					Console.WriteLine("_objectName={0},_change image ON", _objectName);
					BitmapImage bitmapImage = UpdatePumpImage("Images/obj_pump_on.png");

					Dispatcher.Invoke(() =>
					{
						pp_001.Source = bitmapImage;
						pp_001.InvalidateVisual(); // 수동으로 다시 그리기 요청
					});

					//pp_001.Source = bitmapImage;	// new BitmapImage(new Uri("/Images/obj_pump_on.png", UriKind.Relative));
				}
				else
				{
					Console.WriteLine("_objectName={0},_change image OFF", _objectName);
					BitmapImage bitmapImage = UpdatePumpImage("Images/obj_pump_off.png");
					Dispatcher.Invoke(() =>
					{
						pp_001.Source = bitmapImage;
						pp_001.InvalidateVisual(); // 수동으로 다시 그리기 요청
					});
					//pp_001.Source = bitmapImage;		// new BitmapImage(new Uri("/Images/obj_pump_off.png", UriKind.Relative));
				}
			}
			else if (_objectName == "PP-002")
			{
				if (_value == "open")
				{
					Console.WriteLine("_objectName={0},_change image on", _objectName);
					pp_002.Source = new BitmapImage(new Uri("Images/obj_pump_on.png", UriKind.Relative));
				}
				else
				{
					Console.WriteLine("_objectName={0},_change image off", _objectName);
					pp_002.Source = new BitmapImage(new Uri("Images/obj_pump_off.png", UriKind.Relative));
				}
			}


		}

	} // end of main class
}

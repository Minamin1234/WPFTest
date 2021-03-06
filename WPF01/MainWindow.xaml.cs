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

namespace WPF01
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //同じウィンドウ内に複数のコンテンツを表示させたり、切り替えたりするには「ページ」を使う。
            //わざわざ新規にウィンドウを作る必要がない

            //初期ページを設定します。
            Uri pg_main = new Uri(@"\PG_init.xaml", UriKind.Relative);
            f_main.Source = pg_main;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;

using System.Threading;

using System.Threading.Tasks;
using System.Windows;

namespace WPF02
{
    /// <summary>
    /// App.xaml の相互作用ロジック
    /// </summary>
    public partial class App : Application
    {
        //起動時に遅延させて、スプラッシュスクリーン（起動中の画面）を表示させる。
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            SplashScreen ss = new SplashScreen("SplashScreen1.png");
            ss.Show(true);//表示させる。自動で閉じさせるにはtrueを指定。
            Thread.Sleep(5000);//5秒間遅延させる
                               //OnStartUpを実行中は表示される仕様???
        }
    }
}

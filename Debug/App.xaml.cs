using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Debug
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        public App() : base()
        {
            this.ShutdownMode = ShutdownMode.OnLastWindowClose;

           WPFParser.Tools.Initializer.LoadApp();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFParser.Tools
{

    //Initializer class can ve used to load the WPF Windows pertaining to the project
    public static class Initializer
    {

        public static void LoadApp()
        {
            LoadToolMainWindow();  
        }

        //Load ToolMainWindow --> Load specific windows
        public static void LoadToolMainWindow()
        {
            ToolMainWindow ToolMainwindow = new ToolMainWindow();
            ToolMainWindow_ViewModel ToolMainwindowViewModel = new ToolMainWindow_ViewModel(ToolMainwindow);

            ToolMainwindow.DataContext = ToolMainwindowViewModel;

            ToolMainwindow.Show();
        }



    }
}

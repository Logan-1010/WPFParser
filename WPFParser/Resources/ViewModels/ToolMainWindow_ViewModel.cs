using System;
using System.IO;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.VisualBasic;
using System.Drawing;
using System.Windows.Input;
using System.Data;
using ProjectStandard;
using System.Windows.Controls;

namespace WPFParser.Tools
{
    public class ToolMainWindow_ViewModel:PropertyChange
    {

        #region "Fields"

        WrapPanel outputPanel;

        #endregion

        #region "Properties"

        private string isTxtPath = null;
        public string ITxtPath
        {
            get { return isTxtPath; }
            set
            {
                if (isTxtPath != value)
                {
                    isTxtPath = value;
                    NotifyPropertyChanged("IUserEntry");
                }
            }
        }

        private string isOutput = null;
        public string IOutput
        {
            get { return isOutput; }
            set
            {
                if (isOutput != value)
                {
                    isOutput = value;
                    CheckUserEntry();
                    NotifyPropertyChanged("IOutput");
                }
            }
        }

        private bool isParseButtonEnabler = false;
        public bool IParseButtonEnabler
        {
            get { return isParseButtonEnabler; }
            set
            {
                if (isParseButtonEnabler != value)
                {
                    isParseButtonEnabler = value;
                    NotifyPropertyChanged("IParseButtonEnabler");
                }
            }
        }

        #endregion

        #region"EventHandlers"

        private ICommand isParse;
        public ICommand IParse
        {
            get
            {
                if (isParse == null)
                    isParse = new RelayCommand(ParseOperation);
                return isParse;
            }
        }

        private ICommand isGraphic;
        public ICommand IGraphic
        {
            get
            {
                if (isGraphic == null)
                    isGraphic = new RelayCommand(GraphicOperation);
                return isGraphic;
            }
        }

        private ICommand isClear;
        public ICommand IClear
        {
            get
            {
                if (isClear == null)
                    isClear = new RelayCommand(ClearValues);
                return isClear;
            }
        }

        #endregion 

        public ToolMainWindow_ViewModel(ToolMainWindow iWindow)
        {            
            GUIInitialize(iWindow);
        }


        #region"Private Helpers"

        void GUIInitialize(ToolMainWindow mainWindow)
        {
            //On window Load
            //Get the Output Panel -> Place output
            outputPanel = mainWindow.OutputArea;

        }
        
        void ParseOperation()
        {
            IFFileSystemInterface FileReader = new FileSystem();
            ITxtPath = FileReader.GetFileSystem("Text");

        
            if(ITxtPath != null)
            {
                IFParse ParseData = new ParseFunction();
                //Async not yet implemented
                

                //Main Function
                IOutput = ParseData.ParseData(ITxtPath);

            }


        }

        void GraphicOperation()
        {
            outputPanel.Children.Clear();
            IFGraphic CreateGraphic = new GraphicCreation(outputPanel);

            //Main Function
            if (!CreateGraphic.ShowGraphic(IOutput))
                MessageBox.Show("Creation of Graphic Failed", null, MessageBoxButton.OK, MessageBoxImage.Error);

        }

        void CheckUserEntry()
        {
            //Check entry length and Enable Parse button
            if (IOutput.Length > 0) IParseButtonEnabler = true;
            else IParseButtonEnabler = false;
        }

        void ClearValues()
        {
            IOutput = "";
            outputPanel.Children.Clear();
        }


        #endregion 

    }
}

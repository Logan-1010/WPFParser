using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace WPFParser.Tools
{
   public class GraphicCreation:IFGraphic
    {

        #region"Fields"

        WrapPanel outPanel;

        #endregion

        #region"Public"
        public GraphicCreation(WrapPanel oPanel)
        {
            outPanel = oPanel;
        }

        public bool ShowGraphic(string inputString)
        {
            //Call Private Function - Encapsulation
            return ShowGraphicInWPF(inputString);

        }


        #endregion


        #region"Private"

        bool ShowGraphicInWPF(string iString)
        {
            //Get parsing of each char in a Grid and place it in the output wrappanel
            foreach (char iChar in iString)
            {
                switch (iChar)
                {
                    case '1':
                        outPanel.Children.Add(ParsingGraphic.CreateOne());
                        break;

                    case '2':
                        outPanel.Children.Add(ParsingGraphic.CreateTwo());
                        break;

                    case '3':
                        outPanel.Children.Add(ParsingGraphic.CreateThree());
                        break;

                    case '4':
                        outPanel.Children.Add(ParsingGraphic.CreateFour());
                        break;

                    case '5':
                        outPanel.Children.Add(ParsingGraphic.CreateFive());
                        break;
                }

            }

            //Return false on error -> Error handling not required in this case
            //Return true on success
            return true;
        }

        #endregion

    }

}

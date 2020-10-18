using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace WPFParser.Tools
{
    public class ParseFunction:IFParse
    {

        #region"Fields"

        Dictionary<int, List<string>> iDict;
        StringBuilder outputStrings;
        #endregion

        #region"Public"


        public string ParseData(string txtPath)
        {
            //Call Private Function - Encapsulation
            outputStrings = new StringBuilder();
            return ParseInputData(txtPath);

        }

        #endregion

        #region"Private"

        string ParseInputData(string iPath)
        {
            string[] txtLines = File.ReadAllLines(iPath);

            string[] deLimiters = { " ", "  ", "   ", "    ", "\t"};
            //Individual Height = 4 lines

            iDict = new Dictionary<int, List<string>>();
            List<string> tempList;
            int lineCount = 0;
            int iKey = 0;
            foreach (string line in txtLines)
            {
                string[] splitStrings = line.Split(deLimiters, StringSplitOptions.RemoveEmptyEntries);
                int elemCount = 0;
                
                foreach (string elem in splitStrings)
                {

                    //Initialization
                    if (lineCount == 0)
                    {
                        tempList = new List<string>() { elem };
                        iDict.Add(iKey, tempList);
                        iKey++;
                    }
                    else
                    {
                        try
                        {
                            var item = (from elemList in iDict
                                        where elemList.Key == elemCount
                                        select elemList.Value).ToList().First();

                            item.Add(elem);

                            //Check for 4
                            //Only 4 contains a special char '|_|'
                            if (CheckForFour(elem))
                            {
                                //Remove the next item from iDict
                                iDict.Remove(elemCount + 1);

                            }
                        }
                        catch
                        {

                            //Add elem to next dictionary item
                            var item = (from elemList in iDict
                                        where elemList.Key == elemCount + 1
                                        select elemList.Value).ToList().First();

                            item.Add(elem);
                        }
                    }

                    elemCount++;
                }

                lineCount++;

                if (lineCount == 4)
                {
                    //GetResult 
                    GetResult();

                    //Re-initialize Dictionary
                    iDict = new Dictionary<int, List<string>>();
                    lineCount = 0;
                    iKey = 0;
                }

            }

            return outputStrings.ToString();
        }

        bool CheckForFour(string str)
        {
            return str == "|___|" ? true: false;
        }

        void GetResult()
        {
         
            foreach (var elem in iDict)
            { 
                if(ParsingGraphic.GetOne(elem.Value)) outputStrings.Append("1 ");

                if (ParsingGraphic.GetTwo(elem.Value)) outputStrings.Append("2 ");

                if (ParsingGraphic.GetThree(elem.Value)) outputStrings.Append("3 ");

                if (ParsingGraphic.GetFour(elem.Value)) outputStrings.Append("4 ");

                if (ParsingGraphic.GetFive(elem.Value)) outputStrings.Append("5 ");
                
            }
        }
        
        #endregion 

    }
  
}

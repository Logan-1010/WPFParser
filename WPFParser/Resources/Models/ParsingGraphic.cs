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
    //Class to create individual Parsing graphics
    //Line with X and Y parameters
    public static class ParsingGraphic
    {

        static List<string> One = new List<string>() { "|", "|", "|", "|" };
        static List<string> Two = new List<string>() { "---", "_|", "|", "---" };
        static List<string> Three = new List<string>() { "---", "/", "\\", "--" };
        static List<string> Four = new List<string>() { "|", "|___|", "|", "|" };
        static List<string> Five = new List<string>() { "-----", "|___", "|", "____|" };

        public static bool GetOne(List<string> actualList)
        {
            return actualList.SequenceEqual(One) ? true : false;
        }

        public static bool GetTwo(List<string> actualList)
        {
            return actualList.SequenceEqual(Two) ? true : false;
        }

        public static bool GetThree(List<string> actualList)
        {
            return actualList.SequenceEqual(Three) ? true : false;
        }

        public static bool GetFour(List<string> actualList)
        {
            return actualList.SequenceEqual(Four) ? true : false;
        }

        public static bool GetFive(List<string> actualList)
        {
            return actualList.SequenceEqual(Five) ? true : false;
        }
        public static Grid CreateOne()
        {
            Grid gridElem = new Grid() { Margin = new System.Windows.Thickness() { Left = 15, Top = 10 } };

            double[] y1 = { 0, 20, 40, 60 };
            double[] y2 = { 10, 30, 50, 70 };

            for (int i = 0; i < y1.Length; i++)
            {
                Line line = new Line() { Y1 = y1[i], Y2 = y2[i], Stroke = new SolidColorBrush() { Color = Colors.Black } };
                gridElem.Children.Add(line);

            }

            return gridElem;

        }

        public static Grid CreateTwo()
        {
            Grid gridElem = new Grid() { Margin = new System.Windows.Thickness() { Left = 15, Top = 10 } };

            double[] x1 = { 0, 10, 20, 22.5, 5, 2.5, 0, 10, 20 };
            double[] x2 = { 5, 15, 25, 22.5, 15, 2.5, 5, 15, 25 };
            double[] y1 = { 0, 0, 0, 10, 25, 30, 50, 50, 50, 50 };
            double[] y2 = { 0, 0, 0, 20, 25, 40, 50, 50, 50, 50 };

            for (int i = 0; i < x1.Length; i++)
            {
                Line line = new Line() { X1 = x1[i], X2 = x2[i], Y1 = y1[i], Y2 = y2[i], Stroke = new SolidColorBrush() { Color = Colors.Black } };
                gridElem.Children.Add(line);

            }

            return gridElem;

        }

        public static Grid CreateThree()
        {
            Grid gridElem = new Grid() { Margin = new System.Windows.Thickness() { Left = 15, Top = 10 } };

            double[] x1 = { 0, 10, 20, 15, 5, 0, 10 };
            double[] x2 = { 5, 15, 25, 5, 15, 5, 15 };
            double[] y1 = { 0, 0, 0, 10, 30, 50, 50 };
            double[] y2 = { 0, 0, 0, 20, 40, 50, 50 };

            for (int i = 0; i < x1.Length; i++)
            {
                Line line = new Line() { X1 = x1[i], X2 = x2[i], Y1 = y1[i], Y2 = y2[i], Stroke = new SolidColorBrush() { Color = Colors.Black } };
                gridElem.Children.Add(line);

            }

            return gridElem;

        }

        public static Grid CreateFour()
        {
            Grid gridElem = new Grid() { Margin = new System.Windows.Thickness() { Left = 15, Top = 10 } };

            double[] x1 = { 0, 0, 40, 40, 40, 40, 10 };
            double[] x2 = { 0, 0, 40, 40, 40, 40, 30 };
            double[] y1 = { 0, 20, 0, 20, 40, 60, 35 };
            double[] y2 = { 10, 30, 10, 30, 50, 70, 35 };

            for (int i = 0; i < x1.Length; i++)
            {
                Line line = new Line() { X1 = x1[i], X2 = x2[i], Y1 = y1[i], Y2 = y2[i], Stroke = new SolidColorBrush() { Color = Colors.Black } };
                gridElem.Children.Add(line);

            }

            return gridElem;

        }

        public static Grid CreateFive()
        {
            Grid gridElem = new Grid() { Margin = new System.Windows.Thickness() { Left = 15, Top = 10 } };

            double[] x1 = { 0, 10, 20, 30, 40, 0, 5, 40, 40, 0 };
            double[] x2 = { 5, 15, 25, 35, 45, 0, 35, 40, 40, 30 };
            double[] y1 = { 0, 0, 0, 0, 0, 20, 35, 40, 60, 70 };
            double[] y2 = { 0, 0, 0, 0, 0, 30, 35, 50, 70, 70 };

            for (int i = 0; i < x1.Length; i++)
            {
                Line line = new Line() { X1 = x1[i], X2 = x2[i], Y1 = y1[i], Y2 = y2[i], Stroke = new SolidColorBrush() { Color = Colors.Black } };
                gridElem.Children.Add(line);

            }

            return gridElem;

        }

    }
}

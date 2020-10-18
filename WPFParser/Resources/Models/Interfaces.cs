using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFParser.Tools
{
   public interface IFParse
    {
        string ParseData(string inputString);

    }

    public interface IFGraphic
    {
        bool ShowGraphic(string inputString);
    }

    public interface IFFileSystemInterface
    {
        string GetFileSystem(string iFileType);

    }
}

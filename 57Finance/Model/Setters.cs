using IniParser;
using IniParser.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _57Finance.Model
{
    public class Setters
    {
        public string GetDocNumber(string Group, string Key)
        {
            var parser = new FileIniDataParser();
            IniData data = parser.ReadFile("Configuration.ini");
            string useFullScreenStr = data[Group][Key];

            //parser.WriteFile("Configuration.ini", data);
            return useFullScreenStr;
        }
        public void WriteDocNumber(string Group, string Key)
        {
            var parser = new FileIniDataParser();
            IniData data = parser.ReadFile("Configuration.ini");
            string DocumentNo = GetDocNumber(Group, Key);
            string docStart = DocumentNo.Substring(0, 2);
            DocumentNo = DocumentNo.Substring(2, DocumentNo.Length - 2);
            string GetFileNumber = Convert.ToString(Convert.ToDouble(DocumentNo) + 1).PadLeft(5, Convert.ToChar("0"));
            data[Group][Key] = docStart + GetFileNumber;
            parser.WriteFile("Configuration.ini", data);
        }
    }
}

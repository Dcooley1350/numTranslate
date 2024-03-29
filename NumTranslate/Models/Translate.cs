using System.Collections.Generic;

namespace NumTranslate.Models
{
    public class Translate
    {
        public string ReturnString { get; set; }
        public List<string> TextNumber { get; set; }
        public Dictionary<string,string> SingleDigits { get; }
        public Dictionary<string,string> DoubleDigits { get; }
        public Dictionary<string,string> WierdOnes { get; }
        public Translate()
        {   
            ReturnString = "";
            TextNumber = new List <string>{};
            SingleDigits = new Dictionary<string,string>();
            SingleDigits.Add("0","");
            SingleDigits.Add("1","one");
            SingleDigits.Add("2","two");
            SingleDigits.Add("3","three");
            SingleDigits.Add("4","four");
            SingleDigits.Add("5","five");
            SingleDigits.Add("6","six");
            SingleDigits.Add("7","seven");
            SingleDigits.Add("8","eight");
            SingleDigits.Add("9","nine");
            DoubleDigits = new Dictionary<string,string>();
            DoubleDigits.Add("2","twenty");
            DoubleDigits.Add("3","thirty");
            DoubleDigits.Add("4","forty");
            DoubleDigits.Add("5","fifty");
            DoubleDigits.Add("6","sixty");
            DoubleDigits.Add("7","seventy");
            DoubleDigits.Add("8","eighty");
            DoubleDigits.Add("9","ninety");
            WierdOnes = new Dictionary<string,string>();
            WierdOnes.Add("1","eleven");
            WierdOnes.Add("2","twelve");
            WierdOnes.Add("3","thirteen");
            WierdOnes.Add("4","fourteen");
            WierdOnes.Add("5","fifteen");
            WierdOnes.Add("6","sixteen");
            WierdOnes.Add("7","seventeen");
            WierdOnes.Add("8","eighteen");
            WierdOnes.Add("9","nineteen");
        }
        public List<string> StringToStringList(string newString)
        {
            List<string> stringList = new List<string> {};
            char[] newCharArray = newString.ToCharArray(0,newString.Length);
            foreach(char item in newCharArray)
            {
                string stringItem = item.ToString();
                stringList.Add(stringItem);
            }
            return stringList;
        }
        public void ReplaceFirstDigit(List<string> stringList)
        {
            int index = stringList.Count -1;
            foreach(KeyValuePair<string, string> entry in SingleDigits)
            {
                if(entry.Key == stringList[index])
                {
                    TextNumber.Add(entry.Value);
                }
            }
        }
        public void ReplaceSecondDigit(List<string> stringList)
        {
            int index = stringList.Count -2;
            if(stringList[index] = "one")
            {
                stringList[index+1]="";
                foreach(KeyValuePair<string, string> entry in WierdOnes)
                {
                    if(entry.Key == stringList[index])
                    {
                        TextNumber.Add(entry.Value);
                    }
                }
            }
            else
            {
                foreach(KeyValuePair<string, string> entry in DoubleDigits)
                {
                    if(entry.Key == stringList[index])
                    {
                        TextNumber.insert(0,entry.Value);
                    }
                }
            }

        }

    }
}

using System;
using System.Xml;

namespace DurationParser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //the format is like "45s", "10m", "1h30m", "2h5m10s"
            string HumanReadableString = "2h5m10s";
            int TotalSceond = 0;
            Console.WriteLine("Human readabele text: " + HumanReadableString);
            ToSecond(HumanReadableString, out TotalSceond);
            Console.WriteLine("Total Second: " + TotalSceond.ToString());

            HumanReadableString = "45m";
            Console.WriteLine("Human readabele text: " + HumanReadableString);
            ToSecond(HumanReadableString, out TotalSceond);
            Console.WriteLine("Total Second: " + TotalSceond.ToString());

            HumanReadableString = "10m";
            Console.WriteLine("Human readabele text: " + HumanReadableString);
            ToSecond(HumanReadableString, out TotalSceond);
            Console.WriteLine("Total Second: " + TotalSceond.ToString());


            HumanReadableString = "1h30m";
            Console.WriteLine("Human readabele text: " + HumanReadableString);
            ToSecond(HumanReadableString, out TotalSceond);
            Console.WriteLine("Total Second: " + TotalSceond.ToString());
        }

        //such function has the advance that we can double check the input string,
        //if the input string is null, we can return false,
        //and the output parameter will be 0, which is a reasonable default value for total second.
        //or something wrong with the input string, such as mal formatted string, so we cannot parse it
        public static bool ToSecond(String? input, out int TotalSceond)
        {
            TotalSceond = 0;
            if (input is null)
                return false;

            int[] TimeSectionInt = ParseTimeDuration(input);
            TotalSceond = TimeSectionInt[0]*60*60 + TimeSectionInt[1]*60 + TimeSectionInt[2];
            return true;
        }
        
        public static int[] ParseTimeDuration(string TimeString)
        {
            int[] TimeSection = [0, 0, 0];
            string[] TimeSlice = ["h", "m", "s"];
            string ParseString = TimeString;
            int StartIndex = 0;
            int CheckIndex = 0;

            for (int i =0; i< TimeSlice.Length; i++)
            {
                CheckIndex = ParseString.IndexOf(TimeSlice[i]);
                TimeSection[i] = CheckIndex > -1
                    ? int.Parse(ParseString[StartIndex..(CheckIndex)])
                    : 0; //if the time slice is not found, we can set the corresponding time section to 0, which is a reasonable default value.

                ParseString = ParseString[(CheckIndex + 1)..(ParseString.Length)];
            }
            
            //Console.WriteLine("TimeSection: ");
            //Console.WriteLine(string.Join(", ", TimeSection.ToString()));
            return TimeSection;

        }
    }
}

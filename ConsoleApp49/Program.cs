using System;

namespace ConsoleApp
{
    class Program
    {
        static string Sys10To16(double s10) 
        {
            string Sys16 = "";
            if (s10 > 9)
            {
                if (s10 == 10) Sys16 = "A";
                if (s10 == 11) Sys16 = "B";
                if (s10 == 12) Sys16 = "C";
                if (s10 == 13) Sys16 = "D";
                if (s10 == 14) Sys16 = "E";
                if (s10 == 15) Sys16 = "F";
            }
            else Sys16 = Convert.ToString(s10);
            return Sys16;
        }
        static void RGBTo16(string RGB)
        {
            int[] RGBNumArr = new int[3];
            string RGBBuild = "";

            int j = 0;
            for(int i = 0; j < 3 && i < RGB.Length; i++)
            {
                if (RGB[i] != ',' && RGB[i] != '.' && RGB[i] != ' ') RGBBuild += RGB[i];
                if(RGBBuild.Length == 3) 
                {
                    RGBNumArr[j++] = Convert.ToInt32(RGBBuild);
                    RGBBuild = "";
                }
            }
            
            string Sys16 = "";
            for(int i = 0; i < 3; i++)
            {
                double total = 0;
                total = Math.Truncate(Convert.ToDouble(RGBNumArr[i] / 16));
                Sys16 += Sys10To16(total);
                double remain = 0;
                remain = RGBNumArr[i] - total * 16;
                Sys16 += Sys10To16(remain);
            }

            Console.WriteLine(Sys16);
        }
        static void Main(string[] args)
        {
            string RGB = "255, 255, 255";
            RGBTo16(RGB);
        }
    }
}

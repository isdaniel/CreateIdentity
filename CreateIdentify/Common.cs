using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateIdentify
{
    public class Common
    {
        public static int CityNum(char c)
        {
            int num = 0;
            switch (c)
            {
                case 'A':
                    num = 10;
                    break;
                case 'B':
                    num = 11;
                    break;
                case 'C':
                    num = 12;
                    break;
                case 'D':
                    num = 13;
                    break;
                case 'E':
                    num = 14;
                    break;
                case 'F':
                    num = 15;
                    break;
                case 'G':
                    num = 16;
                    break;
                case 'H':
                    num = 17;
                    break;
                case 'I':
                    num = 34;
                    break;
                case 'J':
                    num = 18;
                    break;
                case 'K':
                    num = 19;
                    break;
                case 'L':
                    num = 20;
                    break;
                case 'M':
                    num = 21;
                    break;
                case 'N':
                    num = 22;
                    break;
                case 'O':
                    num = 35;
                    break;
                case 'P':
                    num = 23;
                    break;
                case 'Q':
                    num = 24;
                    break;
                case 'R':
                    num = 25;
                    break;
                case 'S':
                    num = 26;
                    break;
                case 'T':
                    num = 27;
                    break;
                case 'U':
                    num = 28;
                    break;
                case 'V':
                    num = 29;
                    break;
                case 'W':
                    num = 32;
                    break;
                case 'X':
                    num = 30;
                    break;
                case 'Y':
                    num = 31;
                    break;
                case 'Z':
                    num = 33;
                    break;
            }
            return num;
        }
        public static int GetFirstNum(int num)
        {
            return num / 10;

        }
        public static int GetSecondNum(int num)
        {
            num = (num % 10) * 9;
            return num;
        }
        /*     
        A=10 台北市     J=18 新竹縣     S=26 高雄縣
        B=11 台中市     K=19 苗栗縣     T=27 屏東縣
        C=12 基隆市     L=20 台中縣     U=28 花蓮縣
        D=13 台南市     M=21 南投縣     V=29 台東縣
        E=14 高雄市     N=22 彰化縣     W=32 金門縣
        F=15 台北縣     O=35 新竹市     X=30 澎湖縣
        G=16 宜蘭縣     P=23 雲林縣     Y=31 陽明山
        H=17 桃園縣     Q=24 嘉義縣     Z=33 連江縣
        I=34 嘉義市     R=25 台南縣    
        */
    }
}

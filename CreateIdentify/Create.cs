using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateIdentify
{
    public class Create
    {
        private int totleNum { get; set; }
        private string sNum { get; set; }
        private readonly Random rand = new Random();
        private int getWord()
        {
            int Word = rand.Next(65, 91);
            return Word;
        }
        private int[] CreateEightNum(){
            int[] cArray = new int[7];
            for (int i = 0; i < 7; i++) {
                cArray[i] = rand.Next(0, 10);
            }
            return cArray;
        }
        private int GetLastNum()
        {
            int num=0;
            for (int j = 0; j <= 9; j++) {
                int temp = totleNum;
                temp += j;
                if (temp % 10 == 0)
                {
                    totleNum += j;
                    num = j;
                    break;
                }
            }
            return num;
        }
        private string EightTotle() {
            string sNum="";
            int[] numArray = CreateEightNum();
            int num = rand.Next(1, 3);
            totleNum += num * 8;
            sNum += num;
            for (int i = 0; i < 7; i++)
            {
                totleNum += (7 - i) * numArray[i];
                sNum += numArray[i];
            }
            return sNum;
        }
        private void getFirtWord(){
            int tempnum = getWord();
            sNum = ((char)tempnum).ToString();
            CountFirstWord(Common.CityNum((char)tempnum));
        }
        private void CountFirstWord(int firstCount) {
            totleNum = Common.GetFirstNum(firstCount);
            totleNum += Common.GetSecondNum(firstCount);
        }
        public string SpellIndentify(){
            getFirtWord();
            return sNum+EightTotle()+GetLastNum();
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace UBC
{
    class Program
    {
        public class Choragi
        {
            public List<int> size = new List<int>();
            public int sol=0;
            public Choragi()
            {

            }
           
        }
        public class CheckClass
        {
            public int area1;
            public int area2;
            public int value;
            public CheckClass()
            {

            }
            public CheckClass(int area1,int area2,int value)
            {
                this.area1 = area1;
                this.area2 = area2;
                this.value = value;
            }
        }
        static int i = 0;
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
            int tc = int.Parse(sr.ReadLine());
            List<Choragi> cr = new List<Choragi>();
            Choragi c = new Choragi();
            int[] input= { 0, 0 };
            int[] area;
            for(int i = 0; i < tc; i++)
            {
                input = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);
                c.sol = input[1]; 
                area = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);
                for (int k = 0; k < area.Length; k++)
                {
                    c.size.Add(area[k]);
                }
                area = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);
                for (int k = 0; k < area.Length; k++)
                {
                    c.size.Add(area[k]);
                }
                cr.Add(c);
            }
            sw.WriteLine("+============================+");
            for (int i = 0; i < cr.Count; i++)
            {
                sw.WriteLine("SOL Count: " + cr[i].sol);
                for (int j = 0; j < cr[i].size.Count; j++)
                {
                    sw.WriteLine(j + "area enm Count: " + cr[i].size[j]);
                }
            }
            sw.WriteLine("+============================+");
            for (int m = 0; m < cr.Count; m++)
            {
                for (int i = 0; i < cr[m].size.Count; i++)
                {
                    if (i == cr[m].size.Count - 1)//맨 마지막 구역
                    {
                        sw.WriteLine("2: " + i);
                    }
                    else if (i == 0)//맨 처음 구역
                    {
                        sw.WriteLine("1: " + i);
                    }
                    else if (i + (cr[m].size.Count / 2) >= cr[m].size.Count)//바깥쪽 구역
                    {
                        sw.WriteLine("4: " + i);
                    }
                    else//안쪽 구역
                    {
                        sw.WriteLine("3: " + i);
                    }
                }
            }
            int count = 0;
            List<int> ls = new List<int>();
            List<CheckClass> cc = new List<CheckClass>();
            int tmp=0;
            int lastArea = -1;
            int[] mm = { 0, 0 };
            for (int m = 0; m < cr.Count; m++)
            {
                count = 0;

                for (int i = 0; i < cr[m].size.Count; i++)
                {
                    tmp = 0;

                    lastArea = -1;
                    if (i == cr[m].size.Count - 1)//맨 마지막 구역
                    {
                        if (cr[m].size[i]==cr[m].sol)
                        {
                            if (!ls.Contains(i))
                            {
                                ls.Add(i);
                            }
                            sw.WriteLine("CHECK: "+i);
                            count++;
                            continue;
                        }
                        if (cr[m].size[i] + cr[m].size[input[0]] <= cr[m].sol)//맨 첫번째 구역과 비교
                        {
                            tmp = cr[m].size[i] + cr[m].size[0+ input[0]];
                            lastArea = input[0];
                        }
                        if (cr[m].size[i] + cr[m].size[i - 1] <= cr[m].sol)//맨 마지막 직전 구역과 비교
                        {
                            if(tmp < cr[m].size[i] + cr[m].size[i - 1])
                            {
                                tmp = cr[m].size[i] + cr[m].size[i - 1];
                                lastArea = i - 1;//tc=8일때 15-1 = 14
                            }
                        }
                        if (cr[m].size[i] + cr[m].size[i - input[0]] <= cr[m].sol)//맨 마지막 안쪽 구역과 비교
                        {
                            if(tmp < cr[m].size[i] + cr[m].size[i - input[0]])
                            {
                                tmp = cr[m].size[i] + cr[m].size[i - input[0]];
                                lastArea = i- input[0];//tc=8일때 15-8 = 7
                            }
                        }
                        if (!ls.Contains(lastArea)&&!ls.Contains(i)&&lastArea!=-1)
                        {
                            ls.Add(lastArea);
                            ls.Add(i);
                            cc.Add(new CheckClass(i, lastArea, tmp));
                            sw.WriteLine("CHECK: " + lastArea + "," + i);
                            count++;
                        }
                        else if (lastArea!=-1)
                        {
                            int checkTMP = IsCheck(cc, lastArea, i);
                            if (checkTMP != -1)
                            {
                                if(cc[checkTMP].value < tmp)
                                {
                                    ls.Remove(cc[checkTMP].area1);
                                    ls.Remove(cc[checkTMP].area2);
                                    cc.RemoveAt(checkTMP);
                                    ls.Add(lastArea);
                                    ls.Add(i);
                                    cc.Add(new CheckClass(i, lastArea, tmp));
                                    sw.WriteLine("CHECK: " + lastArea + "," + i);
                                }
                            }
                        }
                    }
                    else if (i == 0)//맨 처음 구역
                    {
                        if (cr[m].size[i] == cr[m].sol)
                        {
                            if (!ls.Contains(i))
                            {
                                ls.Add(i);
                                
                            }
                            sw.WriteLine("CHECK: " + i);
                            count++;
                            continue;
                        }
                        if (cr[m].size[i] + cr[m].size[input[0] - 1] <= cr[m].sol)//
                        {
                            tmp = cr[m].size[i] + cr[m].size[input[0] - 1];
                            lastArea = input[0] - 1;
                        }
                        if (cr[m].size[i] + cr[m].size[i + 1] <= cr[m].sol)//다음 구역과 비교
                        {
                            if (tmp < cr[m].size[i] + cr[m].size[i + 1])
                            {
                                tmp = cr[m].size[i] + cr[m].size[i + 1];
                                lastArea = i + 1;
                            }
                        }
                        if (cr[m].size[i] + cr[m].size[i + input[0]] <= cr[m].sol)//첫번째 바깥 구역과 비교
                        {
                            if (tmp < cr[m].size[i] + cr[m].size[i + input[0]])
                            {
                                tmp = cr[m].size[i] + cr[m].size[i + input[0]];
                                lastArea = i + input[0];
                            }
                        }
                        if (!ls.Contains(lastArea) && !ls.Contains(i) && lastArea != -1)
                        {
                            ls.Add(lastArea);
                            ls.Add(i);
                            cc.Add(new CheckClass( i, lastArea, tmp));
                            sw.WriteLine("CHECK: " + lastArea + "," + i);
                            count++;
                        }
                        else if (lastArea != -1)
                        {
                            int checkTMP = IsCheck(cc, lastArea, i);
                            if (checkTMP != -1)
                            {
                                if (cc[checkTMP].value < tmp)
                                {
                                    ls.Remove(cc[checkTMP].area1);
                                    ls.Remove(cc[checkTMP].area2);
                                    cc.RemoveAt(checkTMP);
                                    ls.Add(lastArea);
                                    ls.Add(i);
                                    cc.Add(new CheckClass(i, lastArea, tmp));
                                    sw.WriteLine("CHECK: " + lastArea + "," + i);
                                }
                            }
                        }
                    }
                    else if (i + (cr[m].size.Count / 2) >= cr[m].size.Count)//바깥쪽 구역
                    {
                        if (cr[m].size[i] == cr[m].sol)
                        {
                            if (!ls.Contains(i))
                            {
                                ls.Add(i);
                            }
                            sw.WriteLine("CHECK: " + i);
                            count++;
                            continue;
                        }
                        if (cr[m].size[i] + cr[m].size[i + 1] <= cr[m].sol)//맨 마지막 직전 구역과 비교
                        {
                            if (tmp < cr[m].size[i] + cr[m].size[i + 1])
                            {
                                tmp = cr[m].size[i] + cr[m].size[i + 1];
                                lastArea = i + 1;
                            }
                        }
                        if (cr[m].size[i] + cr[m].size[i - 1] <= cr[m].sol)//맨 마지막 직전 구역과 비교
                        {
                            if (tmp < cr[m].size[i] + cr[m].size[i - 1])
                            {
                                tmp = cr[m].size[i] + cr[m].size[i - 1];
                                lastArea = i - 1;
                            }
                        }
                        if (cr[m].size[i] + cr[m].size[i - input[0]] <= cr[m].sol)//맨 마지막 안쪽 구역과 비교
                        {
                            if (tmp < cr[m].size[i] + cr[m].size[i - input[0]])
                            {
                                tmp = cr[m].size[i] + cr[m].size[i - input[0]];
                                lastArea = i - input[0];//tc=8일때 15-8 = 7
                            }
                        }
                        if (!ls.Contains(lastArea) && !ls.Contains(i) && lastArea != -1)
                        {
                            ls.Add(lastArea);
                            ls.Add(i);
                            cc.Add(new CheckClass(i, lastArea, tmp));
                            sw.WriteLine("CHECK: " + lastArea + "," + i);
                            count++;
                        }
                        else if (lastArea != -1)
                        {
                            int checkTMP = IsCheck(cc, lastArea, i);
                            if (checkTMP != -1)
                            {
                                if (cc[checkTMP].value < tmp)
                                {
                                    ls.Remove(cc[checkTMP].area1);
                                    ls.Remove(cc[checkTMP].area2);
                                    cc.RemoveAt(checkTMP);
                                    ls.Add(lastArea);
                                    ls.Add(i);
                                    cc.Add(new CheckClass(i, lastArea, tmp));
                                    sw.WriteLine("CHECK: " + lastArea + "," + i);
                                }
                            }
                        }
                    }
                    else//안쪽 구역
                    {
                        if (cr[m].size[i] == cr[m].sol)
                        {
                            if (!ls.Contains(i))
                            {
                                ls.Add(i);
                            }
                            sw.WriteLine("CHECK: " + i);
                            count++;
                            continue;
                        }
                        if (cr[m].size[i] + cr[m].size[i - 1] <= cr[m].sol)//다음 구역과 비교
                        {
                            if (tmp < cr[m].size[i] + cr[m].size[i - 1])
                            {
                                tmp = cr[m].size[i] + cr[m].size[i - 1];
                                lastArea = i - 1;
                            }
                        }
                        if (cr[m].size[i] + cr[m].size[i + 1] <= cr[m].sol)//다음 구역과 비교
                        {
                            if (tmp < cr[m].size[i] + cr[m].size[i + 1])
                            {
                                tmp = cr[m].size[i] + cr[m].size[i + 1];
                                lastArea = i + 1;
                            }
                        }
                        if (cr[m].size[i] + cr[m].size[i + input[0]] <= cr[m].sol)//첫번째 바깥 구역과 비교
                        {
                            if (tmp < cr[m].size[i] + cr[m].size[i + input[0]])
                            {
                                tmp = cr[m].size[i] + cr[m].size[i + input[0]];
                                lastArea = i + input[0];
                            }
                        }
                        if (!ls.Contains(lastArea) && !ls.Contains(i) && lastArea != -1)
                        {
                            ls.Add(lastArea);
                            ls.Add(i);
                            cc.Add(new CheckClass(i, lastArea, tmp));
                            sw.WriteLine("CHECK: " + lastArea +","+ i);
                            count++;
                        }
                        else if (lastArea != -1)
                        {
                            int checkTMP = IsCheck(cc, lastArea, i);
                            if (checkTMP != -1)
                            {
                                if (cc[checkTMP].value < tmp)
                                {
                                    ls.Remove(cc[checkTMP].area1);
                                    ls.Remove(cc[checkTMP].area2);
                                    cc.RemoveAt(checkTMP);
                                    ls.Add(lastArea);
                                    ls.Add(i);
                                    cc.Add(new CheckClass(i, lastArea, tmp));
                                    //sw.WriteLine("CHECK: " + lastArea + "," + i);
                                }
                            }
                        }
                    }
                    
                }
                for (int k = 0; k < input[0] * 2; k++)
                {
                    if (!ls.Contains(k))
                    {
                        count++;
                    }
                }
                sw.WriteLine("+============================+");
                sw.WriteLine(count);
            }
            

            sw.Flush();
            sr.Close();
            sw.Close();
            
        }

        static public int IsCheck(List<CheckClass> cc,int a1,int a2)
        {
            int count = 0;
            foreach(CheckClass c in cc)
            {
                count++;
                if(c.area1 == a1 || c.area1 == a2)
                {
                    return count-1;
                }else if(c.area2 == a1 || c.area2 == a2)
                {
                    return count-1;
                }
            }
            return -1;
        }
     
    }
}

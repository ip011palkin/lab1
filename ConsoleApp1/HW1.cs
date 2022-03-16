using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class HW1
    {
        public static long QueueTime(int[] consumer, int n)
        {
            int[] kassa = new int[n];

            int T = 0;
            do
            {
                int s = 0;
                for (int i = 0; i < consumer.Length; i++) s += consumer[i];
                if (s == 0) break;
                for (int i = 0; i < n; i++) kassa[i] = 0;
                for (int i = 0; i < n; i++)
                {
                    if (consumer[i] == 0) kassa[i] = 1;
                }
                for (int i = 0; i < kassa.Length; i++)
                {
                    if (kassa[i] == 1)
                    {
                        consumer[i] = consumer[n];
                        for (int j = n; j < consumer.Length - 1; j++)
                        {
                            consumer[j] = consumer[j + 1];
                        }
                        consumer[consumer.Length - 1] = 0;
                    }
                    if (consumer[i] != 0)
                        consumer[i]--;
                }
                T++;
            } while (true);
            return T;
        }

    }
}
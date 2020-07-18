using System.Collections.Generic;

namespace LeetCode
{
    /// <summary>
    /// 739. 每日温度
    /// </summary>
    public class DailyTemperaturesClass
    {
        public int[] DailyTemperatures(int[] T)
        {
            /*
             * 从数据尾部开始遍历，遇到一个温度，就记录其索引；如果遇到相同温度，就用较小的索引替换它
             */
            Dictionary<int, int> temperatureIndex = new Dictionary<int, int>(T.Length);

            for (int i = T.Length - 1; i >= 0; i--)
            {
                int currentTemperature = T[i];
                if (temperatureIndex.ContainsKey(currentTemperature))
                {
                    temperatureIndex[currentTemperature] = i;
                }
                else
                {
                    temperatureIndex.Add(currentTemperature, i);
                }

                // 比当前温度高的最小索引
                int minimalIndex = int.MaxValue;
                for (int j = currentTemperature + 1; j <= 100; j++)
                {
                    if (temperatureIndex.ContainsKey(j))
                    {
                        var biggerTemperatureIndex = temperatureIndex[j];
                        minimalIndex = biggerTemperatureIndex < minimalIndex ? biggerTemperatureIndex : minimalIndex;
                    }
                }

                T[i] = minimalIndex < int.MaxValue ? minimalIndex - i : 0;
            }

            return T;
        }
    }
}
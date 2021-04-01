using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.StringAndArray
{
    /// <summary>
    /// 90. 子集 II
    /// </summary>
    public class Subsets
    {
        public IList<IList<int>> SubsetsWithDup(int[] nums)
        {
            // 升序排序
            Array.Sort(nums);

            IList<IList<int>> result=new List<IList<int>>();

            result.Add(new List<int>());

            for (var i = 0; i < nums.Length; i++)
            {
                var newSub = new List<IList<int>>(result);

                foreach (var u in newSub)
                {
                    var temp = new List<int>(u);
                    temp.Add(nums[i]);

                    bool exists = false;

                    foreach (IList<int> list in result)
                    {
                        if (list.Count == temp.Count)
                        {
                            bool tempExists = true;
                            for (int j = 0; j < temp.Count; j++)
                            {
                                if (list[j] != temp[j])
                                {
                                    tempExists=false;
                                    break;
                                }
                            }

                            if (tempExists)
                            {
                                exists = true;
                                break;
                            }
                        }
                    }

                    if (!exists)
                    {
                        result.Add(temp);
                    }
                }
            }

            return result;
        }

    }
}
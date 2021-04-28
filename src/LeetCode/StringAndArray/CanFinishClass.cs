using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace LeetCode.StringAndArray
{
    /// <summary>
    /// 207. 课程表
    /// </summary>
    public class CanFinishClass
    {
        /*
         * 1、先把所有依赖项存入字典
         * 2、遍历每一个项，同时递归遍历它的依赖项。如果在遍历依赖项的过程中，遇到了这个项，那么就有循环依赖，不能进行拓扑排序。
         * 3、符合有向无环图就能进行拓扑排序，递归到最后一个无依赖项的项后，依次从递归栈中弹出已遍历的项，并把项设置为“已处理”和存入结果集，防止后续错误地判断为循环依赖。
         * 4、此时结果集从左到右的排序即为拓扑排序的结果
         */
        public bool CanFinish(int numCourses, int[][] prerequisites)
        {
            var sorted = new List<int>();
            var visited = new Dictionary<int, bool>();
            var dependencies=new Dictionary<int,HashSet<int>>();
            foreach (int[] item in prerequisites)
            {
                if (dependencies.ContainsKey(item[0]))
                {
                    dependencies[item[0]].Add(item[1]);
                }
                else
                {
                    dependencies.Add(item[0],new HashSet<int>(){item[1]});
                }
            }

            try
            {
                foreach (KeyValuePair<int, HashSet<int>> pair in dependencies)
                {
                    SortByDependenciesVisit(pair.Key,dependencies,sorted,visited);
                }
            }
            catch (Exception e)
            {
                return false;
            }

            Debug.Write(string.Join(",",sorted));

            return true;
        }

        public void SortByDependenciesVisit(int item,Dictionary<int,HashSet<int>> all,List<int> sorted,Dictionary<int, bool> visited)
        {
            bool inProcess;
            var alreadyVisited = visited.TryGetValue(item, out inProcess);

            if (alreadyVisited)
            {
                if (inProcess)
                {
                    throw new ArgumentException("Cyclic dependency found! Item: " + item);
                }
            }
            else
            {
                visited[item] = true;

                all.TryGetValue(item, out HashSet<int> dependencies);
                if (dependencies != null)
                {
                    foreach (var dependency in dependencies)
                    {
                        SortByDependenciesVisit(dependency, all, sorted, visited);
                    }
                }

                visited[item] = false;
                sorted.Add(item);
            }
        }
    }
}
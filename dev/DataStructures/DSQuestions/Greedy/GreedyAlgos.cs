using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DSQuestions.Greedy
{
    public static class GreedyAlgos
    {
        /// <summary>
        /// In Activity selection problem, We are given a set of activities and starting and finishing time of each 
        /// activity. We need to find the maximum number of activities that can be performed by single person 
        /// assuming that a person can only work on a single activity at a time. 
        /// E.g. Input: (1,4), (3,5), (0,6), (5,7), (3,8), (5,9), (6,10), (8,11), (8,12), (2,13), (12,14)
        /// Output: (1, 4), (5, 7), (8, 11),(12, 14)
        /// </summary>
        /// <param name="listOfActivities">List of start and finish timings of activities</param>
        /// <returns>List of activities a person can perform at max</returns>
        public static List<KeyValuePair<int, int>> ActivitySelectionProblem(List<KeyValuePair<int, int>> listOfActivities)
        {
            // Sort the list with ascending finishing so that we know which task completes early. 
            List<KeyValuePair<int, int>> sortedActivities = listOfActivities.OrderBy(o => o.Value).ToList();

            List<KeyValuePair<int, int>> result = new List<KeyValuePair<int, int>>();

            // We will start with that start. 
            result.Add(sortedActivities.First());
            KeyValuePair<int, int> lastElement = sortedActivities.First();

            // Loop through from second node and check which start time after  last node end. 
            for (int i = 1; i < sortedActivities.Count; i++)
            {
                if (sortedActivities[i].Key >= lastElement.Value)
                {
                    result.Add(sortedActivities[i]);
                    lastElement = sortedActivities[i];
                }
            }

            return result;
        }
    }
}

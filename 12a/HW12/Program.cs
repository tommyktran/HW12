﻿using System;
using System.Collections.Generic;

namespace HW12
{
    class Program
    {
        static void Main(string[] args)
        {
            var ls = new List<string> { "Ant", "Bat", "Cat", "Dog" };
            int k = 3;
            GroupAssignments(ls, k);
        }

        static void GroupAssignments(List<string> ls, int k)
        {
            var groups = new List<List<string>>();
            GroupAssignments(ls, 0, groups, k);
        }

        static void GroupAssignments(List<string> ls, int idx, List<List<string>> groups, int k)
        {
            if (ls.Count == idx)
            {
                if (groups.Count == k) PrintGroups(groups);
                return;
            }
            // Add the current element to each existing group
            for (int i = 0; i < groups.Count; i++)
            {
                groups[i].Add(ls[idx]);
                GroupAssignments(ls, idx + 1, groups, k);
                groups[i].Remove(ls[idx]);
            }
            // Add the current element to a new group
            groups.Add(new List<string>());
            groups[groups.Count - 1].Add(ls[idx]);
            GroupAssignments(ls, idx + 1, groups, k);
            groups.RemoveAt(groups.Count - 1);
        }

        static void PrintGroups(List<List<string>> groups)
        {
            foreach (List<string> group in groups)
            {
                Console.Write("| ");
                foreach (string s in group)
                {
                    Console.Write(s + " ");
                }
            }
            Console.WriteLine("|");
        }
    }

}

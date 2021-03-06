﻿using System;
using System.Collections.Generic;

namespace NullableReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            var candidates = Service.GetCandidates();
            var names = GetNames(candidates);

            foreach (var name in names)
            {
                Console.WriteLine($"{name} has been added to CVDB");
            }
        }

        static IEnumerable<string> GetNames(IEnumerable<Candidate> candidates)
        {
            foreach (var candidate in candidates)
            {
                yield return $"{candidate.FirstName} {candidate.MiddleName} {candidate.LasttName} {candidate.Applications.Count}";
            }

            Console.ReadKey();
        }
    }
}

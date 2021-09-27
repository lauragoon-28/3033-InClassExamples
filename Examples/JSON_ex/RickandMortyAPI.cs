﻿using System;
using System.Collections.Generic;
using System.Text;

namespace JSON_ex
{
    public class RickandMortyAPI
    {
        public Info info { get; set; }

        public List<Character> results{get;set;}
        




    }

    public class Info
    {
        public int count { get; set; }

        public int pages { get; set;}

        public string next { get; set; }

        public string prev { get; set; }
    }

    public class Character
    {
        public int id { get; set; }

        public string name { get; set; }

        public string status { get; set; }

        public string species { get; set; }

        public string type { get; set; }

        public string gender { get; set; }

        public string image { get; set; }

        public string URL { get; set; }

        public override string ToString()
        {
            return $"{name} ({id})";
        }

    }
}

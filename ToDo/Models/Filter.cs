﻿namespace ToDoDemo.Models
{
    public class Filter
    {
        public Filter(string filterstring)
        {
            filterstring = filterstring?? "all-all-all";

            string[] filters = filterstring.Split('-');

            CategoryId =filters[0];

            Due =filters[1];    

            StatusId =filters[2];
        }
        public string Filterstring { get; set; }

        public string  CategoryId { get; set; }

        public string Due { get; set; }

        public string StatusId { get; set; }

        public bool HasCategory => CategoryId.ToLower() != "all";

        public bool HasDue => Due.ToLower() != "all";

        public bool HasStatus => StatusId.ToLower() != "all";

        public static Dictionary<string, string> DueFilterValues =>
            new Dictionary<string, string> {
                {"future","Future" },
                {"past","Past" },
                {"today","Today" },
            };
        public bool IsPast => Due.ToLower() == "past";

        public bool IsFuture => Due.ToLower() == "future";

        public bool IsToday => Due.ToLower() == "today";
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobNear
{
    public class Session
    {
        public static string CurrentUserType { get; set; }
        public static string CurrentUserId { get; set; }
        public static string CurrentEmail { get; set; }
        public static double CurrentLatitude { get; set; }
        public static double CurrentLongitude { get; set; }
        public static string CurrentProfileStatus { get; set; }
        public static string CurrentBusinessSelected { get; set; }

    }
}

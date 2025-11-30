using System.Windows.Forms;

namespace JobNear
{
    public class Session
    {
        public static string CurrentUserType { get; set; }
        public static string CurrentUserId { get; set; }
        public static string CurrentEmail { get; set; }
        public static double CurrentLatitude { get; set; }
        public static double CurrentLongitude { get; set; }
        public static string CurrentBusinessSelected { get; set; }
        public static string CurrentBusinessSelectedStatus { get; set; }
        public static string CurrentJobPosterSelected { get; set; }
        public static string CurrentPostedJobSelected { get; set; }
        public static string CurrentPostJobFormMode { get; set; }
        public static Panel CurrentSidebarPanel { get; set; }
        public static string CurrentSeekJobSelected { get; set; }
        public static string CurrentAdminSelected { get; set; }
        public static string CurrentReportSelected { get; set; }
    }
}

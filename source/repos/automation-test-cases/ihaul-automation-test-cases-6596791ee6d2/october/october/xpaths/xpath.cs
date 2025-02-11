using october.hooks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace october.xpaths
{
    public class xpath:Hooks1
    {
        private static string common = "//android.widget.ScrollView/android.view.View/android.widget.";
        public static string GetTestFieldXPath(int index)
        {
            switch (index)
            {
                case 1:
                    return $"{common}EditText[1]";
                case 2:
                    return $"{common}EditText[2]";
                case 3:
                    return $"{common}EditText[3]";
                case 4:
                    return $"{common}EditText[4]";
                case 5:
                    return $"{common}EditText[5]";
                case 6:
                    return $"{common}EditText[6]";
                default:
                    return "index not found";  // Default to index 1 if no match is found
            }
        }
        public static string Next = "//android.widget.Button[@content-desc=\"Next\"]";
        public static string GetStarted = "//android.widget.Button[@content-desc=\"Get Started\"]";
        public static string Continues => "//android.view.View[@content-desc=\"Continue\"]";
        public static string Edit => "//android.widget.EditText";
        public static string face = $"{common}ImageView[1]";
        public static string gmail = $"{common}ImageView[2]";
        public static string ok = "//android.view.View[@content-desc=\"Ok\"]";
        public static string gmailacc = "(//android.widget.LinearLayout[@resource-id=\"com.google.android.gms:id/container\"])[2]";
        public static string setings = "//android.view.View[@content-desc=\"Settings\"]";
        public static string logout = "//android.widget.ImageView[@content-desc=\"Logout\"]";
        public static string profile = "//android.widget.ImageView[@index=5]";
        public static string logout2 = "//android.view.View[@index=2]";
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Reflection;

namespace Tab3r.Utils.myAssembly
{
    static public class myAssemblyInfo
    {
        public static Version AssemblyVersion 
        { 
            get 
            { 
                return Assembly.GetCallingAssembly().GetName().Version; 
            } 
        }

        public static string getMyVersionString
        {
            get
            {
                Version v = AssemblyVersion;
                string versionString = string.Empty;
                versionString = "v" + v.Major + "." + v.Minor + "." + v.Build + " (Revision " + v.Revision + ")";

                return versionString;
            }
        }

        public static string Title
        {
            get
            {
                object[] attributes = Assembly.GetCallingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                return attributes.Length == 0 ? "" : ((AssemblyTitleAttribute)attributes[0]).Title;
            }
        }

        public static string ProductName
        {
            get
            {
                object[] attributes = Assembly.GetCallingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                return attributes.Length == 0 ? "" : ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public static string Description
        {
            get
            {
                object[] attributes = Assembly.GetCallingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                return attributes.Length == 0 ? "" : ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public static string Copyright
        {
            get
            {
                object[] attributes = Assembly.GetCallingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                return attributes.Length == 0 ? "" : ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public static string CompanyName
        {
            get
            {
                object[] attributes = Assembly.GetCallingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                return attributes.Length == 0 ? "" : ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }

    }
}

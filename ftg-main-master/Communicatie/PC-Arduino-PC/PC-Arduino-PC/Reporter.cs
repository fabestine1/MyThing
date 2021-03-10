using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Garagemanagement
{
    /// <summary>
    /// USAGE:
    /// 
    /// Reporter.AddReport(1,"text");
    ///   Add a report with target one
    /// 
    /// -----
    ///  int target;
    ///  object report;
    /// 
    ///  if(Reporter.GetReport(out target, out report))
    ///  {//if there is a report
    ///          
    ///     //target 1
    ///     //report = (string) "text"
    ///     
    ///     do something with target, like switch
    ///     
    ///     switch(target)
    ///     {
    ///         case 1:
    ///         {
    ///             ListBox.Items.Add(report.ToString());
    ///             break;
    ///         }
    ///     }
    ///  }
    /// </summary>
    public static class Reporter
    {

        static List<int> targets;
        static List<object> reports;

        static Reporter()
        {
            targets = new List<int>();
            reports = new List<object>();
        }

        public static bool AddReport(int target, object report)
        {

            //only valid objects and targets allowed (1 > )
            if (report == null || target < 1)
            {
                return false;
            }

            targets.Add(target);
            reports.Add(report);

            return true;
        }

        public static bool GetReport(out int target, out object report)
        {
            target = -1;
            report = null;

            if (targets.Count!=0)
            {
                target = targets.ElementAt(0);
                report = reports.ElementAt(0);

                targets.RemoveAt(0);
                reports.RemoveAt(0);
                return true;
            }

            return false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AidImpactTraining.Models
{
    public class FormattingService
    {
        /// <summary>
        /// Display only the french date
        /// </summary>
        /// <param name="date">user date</param>
        /// <returns></returns>
        public string AsReadableDate(DateTime date)
        {
            return $"{date.Day}/{date.Month}/{date.Year}";
            // return date.ToString("D");
        }
    }
}

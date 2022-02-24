﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLiberary
{
    public static class MyGPA
    {
        /// <summary>
        /// Calculate grade from score
        /// </summary>
        /// <param name="score">student score</param>
        /// <returns>Grade from score </returns>
        public static string calculateGrade(double score)
        {
            /*if (score >= 50)
                return "S";
            else
                return "F";
            */

            return score >= 50 ? "S" : "F";


        }
    }
}

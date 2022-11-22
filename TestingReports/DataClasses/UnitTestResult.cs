using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingReports.DataClasses
{
    public class UnitTestResult
    {
        /// <summary>
        /// The name of the class that the unit test tests
        /// </summary>
        public string? ClassName { get; set; }

        /// <summary>
        /// The name of the method that the unit test tests
        /// </summary>
        public string? MethodName { get; set; }

        /// <summary>
        /// The name of the test
        /// </summary>
        public string? TestName { get; set; }                      

        /// <summary>
        /// Description of the test
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// Outcome of the UnitTest.
        /// Can be: Passed, Failed, Skipped or Inconclusive
        /// </summary>
        public string? Outcome { get; set; }

        /// <summary>
        /// Error message of the unit test if it it failed
        /// </summary>
        public string? ErrorMessage { get; set; }


        /// <summary>
        /// Name of person who has written the test
        /// </summary>
        public string? WrittenBy { get; set; }

        /// <summary>
        /// Name of person who has code reviewed the test
        /// </summary>
        public string? ReviewedBy { get; set; }


        /// <summary>
        /// Time is seconds how long the test took to finish
        /// Currently not yet in use (28-09-2022)
        /// </summary>
        public decimal TestTime { get; set; }
    }
}

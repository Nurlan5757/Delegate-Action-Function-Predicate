using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Delegate__Action__Function__Predicate_2.Models
{
    internal class Exam
    {
        public string Subject {  get; set; }
        public int ExamDuration { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate {  get; set; }


        public Exam(string subject,int examDuration, DateTime startDate )
        {
            Subject = subject;
            ExamDuration = examDuration;
            StartDate =  DateTime.Now;
            EndDate = StartDate.AddHours(ExamDuration);
        }

        public void Start()
        {
            StartDate = DateTime.Now;
        }


    }
}

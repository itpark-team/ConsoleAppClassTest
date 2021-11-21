using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppClassTest
{
    class TaskItem
    {
        public enum ImportaceGrade
        {
            NotImportant,
            Important,
            ReallyImportant
        }

        private DateTime startDateTime;
        private DateTime finishDateTime;
        private string title;
        private string description;
        private ImportaceGrade importaceGrade;

        public TaskItem(string startDateTime, string finishDateTime, string title, string description, ImportaceGrade importaceGrade)
        {
            this.startDateTime = DateTime.Parse(startDateTime);
            this.finishDateTime = DateTime.Parse(finishDateTime);
            this.title = title;
            this.description = description;
            this.importaceGrade = importaceGrade;
        }

        public override string ToString()
        {
            return $"{title}\n{description}\nначало работ:{startDateTime}\nконец работ:{finishDateTime}\nважность: {importaceGrade}";
        }

        public int CaclulateDuration()
        {
            return (finishDateTime - startDateTime).Days;
        }


    }
}

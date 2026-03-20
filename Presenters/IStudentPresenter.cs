using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dpiotrowski_lab1.Presenters
{
    internal interface IStudentPresenter
    {
        public void AddStudent(StudentData studentData);
        public void UpdateStudent(IDStudentData studentData);
        public void DropStudent(Guid studentId);

        public void LoadStudentToForm(Guid studentId);
        public void SaveStudentListToFile(string filename);
        public void LoadStudentListFromFile(string filename);
    }
}

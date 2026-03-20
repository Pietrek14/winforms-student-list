using dpiotrowski_lab1.Models;
using dpiotrowski_lab1.Presenters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dpiotrowski_lab1.Views
{

    internal interface IAddStudentView
    {
        event EventHandler<StudentData> AddNewStudent;
        event EventHandler<IDStudentData> UpdateStudent;
        event EventHandler<Guid> DropStudent;

        void LoadStudentIntoForm(StudentData student);
        void ShowMessage(String message);
    }
}

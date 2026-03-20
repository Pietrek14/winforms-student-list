using dpiotrowski_lab1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dpiotrowski_lab1.Views
{
    internal interface IStudentListView
    {
        event EventHandler<Guid> LoadStudent;
        event EventHandler<string> SaveStudentListToFile;
        event EventHandler<string> LoadStudentListFromFile;

        void UpdateStudentList(List<Student> students);
    }
}

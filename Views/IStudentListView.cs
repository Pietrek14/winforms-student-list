using dpiotrowski_lab1.Models;
using dpiotrowski_lab1.Presenters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dpiotrowski_lab1.Views
{
    internal interface IStudentListView
    {
        public void UpdateStudentList(List<IDStudentData> students);
    }
}

using dpiotrowski_lab1.Models;
using dpiotrowski_lab1.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dpiotrowski_lab1.Presenters
{
    internal class StudentPresenter
    {
        private IAddStudentView _addStudentView;
        private IStudentListView _studentListView;
        private StudentRegister _model;

        public StudentPresenter(IAddStudentView addStudentView, IStudentListView studentListView, StudentRegister model) {
            this._addStudentView = addStudentView;
            this._studentListView = studentListView;
            this._model = model;

            this._addStudentView.AddNewStudent += this._addStudent;
        }

        private void _addStudent(object? sender, StudentData studentData)
        {
            Student student;

            try
            {
                student = StudentValidator.FromStudentData(studentData);
            }
            catch(ArgumentException exception)
            {
                this._addStudentView.ShowMessage(exception.Message);
                return;
            }

            this._model.AddStudent(student);
        }
    }
}

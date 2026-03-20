using dpiotrowski_lab1.Models;
using dpiotrowski_lab1.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dpiotrowski_lab1.Presenters
{
    internal class StudentPresenter : IStudentPresenter, IStudentRegisterSubscriber
    {
        private IAddStudentView _addStudentView;
        private IStudentListView _studentListView;
        private StudentRegister _model;

        public StudentPresenter(IAddStudentView addStudentView, IStudentListView studentListView, StudentRegister model) {
            this._addStudentView = addStudentView;
            this._studentListView = studentListView;
            this._model = model;

            this._model.Subscribe(this);
        }

        ~StudentPresenter() { 
            this._model.Unsubscribe(this);
        }

        public void AddStudent(StudentData studentData)
        {
            Student student = StudentValidator.FromStudentData(studentData);

            this._model.AddStudent(student);
        }

        public void UpdateStudent(IDStudentData studentData)
        {
            Student newStudent = StudentValidator.FromStudentData(studentData);

            Student student = this._model.GetStudent(studentData.Id);

            if(student.DateOfBirth != newStudent.DateOfBirth)
            {
                throw new ArgumentException("Data urodzenia studenta nie może być zmieniona.");
            }

            student.Name = newStudent.Name;
            student.LastName = newStudent.LastName;
            student.Address = newStudent.Address;
            student.YearOfStudy = newStudent.YearOfStudy;
        }

        public void DropStudent(Guid studentId)
        {
            this._model.DropStudent(studentId);
        }

        public void LoadStudentToForm(Guid studentId)
        {
            Student student = this._model.GetStudent(studentId);
            StudentData studentData = StudentValidator.FromStudent(student);
            this._addStudentView.LoadStudentIntoForm(studentData);
        }

        public void SaveStudentListToFile(string filename)
        {
            StudentJsonHelper.SaveStudentRegister(this._model, filename);
        }

        public void LoadStudentListFromFile(string filename)
        {
            StudentRegister? newRegister = StudentJsonHelper.LoadStudentRegister(filename);

            if (newRegister == null)
            {
                throw new FileLoadException($"Nie udało się wczytać listy studentów z pliku {filename}.");
            }

            this._model.Unsubscribe(this);

            this._model = newRegister;

            this._model.Subscribe(this);
        }

        public void StudentUpdate()
        {
            List<Student> students = this._model.GetStudents();

            this._studentListView.UpdateStudentList(students.Select(student => StudentValidator.FromStudent(student)));
        }
    }
}

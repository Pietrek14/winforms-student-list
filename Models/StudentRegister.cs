using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dpiotrowski_lab1.Models
{
    public class StudentRegister
    {
        private Dictionary<Guid, Student> _students = new();
        private List<IStudentRegisterSubscriber> _subscribers = new();

        public Dictionary<Guid, Student> Students { get { return _students; } }

        public void AddStudent(Student student)
        {
            _students[student.Id] = student;

            this._updateSubscribers();
        }

        public Student GetStudent(Guid id)
        {
            return _students[id];
        }

        public List<Student> GetStudents()
        {
            return _students.Values.ToList();
        }

        public void DropStudent(Guid id)
        {
            if (!_students.ContainsKey(id))
            {
                throw new KeyNotFoundException($"tried to drop a nonexistent student with id {id}");
            }

            _students.Remove(id);

            this._updateSubscribers();
        }

        public void Subscribe(IStudentRegisterSubscriber subscriber) { 
            this._subscribers.Add(subscriber);
        }

        public void Unsubscribe(IStudentRegisterSubscriber subscriber)
        {
            this._subscribers.Remove(subscriber);
        }

        private void _updateSubscribers()
        {
            foreach (var subscriber in this._subscribers)
            {
                subscriber.StudentUpdate();
            }
        }
    }
}

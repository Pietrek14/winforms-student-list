using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace dpiotrowski_lab1.Models
{
    internal static class StudentJsonHelper
    {
        static public void SaveStudentRegister(StudentRegister register, string filename)
        {
            string serialized = JsonSerializer.Serialize(register);

            File.WriteAllText(filename, serialized);
        }

        static public StudentRegister? LoadStudentRegister(string filename)
        {
            Debug.WriteLine("AAAAAA");

            string serialized = File.ReadAllText(filename);

            Debug.WriteLine(serialized);

            return JsonSerializer.Deserialize<StudentRegister>(serialized);
        }
    }
}

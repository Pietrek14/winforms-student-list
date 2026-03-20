using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace dpiotrowski_lab1.Models
{
    internal static class StudentJsonHelper
    {
        static void SaveStudentRegister(StudentRegister register, string filename)
        {
            string serialized = JsonSerializer.Serialize(register);

            File.WriteAllText(filename, serialized);
        }

        static StudentRegister LoadStudentRegister(string filename)
        {
            string serialized = File.ReadAllText(filename);

            return JsonSerializer.Deserialize<StudentRegister>(serialized);
        }
    }
}

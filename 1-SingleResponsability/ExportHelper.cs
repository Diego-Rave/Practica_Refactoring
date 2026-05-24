using System.Text;
using System.IO;

namespace SingleResponsability
{
    public class CsvFormatter
    {
        // Única responsabilidad: Transformar los objetos a formato CSV
        public string FormatStudentsToCsv(IEnumerable<Student> students)
        {
            var sb = new StringBuilder();
            sb.AppendLine("Id;Fullname;Grades");

            foreach (var student in students)
            {
                var gradesString = string.Join("|", student.Grades);
                sb.AppendLine($"{student.Id};{student.Fullname};{gradesString}");
            }

            return sb.ToString();
        }
    }

    public class FileExporter
    {
        // Única responsabilidad: Escribir un texto en el sistema de archivos
        public void SaveToFile(string content, string fileName)
        {
            var filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);
            File.WriteAllText(filePath, content, Encoding.Unicode);
        }
    }
}
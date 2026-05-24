using SingleResponsability;

StudentRepository studentRepository = new();
var formatter = new CsvFormatter();
var exporter = new FileExporter();

string csvData = formatter.FormatStudentsToCsv(studentRepository.GetAll());
exporter.SaveToFile(csvData, "Students.csv");
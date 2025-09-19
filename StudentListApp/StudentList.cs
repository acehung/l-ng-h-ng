using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace StudentListApp
{
    public class StudentList
    {
        private List<Student> students = new List<Student>();
        private string currentFile = "";

        // Load danh sách sinh viên từ file
        public void LoadFromFile(string filePath)
        {
            currentFile = filePath;
            students.Clear();

            if (!File.Exists(filePath))
            {
                File.Create(filePath).Close();
                return;
            }

            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                if (string.IsNullOrWhiteSpace(line)) continue;
                string[] parts = line.Split(',');
                if (parts.Length != 3) continue;

                string name = parts[0].Trim();
                int semester;
                if (!int.TryParse(parts[1].Trim(), out semester)) continue;
                string course = parts[2].Trim();

                if (course == "Java" || course == ".Net" || course == "C/C++")
                {
                    students.Add(new Student(name, semester, course));
                }
            }
        }

        // Lưu danh sách sinh viên vào file
        public void SaveToFile()
        {
            if (string.IsNullOrEmpty(currentFile)) return;
            using (StreamWriter sw = new StreamWriter(currentFile))
            {
                foreach (Student s in students)
                {
                    sw.WriteLine($"{s.Name},{s.Semester},{s.CourseName}");
                }
            }
        }

        // Tìm sinh viên theo tên (không phân biệt hoa/thường)
        public void SearchByName(string name)
        {
            List<Student> results = new List<Student>();
            foreach (var s in students)
            {
                if (!string.IsNullOrEmpty(s.Name) &&
                    s.Name.ToLower().Contains(name.ToLower()))
                {
                    results.Add(s);
                }
            }

            if (results.Count == 0)
            {
                Console.WriteLine("Không tìm thấy.");
                return;
            }

            Console.WriteLine("\nKết quả tìm kiếm:");
            Console.WriteLine("Name                 | Semester | Course");
            Console.WriteLine("-------------------------------------------");
            foreach (var s in results)
            {
                Console.WriteLine(s);
            }
        }

        // Sửa sinh viên
        public void EditStudent(string name)
        {
            Student student = null;
            foreach (var s in students)
            {
                if (!string.IsNullOrEmpty(s.Name) && s.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    student = s;
                    break;
                }
            }

            if (student == null)
            {
                Console.WriteLine("Không tìm thấy sinh viên để sửa.");
                return;
            }

            Console.Write("Tên mới: ");
            string newName = Console.ReadLine();
            Console.Write("Học kỳ mới: ");
            int newSem;
            while (!int.TryParse(Console.ReadLine(), out newSem))
            {
                Console.Write("Học kỳ không hợp lệ. Nhập lại: ");
            }
            Console.Write("Khóa học mới (Java/.Net/C/C++): ");
            string newCourse = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(newName)) student.Name = newName;
            student.Semester = newSem;
            if (newCourse == "Java" || newCourse == ".Net" || newCourse == "C/C++")
                student.CourseName = newCourse;

            SaveToFile();
            Console.WriteLine("Đã lưu sinh viên.");
        }

        // Xóa sinh viên
        public void DeleteStudent(string name)
        {
            Student student = null;
            foreach (var s in students)
            {
                if (!string.IsNullOrEmpty(s.Name) && s.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    student = s;
                    break;
                }
            }

            if (student == null)
            {
                Console.WriteLine("Không tìm thấy sinh viên để xóa.");
                return;
            }

            students.Remove(student);
            SaveToFile();
            Console.WriteLine("Đã xóa sinh viên.");
        }

        // Thống kê sinh viên theo tên + khóa học
        public void Statistic()
        {
            var stats = new Dictionary<string, int>();
            foreach (var s in students)
            {
                string key = s.Name + "|" + s.CourseName;
                if (stats.ContainsKey(key))
                    stats[key]++;
                else
                    stats[key] = 1;
            }

            Console.WriteLine("\nStudent Name         | Course     | Total");
            Console.WriteLine("-------------------------------------------");
            foreach (var kv in stats)
            {
                string[] parts = kv.Key.Split('|');
                Console.WriteLine("{0,-20} | {1,-10} | {2}", parts[0], parts[1], kv.Value);
            }
        }

        // Thêm sinh viên mới
        public void AddStudent(Student student)
        {
            if (student == null) return;
            students.Add(student);
            SaveToFile();
            Console.WriteLine("Đã thêm sinh viên mới.");
        }
    }
}

using System;

namespace StudentListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            StudentList list = new StudentList();
            string filePath = "students.txt";
            list.LoadFromFile(filePath);

            while (true)
            {
                Console.WriteLine("\n--- MENU ---");
                Console.WriteLine("1. Thêm sinh viên");
                Console.WriteLine("2. Tìm kiếm sinh viên");
                Console.WriteLine("3. Sửa thông tin sinh viên");
                Console.WriteLine("4. Xóa sinh viên");
                Console.WriteLine("5. Thống kê số lần đăng ký");
                Console.WriteLine("6. Thoát");
                Console.Write("Chọn: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Tên sinh viên: ");
                        string name = Console.ReadLine();
                        int semester;
                        Console.Write("Học kỳ: ");
                        while (!int.TryParse(Console.ReadLine(), out semester))
                        {
                            Console.Write("Học kỳ không hợp lệ. Nhập lại: ");
                        }
                        Console.Write("Khóa học (Java/.Net/C/C++): ");
                        string course = Console.ReadLine();
                        if (course != "Java" && course != ".Net" && course != "C/C++")
                        {
                            Console.WriteLine("Khóa học không hợp lệ. Hủy thêm sinh viên.");
                            break;
                        }
                        list.AddStudent(new Student(name, semester, course));
                        break;

                    case "2":
                        Console.Write("Nhập tên cần tìm: ");
                        list.SearchByName(Console.ReadLine());
                        break;

                    case "3":
                        Console.Write("Nhập tên sinh viên cần sửa: ");
                        list.EditStudent(Console.ReadLine());
                        break;

                    case "4":
                        Console.Write("Nhập tên sinh viên cần xóa: ");
                        list.DeleteStudent(Console.ReadLine());
                        break;

                    case "5":
                        list.Statistic();
                        break;

                    case "6":
                        return;

                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ.");
                        break;
                }
            }
        }
    }
}

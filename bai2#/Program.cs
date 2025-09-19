using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2_
{
    class Program
    {
        static void Main(string[] args)
        {

                Console.OutputEncoding = System.Text.Encoding.UTF8;
                Console.InputEncoding = System.Text.Encoding.UTF8;
            
            ArrayProcessor ap = new ArrayProcessor();
            ap.Input();

            Console.WriteLine("\nMảng ban đầu:");
            ap.Display();

            Console.WriteLine("\nChọn chức năng:");
            Console.WriteLine("1. Bubble Sort");
            Console.WriteLine("2. Quick Sort");
            Console.WriteLine("3. Linear Search");
            Console.WriteLine("4. Binary Search");
            Console.Write("Nhập lựa chọn: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    ap.BubbleSort();
                    Console.WriteLine("Mảng sau khi Bubble Sort:");
                    ap.Display();
                    break;

                case 2:
                    int[] arr = ap.GetArray();
                    ap.QuickSort(0, arr.Length - 1);
                    Console.WriteLine("Mảng sau khi Quick Sort:");
                    ap.Display();
                    break;

                case 3:
                    Console.Write("Nhập giá trị cần tìm: ");
                    int key1 = int.Parse(Console.ReadLine());
                    int pos1 = ap.LinearSearch(key1);
                    if (pos1 != -1)
                        Console.WriteLine($"Tìm thấy {key1} tại vị trí {pos1}");
                    else
                        Console.WriteLine("Không tìm thấy!");
                    break;

                case 4:
                    Console.Write("Nhập giá trị cần tìm: ");
                    int key2 = int.Parse(Console.ReadLine());
                    int pos2 = ap.BinarySearch(key2);
                    if (pos2 != -1)
                        Console.WriteLine($"Tìm thấy {key2} tại vị trí {pos2}");
                    else
                        Console.WriteLine("Không tìm thấy!");
                    break;

                default:
                    Console.WriteLine("Lựa chọn không hợp lệ!");
                    break;
            }
        }
    }
}


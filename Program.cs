using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace bai3_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; // hiển thị tiếng Việt
            Console.InputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Nhập đoạn văn bản:");
            string inputText = Console.ReadLine();

            // Chuẩn hóa văn bản
            string normalizedText = NormalizeText(inputText);

            // Thống kê văn bản
            Dictionary<string, int> wordFrequency = GetWordFrequency(normalizedText);
            int totalWords = wordFrequency.Values.Sum();
            int distinctWords = wordFrequency.Keys.Count;

            // Hiển thị kết quả
            Console.WriteLine("\n--- Văn bản đã chuẩn hóa ---");
            Console.WriteLine(normalizedText);

            Console.WriteLine("\n--- Thống kê tần suất từ ---");
            Console.WriteLine("Tổng số từ: " + totalWords);
            Console.WriteLine("Số lượng từ khác nhau: " + distinctWords);
            Console.WriteLine("\nTừ\tSố lần xuất hiện");
            foreach (var kv in wordFrequency.OrderByDescending(kv => kv.Value))
            {
                Console.WriteLine($"{kv.Key}\t{kv.Value}");
            }

            Console.WriteLine("\nNhấn phím bất kỳ để thoát...");
            Console.ReadKey();
        }

        // Hàm chuẩn hóa văn bản
        static string NormalizeText(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return "";

            // Xóa khoảng trắng thừa
            text = Regex.Replace(text.Trim(), @"\s+", " ");

            // Chuyển ký tự đầu câu thành chữ hoa
            string[] sentences = text.Split(new char[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < sentences.Length; i++)
            {
                string s = sentences[i].Trim();
                if (s.Length > 0)
                {
                    sentences[i] = char.ToUpper(s[0]) + s.Substring(1);
                }
            }

            // Ghép lại các câu, giữ dấu chấm, thêm khoảng trắng
            string result = "";
            int index = 0;
            foreach (char c in text)
            {
                if (c == '.' || c == '!' || c == '?')
                {
                    result += sentences[index] + c + " ";
                    index++;
                }
            }

            result = result.Trim();
            return result;
        }

        // Hàm thống kê tần suất từ
        static Dictionary<string, int> GetWordFrequency(string text)
        {
            Dictionary<string, int> freq = new Dictionary<string, int>();
            string[] words = text.Split(new char[] { ' ', '.', ',', '!', '?', ';', ':', '\'', '\"', '(', ')', '\n', '\r' },
                                        StringSplitOptions.RemoveEmptyEntries);

            foreach (string w in words)
            {
                string word = w.ToLower();
                if (freq.ContainsKey(word))
                    freq[word]++;
                else
                    freq[word] = 1;
            }

            return freq;
        }
    }
}

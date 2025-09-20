using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.IO;

namespace LearningCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n===== MENU =====");
                Console.WriteLine("1. Bai 1 - Xu ly ma tran");
                Console.WriteLine("2. Bai 2 - Array Processor");
                Console.WriteLine("3. Bai 3 - Text Processor");
                Console.WriteLine("4. Bai 4 - Doi he co so");
                Console.WriteLine("5. Bai 5 - Quan ly sinh vien");
                Console.WriteLine("0. Thoat");
                Console.Write("Chon: ");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1": MatrixProgram.Run(); break;
                    case "2": ArrayProcessor.Run(); break;
                    case "3": TextProcessor.Run(); break;
                    case "4": BaseConverter.Run(); break;
                    case "5": StudentManager.Run(); break;
                    case "0": return;
                    default: Console.WriteLine("Lua chon khong hop le"); break;
                }
            }
        }
    }

    class MatrixProgram
    {
        public static void Run()
        {
            Console.Write("Nhap so dong ma tran A: ");
            int rowsA = int.Parse(Console.ReadLine());
            Console.Write("Nhap so cot ma tran A: ");
            int colsA = int.Parse(Console.ReadLine());
            int[,] A = InputMatrix(rowsA, colsA, "A");
            Console.Write("Nhap so dong ma tran B: ");
            int rowsB = int.Parse(Console.ReadLine());
            Console.Write("Nhap so cot ma tran B: ");
            int colsB = int.Parse(Console.ReadLine());
            int[,] B = InputMatrix(rowsB, colsB, "B");
            Console.WriteLine("Ma tran A:");
            PrintMatrix(A);
            Console.WriteLine("Ma tran B:");
            PrintMatrix(B);
            if (rowsA == rowsB && colsA == colsB)
            {
                int[,] sum = AddMatrix(A, B);
                Console.WriteLine("A + B:");
                PrintMatrix(sum);
            }
            else Console.WriteLine("Khong the cong 2 ma tran khong cung kich thuoc");
            if (colsA == rowsB)
            {
                int[,] prod = MultiplyMatrix(A, B);
                Console.WriteLine("A x B:");
                PrintMatrix(prod);
            }
            else Console.WriteLine("Khong the nhan A x B do colsA != rowsB");
            Console.WriteLine("Chuyen vi ma tran A:");
            PrintMatrix(Transpose(A));
            FindMinMax(A);
            if (rowsA == colsA)
            {
                int det = Determinant(A, rowsA);
                Console.WriteLine("Determinant A = " + det);
                Console.WriteLine(IsSymmetric(A) ? "A la ma tran doi xung" : "A khong doi xung");
            }
        }

        static int[,] InputMatrix(int r, int c, string name)
        {
            int[,] m = new int[r, c];
            Console.WriteLine("Nhap ma tran " + name + ":");
            for (int i = 0; i < r; i++)
                for (int j = 0; j < c; j++)
                {
                    Console.Write($"[{i},{j}] = ");
                    m[i, j] = int.Parse(Console.ReadLine());
                }
            return m;
        }

        static void PrintMatrix(int[,] m)
        {
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++) Console.Write(m[i, j] + "\t");
                Console.WriteLine();
            }
        }

        static int[,] AddMatrix(int[,] A, int[,] B)
        {
            int r = A.GetLength(0), c = A.GetLength(1);
            int[,] C = new int[r, c];
            for (int i = 0; i < r; i++) for (int j = 0; j < c; j++) C[i, j] = A[i, j] + B[i, j];
            return C;
        }

        static int[,] MultiplyMatrix(int[,] A, int[,] B)
        {
            int r = A.GetLength(0), c = B.GetLength(1), n = A.GetLength(1);
            int[,] C = new int[r, c];
            for (int i = 0; i < r; i++)
                for (int j = 0; j < c; j++)
                {
                    C[i, j] = 0;
                    for (int k = 0; k < n; k++) C[i, j] += A[i, k] * B[k, j];
                }
            return C;
        }

        static int[,] Transpose(int[,] A)
        {
            int r = A.GetLength(0), c = A.GetLength(1);
            int[,] T = new int[c, r];
            for (int i = 0; i < r; i++) for (int j = 0; j < c; j++) T[j, i] = A[i, j];
            return T;
        }

        static void FindMinMax(int[,] A)
        {
            int min = A[0, 0], max = A[0, 0];
            foreach (int v in A)
            {
                if (v < min) min = v;
                if (v > max) max = v;
            }
            Console.WriteLine("Max = " + max + ", Min = " + min);
        }

        static int Determinant(int[,] A, int n)
        {
            if (n == 1) return A[0, 0];
            if (n == 2) return A[0, 0] * A[1, 1] - A[0, 1] * A[1, 0];
            int det = 0;
            for (int col = 0; col < n; col++)
            {
                int[,] sub = new int[n - 1, n - 1];
                for (int i = 1; i < n; i++)
                {
                    int subCol = 0;
                    for (int j = 0; j < n; j++)
                    {
                        if (j == col) continue;
                        sub[i - 1, subCol++] = A[i, j];
                    }
                }
                det += (col % 2 == 0 ? 1 : -1) * A[0, col] * Determinant(sub, n - 1);
            }
            return det;
        }

        static bool IsSymmetric(int[,] A)
        {
            int n = A.GetLength(0);
            for (int i = 0; i < n; i++) for (int j = i + 1; j < n; j++) if (A[i, j] != A[j, i]) return false;
            return true;
        }
    }

    class ArrayProcessor
    {
        public static void Run()
        {
            Console.Write("Nhap so phan tu: ");
            int n = int.Parse(Console.ReadLine());
            int[] orig = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"arr[{i}] = ");
                orig[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Mang ban dau: " + string.Join(", ", orig));
            int[] a1 = (int[])orig.Clone();
            BubbleSort(a1);
            Console.WriteLine("Sau Bubble Sort: " + string.Join(", ", a1));
            int[] a2 = (int[])orig.Clone();
            QuickSort(a2, 0, a2.Length - 1);
            Console.WriteLine("Sau Quick Sort: " + string.Join(", ", a2));
            Console.Write("Nhap so can tim: ");
            int key = int.Parse(Console.ReadLine());
            int idxLinear = LinearSearch(orig, key);
            Console.WriteLine("LinearSearch index = " + idxLinear);
            int idxBinary = BinarySearch(a2, key);
            Console.WriteLine("BinarySearch index = " + idxBinary);
        }

        static void BubbleSort(int[] a)
        {
            for (int i = 0; i < a.Length - 1; i++)
                for (int j = 0; j < a.Length - i - 1; j++)
                    if (a[j] > a[j + 1])
                    {
                        int t = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = t;
                    }
        }

        static void QuickSort(int[] a, int left, int right)
        {
            int i = left, j = right;
            int pivot = a[(left + right) / 2];
            while (i <= j)
            {
                while (a[i] < pivot) i++;
                while (a[j] > pivot) j--;
                if (i <= j)
                {
                    int tmp = a[i]; a[i] = a[j]; a[j] = tmp;
                    i++; j--;
                }
            }
            if (left < j) QuickSort(a, left, j);
            if (i < right) QuickSort(a, i, right);
        }

        static int LinearSearch(int[] a, int key)
        {
            for (int i = 0; i < a.Length; i++) if (a[i] == key) return i;
            return -1;
        }

        static int BinarySearch(int[] a, int key)
        {
            int l = 0, r = a.Length - 1;
            while (l <= r)
            {
                int mid = (l + r) / 2;
                if (a[mid] == key) return mid;
                if (a[mid] < key) l = mid + 1; else r = mid - 1;
            }
            return -1;
        }
    }

    class TextProcessor
    {
        public static void Run()
        {
            Console.Write("Nhap van ban: ");
            string text = Console.ReadLine() ?? "";
            text = Regex.Replace(text.Trim(), @"\s+", " ");
            text = Regex.Replace(text, @"(^\w)|(\.\s+\w)", m => m.Value.ToUpper());
            Console.WriteLine("Van ban chuan hoa: " + text);
            var words = text.ToLower().Split(new char[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("Tong so tu: " + words.Length);
            Console.WriteLine("So tu khac nhau: " + words.Distinct().Count());
            var freq = words.GroupBy(w => w).ToDictionary(g => g.Key, g => g.Count());
            Console.WriteLine("Tan suat tu:");
            foreach (var kv in freq) Console.WriteLine(kv.Key + " : " + kv.Value);
        }
    }

    class BaseConverter
    {
        public static void Run()
        {
            while (true)
            {
                Console.WriteLine("\n1: Binary  2: Decimal  3: Hexadecimal");
                Console.Write("Chon he nhap (0 de thoat): ");
                if (!int.TryParse(Console.ReadLine(), out int from)) break;
                if (from == 0) break;
                Console.Write("Chon he xuat: ");
                int to = int.Parse(Console.ReadLine());
                Console.Write("Nhap gia tri: ");
                string val = Console.ReadLine();
                try
                {
                    int number = from switch { 1 => Convert.ToInt32(val, 2), 2 => int.Parse(val), 3 => Convert.ToInt32(val, 16), _ => throw new Exception("Sai lua chon") };
                    string res = to switch { 1 => Convert.ToString(number, 2), 2 => number.ToString(), 3 => number.ToString("X"), _ => "Sai lua chon" };
                    Console.WriteLine("Ket qua: " + res);
                }
                catch (Exception ex) { Console.WriteLine("Loi: " + ex.Message); }
            }
        }
    }

    class Student
    {
        public string Name { get; set; }
        public int Semester { get; set; }
        public string CourseName { get; set; }
    }

    class StudentManager
    {
        private static List<Student> students = new List<Student>();
        private const string filePath = "students.txt";

        public static void Run()
        {
            LoadFromFile();
            while (true)
            {
                Console.WriteLine("\n1. Them sinh vien");
                Console.WriteLine("2. Tim kiem theo ten");
                Console.WriteLine("3. Sua thong tin");
                Console.WriteLine("4. Xoa thong tin");
                Console.WriteLine("5. Thong ke so lan dang ky");
                Console.WriteLine("0. Thoat");
                Console.Write("Chon: ");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1": AddStudent(); break;
                    case "2": SearchStudent(); break;
                    case "3": EditStudent(); break;
                    case "4": DeleteStudent(); break;
                    case "5": Statistic(); break;
                    case "0": SaveToFile(); return;
                    default: Console.WriteLine("Lua chon khong hop le"); break;
                }
            }
        }

        static void AddStudent()
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Semester: ");
            int sem = int.Parse(Console.ReadLine());
            Console.Write("Course (Java/.Net/C++): ");
            string course = Console.ReadLine();
            students.Add(new Student { Name = name, Semester = sem, CourseName = course });
            Console.WriteLine("Da them sinh vien.");
        }

        static void SearchStudent()
        {
            Console.Write("Nhap ten: ");
            string name = Console.ReadLine();
            var result = students.Where(s => s.Name.Contains(name, StringComparison.OrdinalIgnoreCase));
            foreach (var s in result) Console.WriteLine(s.Name + " | " + s.Semester + " | " + s.CourseName);
        }

        static void EditStudent()
        {
            Console.Write("Nhap ten sinh vien can sua: ");
            string name = Console.ReadLine();
            var student = students.FirstOrDefault(s => s.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
            if (student != null)
            {
                Console.Write("Ten moi (bo trong neu giu nguyen): ");
                string newName = Console.ReadLine();
                if (!string.IsNullOrEmpty(newName)) student.Name = newName;
                Console.Write("Semester moi (Enter de giu nguyen): ");
                string semStr = Console.ReadLine();
                if (int.TryParse(semStr, out int newSem)) student.Semester = newSem;
                Console.Write("Course moi (Enter de giu nguyen): ");
                string newCourse = Console.ReadLine();
                if (!string.IsNullOrEmpty(newCourse)) student.CourseName = newCourse;
                Console.WriteLine("Da cap nhat thong tin.");
            }
            else Console.WriteLine("Khong tim thay sinh vien.");
        }

        static void DeleteStudent()
        {
            Console.Write("Nhap ten sinh vien can xoa: ");
            string name = Console.ReadLine();
            var student = students.FirstOrDefault(s => s.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
            if (student != null)
            {
                students.Remove(student);
                Console.WriteLine("Da xoa sinh vien.");
            }
            else Console.WriteLine("Khong tim thay sinh vien.");
        }

        static void Statistic()
        {
            var stats = students.GroupBy(s => new { s.Name, s.CourseName }).Select(g => new { g.Key.Name, g.Key.CourseName, Count = g.Count() });
            Console.WriteLine("Student Name | Course | Total of Course");
            foreach (var st in stats) Console.WriteLine(st.Name + " | " + st.CourseName + " | " + st.Count);
        }

        static void LoadFromFile()
        {
            if (!File.Exists(filePath)) return;
            foreach (var line in File.ReadAllLines(filePath))
            {
                var parts = line.Split('|');
                if (parts.Length >= 3)
                {
                    if (!int.TryParse(parts[1].Trim(), out int sem)) sem = 0;
                    students.Add(new Student { Name = parts[0].Trim(), Semester = sem, CourseName = parts[2].Trim() });
                }
            }
        }

        static void SaveToFile()
        {
            var lines = students.Select(s => s.Name + "|" + s.Semester + "|" + s.CourseName);
            File.WriteAllLines(filePath, lines);
            Console.WriteLine("Da luu du lieu vao file.");
        }
    }
}

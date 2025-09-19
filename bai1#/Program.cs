using System;

class MatrixApp
{
    // Hàm nhập ma trận
    static int[,] InputMatrix(int rows, int cols, string name)
    {
        int[,] matrix = new int[rows, cols];
        Console.WriteLine($"Nhập ma trận {name}:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"[{i},{j}] = ");
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }
        return matrix;
    }

    // Hiển thị ma trận
    static void PrintMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    // Cộng hai ma trận
    static int[,] AddMatrix(int[,] A, int[,] B)
    {
        int rows = A.GetLength(0);
        int cols = A.GetLength(1);
        int[,] result = new int[rows, cols];
        for (int i = 0; i < rows; i++)
            for (int j = 0; j < cols; j++)
                result[i, j] = A[i, j] + B[i, j];
        return result;
    }

    // Nhân hai ma trận
    static int[,] MultiplyMatrix(int[,] A, int[,] B)
    {
        int rowsA = A.GetLength(0);
        int colsA = A.GetLength(1);
        int rowsB = B.GetLength(0);
        int colsB = B.GetLength(1);

        if (colsA != rowsB)
        {
            Console.WriteLine("Không thể nhân hai ma trận (số cột A ≠ số dòng B).");
            return null;
        }

        int[,] result = new int[rowsA, colsB];
        for (int i = 0; i < rowsA; i++)
            for (int j = 0; j < colsB; j++)
                for (int k = 0; k < colsA; k++)
                    result[i, j] += A[i, k] * B[k, j];

        return result;
    }

    // Chuyển vị ma trận
    static int[,] Transpose(int[,] A)
    {
        int rows = A.GetLength(0);
        int cols = A.GetLength(1);
        int[,] result = new int[cols, rows];
        for (int i = 0; i < rows; i++)
            for (int j = 0; j < cols; j++)
                result[j, i] = A[i, j];
        return result;
    }

    // Tìm max và min
    static void FindMaxMin(int[,] A)
    {
        int max = A[0, 0], min = A[0, 0];
        foreach (int x in A)
        {
            if (x > max) max = x;
            if (x < min) min = x;
        }
        Console.WriteLine($"Giá trị lớn nhất: {max}");
        Console.WriteLine($"Giá trị nhỏ nhất: {min}");
    }

    // Tính định thức (đệ quy, chỉ cho ma trận vuông nhỏ)
    static int Determinant(int[,] A)
    {
        int n = A.GetLength(0);
        if (n == 1) return A[0, 0];
        if (n == 2) return A[0, 0] * A[1, 1] - A[0, 1] * A[1, 0];

        int det = 0;
        for (int col = 0; col < n; col++)
        {
            det += (int)Math.Pow(-1, col) * A[0, col] * Determinant(Minor(A, 0, col));
        }
        return det;
    }

    static int[,] Minor(int[,] A, int row, int col)
    {
        int n = A.GetLength(0);
        int[,] result = new int[n - 1, n - 1];
        int r = 0, c;
        for (int i = 0; i < n; i++)
        {
            if (i == row) continue;
            c = 0;
            for (int j = 0; j < n; j++)
            {
                if (j == col) continue;
                result[r, c] = A[i, j];
                c++;
            }
            r++;
        }
        return result;
    }

    // Kiểm tra đối xứng
    static bool IsSymmetric(int[,] A)
    {
        int rows = A.GetLength(0);
        int cols = A.GetLength(1);
        if (rows != cols) return false;

        for (int i = 0; i < rows; i++)
            for (int j = 0; j < cols; j++)
                if (A[i, j] != A[j, i]) return false;
        return true;
    }

    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.Write("Nhập số dòng: ");
        int m = int.Parse(Console.ReadLine());
        Console.Write("Nhập số cột: ");
        int n = int.Parse(Console.ReadLine());

        int[,] A = InputMatrix(m, n, "A");
        Console.WriteLine("Ma trận A:");
        PrintMatrix(A);

        // Min max
        FindMaxMin(A);

        // Transpose
        Console.WriteLine("Ma trận chuyển vị Aᵀ:");
        PrintMatrix(Transpose(A));

        // Cộng ma trận
        Console.WriteLine("Nhập ma trận B để cộng với A:");
        int[,] B = InputMatrix(m, n, "B");
        Console.WriteLine("Kết quả A + B:");
        PrintMatrix(AddMatrix(A, B));

        // Nhân ma trận
        Console.WriteLine("Nhập ma trận C để nhân với A:");
        Console.Write("Số dòng của C: ");
        int r = int.Parse(Console.ReadLine());
        Console.Write("Số cột của C: ");
        int c = int.Parse(Console.ReadLine());
        int[,] C = InputMatrix(r, c, "C");
        int[,] product = MultiplyMatrix(A, C);
        if (product != null)
        {
            Console.WriteLine("Kết quả A × C:");
            PrintMatrix(product);
        }

        // Định thức
        if (m == n)
        {
            Console.WriteLine("Định thức của A = " + Determinant(A));
            Console.WriteLine("A " + (IsSymmetric(A) ? "là" : "không phải") + " ma trận đối xứng.");
        }
    }
}

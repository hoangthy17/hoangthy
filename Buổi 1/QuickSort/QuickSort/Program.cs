using System;

class Program
{
    static void Main()
    {
        Console.Title = "Quick Sort";
        var numbers = new[] { 10, 3, 1, 7, 9, 2, 0 };

        // In ra dãy số chưa được sắp xếp
        Console.WriteLine("Truoc khi sap xep:");
        PrintArray(numbers);

        // Sắp xếp dãy số bằng thuật toán quick sort
        QuickSort(numbers, 0, numbers.Length - 1);

        // In ra dãy số đã được sắp xếp
        Console.WriteLine("\nSau khi sap xep:");
        PrintArray(numbers);

        Console.ReadKey(); // Chờ người dùng nhấn một phím trước khi đóng cửa sổ console
    }

    // Hàm sắp xếp quick sort
    static void QuickSort(int[] array, int left, int right)
    {
        if (left < right)
        {
            // Phân đoạn mảng và lấy chỉ số pivot
            int pivotIndex = Partition(array, left, right);

            // Đệ quy sắp xếp nửa trái và nửa phải của mảng
            QuickSort(array, left, pivotIndex - 1);
            QuickSort(array, pivotIndex + 1, right);
        }
    }

    // Hàm phân đoạn mảng và trả về chỉ số pivot
    static int Partition(int[] array, int left, int right)
    {
        int pivot = array[right]; // Chọn pivot là phần tử cuối cùng
        int i = left - 1; // Chỉ số của phần tử nhỏ hơn pivot

        for (int j = left; j < right; j++)
        {
            if (array[j] >= pivot)
            {
                i++;
                // Hoán đổi array[i] và array[j]
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }

        // Hoán đổi array[i+1] và array[right] (pivot)
        int temp1 = array[i + 1];
        array[i + 1] = array[right];
        array[right] = temp1;

        return i + 1; // Trả về chỉ số của pivot
    }

    // Hàm in ra mảng
    static void PrintArray(int[] array)
    {
        foreach (var number in array)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
    }
}


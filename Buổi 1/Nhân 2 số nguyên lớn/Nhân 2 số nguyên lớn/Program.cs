using System;

class Program
{
    static void Main()
    {
        string number1 = "1234";
        string number2 = "9876";

        string result = MultiplyStrings(number1, number2);

        Console.WriteLine($"Ket qua cua {number1} * {number2} là:");
        Console.WriteLine(result);
    }

    static string MultiplyStrings(string num1, string num2)
    {
        int m = num1.Length;
        int n = num2.Length;
        int[] result = new int[m + n];

        // Đảo ngược các chuỗi số để dễ xử lý
        char[] arr1 = num1.ToCharArray();
        char[] arr2 = num2.ToCharArray();
        Array.Reverse(arr1);
        Array.Reverse(arr2);

        // Nhân từng chữ số và cộng dồn vào mảng result
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                result[i + j] += (arr1[i] - '0') * (arr2[j] - '0');
                result[i + j + 1] += result[i + j] / 10;
                result[i + j] %= 10;
            }
        }

        // Xây dựng chuỗi kết quả từ mảng result
        int k = m + n - 1;
        while (k >= 0 && result[k] == 0)
        {
            k--;
        }

        if (k == -1)
        {
            return "0";
        }

        char[] chars = new char[k + 1];
        for (int i = k; i >= 0; i--)
        {
            chars[k - i] = (char)(result[i] + '0');
        }

        return new string(chars);
    }
}

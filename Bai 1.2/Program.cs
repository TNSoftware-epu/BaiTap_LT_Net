using System;
using System.Reflection;

namespace NetInfoApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Phiên bản CLR/.NET Core đang chạy (Environment.Version).
            Console.WriteLine($" Phiên bản CLR/.NET: {Environment.Version}");

            // Tên máy tính và tên người dùng đăng nhập hệ thống.
            Console.WriteLine($" Tên máy tính: {Environment.MachineName}");
            Console.WriteLine($"    Tên người dùng: {Environment.UserName}");

            // Hệ điều hành và kiến trúc CPU (64-bit / 32-bit).
            Console.WriteLine($" Hệ điều hành: {Environment.OSVersion}");
            Console.WriteLine($"    Hệ điều hành 64-bit: {(Environment.Is64BitOperatingSystem ? "Có (64-bit)" : "Không (32-bit)")}");
            Console.WriteLine($"    Kiến trúc tiến trình CPU: {(Environment.Is64BitProcess ? "64-bit" : "32-bit")}");

            // Dung lượng bộ nhớ RAM đang được Garbage Collector (GC) quản lý.
            long gcMemoryBytes = GC.GetTotalMemory(forceFullCollection: false);
            double gcMemoryMB = gcMemoryBytes / (1024.0 * 1024.0);
            Console.WriteLine($" Bộ nhớ RAM do GC quản lý: {gcMemoryBytes:N0} bytes ({gcMemoryMB:F2} MB)");

        }
    }
}
using System;

using static PInvoke.User32;

namespace PInvokeExample
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            EnumWindows((hWnd, param) =>
            {
                var length = GetWindowTextLength(hWnd);
                if (length > 0)
                {
                    var str = new char[length + 1];
                    GetWindowText(hWnd, str, str.Length);

                    Console.WriteLine(str);
                }

                return true;
            }, IntPtr.Zero);

            Console.ReadLine();
        }
    }
}
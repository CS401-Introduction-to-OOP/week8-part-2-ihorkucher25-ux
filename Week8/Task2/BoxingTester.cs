using System;

namespace Task2;

public static class BoxingTester
{
    public static void Test()
    {
        int a = 10;

        // Пакування (Boxing): значення типу int (яке живе в стек) 
        // копіюється і запаковується в новий об'єкт всередині Heap.
        object b = a;
        
        // Розпакування (Unboxing): значення витягується з об'єкта в Heap 
        // і копіюється назад у нову змінну типу int в стек.
        int c = (int)b;
        
        Console.WriteLine($"Boxing Test: a = {a}, b = {b}, c = {c}");
    }
}
using System;

class Program {
  public static void Main (string[] args) {
    int a = 5;
    int b = 10;
    Console.WriteLine($"Before swap: a = {a}, b = {b}");

    int temp = a;
    a = b;
    b = temp;
    Console.WriteLine($"After swap: a = {a}, b = {b}");
  }
}
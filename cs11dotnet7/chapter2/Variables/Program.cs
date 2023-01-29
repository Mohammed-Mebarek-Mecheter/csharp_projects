﻿using System.Xml;


/*object height = 1.88; // storing a double in an object 
object name = "Amir"; // storing a string in an object
Console.WriteLine($"{name} is {height} metres tall.");
//int length1 = name.Length; // gives compile error!
int length2 = ((string)name).Length; // tell compiler it is a string
Console.WriteLine($"{name} has {length2} characters.");*/

/*var population = 67_000_000; // 67 million in UK
var weight = 1.88; // in kilograms
var price = 4.99M; // in pounds sterling
var fruit = "Apples"; // strings use double-quotes
var letter = 'Z'; // chars use single-quotes
var happy = true; // Booleans have value of true or false*/
// good use of var because it avoids the repeated type
// as shown in the more verbose second statement

/*var xml1 = new XmlDocument(); // C# 3 and later
XmlDocument xml2 = new XmlDocument(); // all C# versions
// bad use of var because we cannot tell the type, so we
// should use a specific type declaration as shown in
// the second statement
var file1 = File.CreateText("something1.txt"); 
StreamWriter file2 = File.CreateText("something2.txt");*/

Console.WriteLine($"default(int) = {default(int)}"); 
Console.WriteLine($"default(bool) = {default(bool)}"); 
Console.WriteLine($"default(DateTime) = {default(DateTime)}"); 
Console.WriteLine($"default(string) = {default(string)}");

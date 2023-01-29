var person = new { FirstName = "Alice", Age = 56 };
string json = $$"""
 {
 "first_name": "{{person.FirstName}}",
 "age": {{person.Age}},
 "calculation", "{{{ 1 + 2 }}}"
 }
 """;
Console.WriteLine(json);
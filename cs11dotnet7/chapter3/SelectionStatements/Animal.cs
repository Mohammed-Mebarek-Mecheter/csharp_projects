﻿namespace SelectionStatements;

public class Animal
{
    public string? Name;
    public DateTime Born;
    public byte Legs;
}
class Cat : Animal // This is a subtype of animal.
{
    public bool IsDomestic;
}
class Spider : Animal // This is another subtype of animal.
{
public bool IsPoisonous;
}


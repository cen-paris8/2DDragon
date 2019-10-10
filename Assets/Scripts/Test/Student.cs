using System;

public class Student : IComparable<Student>
{
    public string name;
    public int value;

    public Student(string newName, int newValue)
    {
        name = newName;
        value = newValue;
    }

    public int CompareTo(Student other)
    {
        if (other == null)
        {
            return 1;
        }
        return other.value - value;
    }
}
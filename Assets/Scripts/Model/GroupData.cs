using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GroupData
{
    public string Name;

    public DayOfWeek dayOfLesson;
    [Range(0,23)]
    public int hours = 8;
    [Range(0,59)]
    public int minutes = 30;
    public WeekType weekOfLesson;

    public List<StudentData> Students = new List<StudentData>();
}

public enum DayOfWeek
{
    Понедельник,
    Вторник,
    Среда,
    Четверг,
    Пятница,
    Суббота
}

public enum WeekType
{
    Чётная,
    Нечётная,
    Каждая
}

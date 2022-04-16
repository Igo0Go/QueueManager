using UnityEngine;

[System.Serializable]
public class LessonData
{
    public DayOfWeek dayOfLesson;
    [Range(0, 23)]
    public int hours = 8;
    [Range(0, 59)]
    public int minutes = 30;
    public WeekType weekOfLesson;
    public GroupData group;
    public string lessonPlace;
    [TextArea]
    public string lessonTip;
}


public enum DayOfWeek
{
    �����������,
    �������,
    �����,
    �������,
    �������,
    �������
}

public enum WeekType
{
    ׸����,
    ��������,
    ������
}

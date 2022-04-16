using System.Collections.Generic;

[System.Serializable]
public class GroupData
{
    public string Name;
    public List<StudentData> Students = new List<StudentData>();
}

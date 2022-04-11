using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "LessonDataPack")]
public class LessonsData : ScriptableObject
{
    public List<GroupData> lessons = new List<GroupData>();
}

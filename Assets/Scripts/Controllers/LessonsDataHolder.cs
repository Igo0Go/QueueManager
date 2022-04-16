using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "LessonDataPack")]
public class LessonsDataHolder : ScriptableObject
{
    public List<LessonData> lessons = new List<LessonData>();
}

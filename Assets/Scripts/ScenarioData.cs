using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class CustomDatas
{
    public Vector3 position;
    public Vector3 orientation;
}

[CreateAssetMenu(menuName = "New Sc�nario")]
public class ScenarioData : ScriptableObject
{
    public CustomDatas[] FirstWalls;

}

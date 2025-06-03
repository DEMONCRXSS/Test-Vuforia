using UnityEngine;

[CreateAssetMenu(fileName = "SounbData", menuName = "Scriptable Objects/SounbData")]
public class SoundData : ScriptableObject
{
    public string musicName;
    public string animationName;
    public TextAsset notesConfig;
    public float speed;
}
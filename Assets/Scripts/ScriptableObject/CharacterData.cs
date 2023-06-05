using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObject/CharacterData", order = 1)]
public class CharacterData : ScriptableObject
{
    public string Id;
    public string Name;
    public int Hp;
    public int Power;
    public float WalkSpeed;
    public float AttackSpeed;
}
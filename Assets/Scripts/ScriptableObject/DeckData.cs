using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObject/DeckData", order = 2)]
public class DeckData : ScriptableObject
{
    public string[] CharacterDataIds;
}
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName="so_ItemList", menuName="Scriptable Objects/ItemDetails/ItemDetails List")]

public class SO_ItemList : ScriptableObject
{
    [SerializeField]
    public List<ItemDetails> itemDetails;
}

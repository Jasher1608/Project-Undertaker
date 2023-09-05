using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Misc Object", menuName = "Items/Misc")]
public class MiscObject : ItemObject
{
    public void Awake()
    {
        type = ItemType.Misc;
    }
}

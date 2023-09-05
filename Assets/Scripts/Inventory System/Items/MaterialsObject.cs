using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Materials Object", menuName = "Items/Materials")]
public class MaterialsObject : ItemObject
{
    public void Awake()
    {
        type = ItemType.Materials;
    }
}

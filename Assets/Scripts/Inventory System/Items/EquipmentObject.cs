using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Equipment Object", menuName = "Items/Equipment")]
public class EquipmentObject : ItemObject
{
    public void Awake()
    {
        type = ItemType.Equipment;
    }
}

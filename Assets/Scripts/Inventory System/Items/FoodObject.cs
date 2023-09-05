using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Food Object", menuName = "Items/Food")]
public class FoodObject : ItemObject
{
    public int restoreEnergyValue;
    public void Awake()
    {
        type = ItemType.Food;
    }
}

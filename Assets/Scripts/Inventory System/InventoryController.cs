using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryController : MonoBehaviour
{
    public InventoryObject inventory;
    
    private void OnApplicationQuit()
    {
        inventory.Container.Clear();
    }
}

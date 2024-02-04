using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonInventory : MonoBehaviour
{
	public GameObject inventoryGO; 
	public bool isActive = false;

    public void ChangeInventory()
    {
        inventoryGO.gameObject.SetActive(!isActive);
        isActive = !isActive;
    }
}

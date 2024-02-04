using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
	public bool[] isFull;
	public GameObject[] slots;

	public GameObject slotIcon;
	public int endSlotNumber = 9;

	public GameObject focusSlot; 
	public int focusID;

	public void GiveItem(GameObject item1){
		if(isFull[endSlotNumber-1]){
					GameObject child = slots[endSlotNumber].transform.GetChild(0).gameObject;
					Destroy(child);
					Instantiate(item1, slots[endSlotNumber].transform);
					isFull[endSlotNumber] = true;
		}
		else{
			for(int i = 0 ; i < slots.Length; i++){
				if(isFull[i] == false){
					GameObject child = slots[i].transform.GetChild(0).gameObject;
					Destroy(child);
					Instantiate(item1, slots[i].transform);
					isFull[i] = true;
					break;
				}
			}
		}
	}

	public void PointerOnMe(GameObject go, int ID){
		focusSlot = go;
		focusID = ID;
	}

	public void SwapChildWithFocus(GameObject go, int ID){
		GameObject childGO = go.transform.GetChild(0).gameObject;
		GameObject childFocus = focusSlot.transform.GetChild(0).gameObject;

		childGO.transform.SetParent(focusSlot.transform);
		childFocus.transform.SetParent(go.transform);

		childGO.transform.position = focusSlot.transform.position;
		childFocus.transform.position = go.transform.position;

		bool buf = isFull[focusID];
		isFull[focusID] = isFull[ID];
		isFull[ID] = buf;
	}

	public void DeleteItem(GameObject item, int ID){
		Destroy(item);
		Instantiate(slotIcon, slots[ID].transform);
		isFull[ID] = false;
	}

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}

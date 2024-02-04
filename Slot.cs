using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class Slot : MonoBehaviour, IPointerClickHandler, IDragHandler, IBeginDragHandler, IEndDragHandler, IPointerEnterHandler, IPointerExitHandler
{
    public int myID;

	private float firstClickTime = 0f;
	private float timeBetweenClick = 0.5f;
	private bool isTimeCheckAllowed = true;
	private int clickNum = 0;

    private GameObject canvas;
	public GameObject inventoryGO;
    private Inventory inventoryScript;

    private bool _IsClicked;

	GameObject child;

    void Start()
    {
        canvas = GameObject.Find("Canvas");
        inventoryScript = inventoryGO.GetComponent<Inventory>();
    }

    void Update(){
    }

    public void OnPointerEnter(PointerEventData eventData){
        inventoryScript.PointerOnMe(gameObject, myID);
    }

    public void OnPointerExit(PointerEventData eventData){
        inventoryScript.PointerOnMe(null, 0);
    }

    public void OnPointerClick(PointerEventData eventData){               
        child = gameObject.transform.GetChild(0).gameObject; 
        if(child.name != "SlotIcon" && child.name != "SlotIcon(Clone)"){
            clickNum += 1;    

            if(clickNum == 1 && isTimeCheckAllowed){
                firstClickTime = Time.time;
                StartCoroutine(DetectDoubleClick());
            }   
        }
    }

    public void OnDrag(PointerEventData eventData)
    {
        child.transform.position = eventData.pointerCurrentRaycast.screenPosition;
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        child = gameObject.transform.GetChild(0).gameObject; 
        //child.transform.parent = canvas.transform;
        child.transform.SetParent(canvas.transform);
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        child.transform.SetParent(gameObject.transform);
        if(inventoryScript.focusSlot == null || inventoryScript.focusSlot == gameObject){
    //        child.transform.parent = gameObject.transform;
            child.transform.position = gameObject.transform.position;
        }else{
      //      Debug.Log(gameObject);
       //     Debug.Log(gameObject.transform.GetChild(0).gameObject);

        //    Debug.Log(inventoryScript.focusSlot);
        //    Debug.Log(inventoryScript.focusSlot.transform.GetChild(0).gameObject);
            inventoryScript.SwapChildWithFocus(gameObject, myID);
        }
    }

    private IEnumerator DetectDoubleClick(){
    	isTimeCheckAllowed = false;
    	while(Time.time < firstClickTime + timeBetweenClick){
    		if(clickNum == 2){
                child = gameObject.transform.GetChild(0).gameObject;
    			Debug.Log("DoubleCLickDetected/child: " + child);
    			inventoryScript.DeleteItem(child, myID);
    			break;
    		}
    		yield return new WaitForEndOfFrame();
    	}
    	clickNum = 0;
    	isTimeCheckAllowed = true;
    }
}

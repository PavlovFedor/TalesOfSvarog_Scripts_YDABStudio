using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.UI.Image;
using TMPro;
using System;
using System.Threading;

public class Chat : MonoBehaviour
{
	public int maxMessages = 25;

	public GameObject chatPanel, textObject;
    public Transform parentObject;

    public GameObject inventoryGO;
    private Inventory inventoryScript;

    public GameObject ImageGo;
    private Image image;

    public GameObject testItem1, testItem2;

	public Color playerMessage, info, red, yellow, green, blue, purple, white, grey, pink, gold;

    public Sprite[] spriteScript;

    [SerializeField]
	List<Message> messageList = new List<Message>();

    void Start(){
        image = ImageGo.GetComponent<Image>();
        inventoryScript = inventoryGO.GetComponent<Inventory>();
    }

    void Update(){
    }

    public void changeImage(int imageID){
        image.sprite = spriteScript[imageID];
    }

    public void SendMessageToChat(int imageID, string text, Message.MessageType messageType)
    {     
    	if(messageList.Count >= maxMessages){
    		Destroy(messageList[0].textObject.gameObject);
    		messageList.Remove(messageList[0]);
    	}
        Message newMessage = new Message();

        newMessage.text = "\n";
        newMessage.text += text;

        Vector3 spawnPos = transform.position;  //spawn object Message
        spawnPos = chatPanel.transform.position;
        GameObject newText;

        if(imageID != -1)
            changeImage(imageID);

        newText = Instantiate(textObject, parentObject);

        newMessage.textObject = newText.GetComponent<TMP_Text>();

        newMessage.textObject.text = newMessage.text;
        newMessage.textObject.color = MessageTypeColor(messageType);

        messageList.Add(newMessage);  
    }

    Color MessageTypeColor(Message.MessageType messageType){
        Color color = info;

        switch(messageType){
            case Message.MessageType.playerMessage:
                color = playerMessage;
                break;
            case Message.MessageType.red:
                color = red;
                break;
            case Message.MessageType.yellow:
                color = yellow;
                break;
            case Message.MessageType.green:
                color = green;
                break;
            case Message.MessageType.blue:
                color = blue;
                break;
            case Message.MessageType.purple:
                color = purple;
                break;
            case Message.MessageType.white:
                color = white;
                break;
            case Message.MessageType.grey:
                color = grey;
                break;
            case Message.MessageType.pink:
                color = pink;
                break;
            case Message.MessageType.gold:
                color = gold;
                break;
        }

        return color;
    }
}

[System.Serializable]
public class Message
{
	public string text;
	public TMP_Text textObject;
    public MessageType messageType;

    public enum MessageType{
        playerMessage,
        info,
        red,
        yellow,
        green,
        blue,
        purple,
        white,
        grey,
        pink,
        gold
    }
}
	
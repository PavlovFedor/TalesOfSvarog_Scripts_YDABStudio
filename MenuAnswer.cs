using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class MenuAnswer : MonoBehaviour
{
	public GameObject gmGO;
    private GameManager gmScript;

	public TMP_Text ans1;
	public TMP_Text ans2;

	public string[] text1;
	public string[] text2;

	public int phase = 0;

    void Start()
    {        
        gmScript = gmGO.GetComponent<GameManager>();
    }

	public void ActivatePhase(){
		ans1.text = text1[phase];
		ans2.text = text2[phase];

		phase++;
	}

	public void SetOne(){
		gmScript.EndMenuAnswer(phase, true);
	}

	public void SetTwo(){
		gmScript.EndMenuAnswer(phase, false);
	}

    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        
    }
}

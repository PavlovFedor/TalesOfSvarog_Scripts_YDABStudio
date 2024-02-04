using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;

public class ScrollbarScript : MonoBehaviour
{
	ScrollRect _scrollRect;
    void Start()
    {
       _scrollRect = GetComponent<ScrollRect>();
    }

    void Update()
    {
        _scrollRect.normalizedPosition = new Vector2(_scrollRect.normalizedPosition.x, 0);
    }
}

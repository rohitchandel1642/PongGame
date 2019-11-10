﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class pointer2 : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public paddlecontrol paddles;
    public int prev;
    void Start()
    {
        prev = SceneManager.GetActiveScene().buildIndex - 1;

    }
    bool pointerDown = false;

    public void OnPointerDown(PointerEventData eventData)
    {
        pointerDown = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        pointerDown = false;
    }

    void Update()
    {
        if (pointerDown)
        {
            paddles.transform.position = new Vector3(paddles.transform.position.x, paddles.transform.position.y - (paddles.speed * 2 * Time.deltaTime), paddles.transform.position.z);
            paddles.direction = -1;//Your Code
        }
    }
    //Detect current clicks on the GameObject (the one with the script attached)
}
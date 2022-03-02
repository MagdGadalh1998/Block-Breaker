using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddle : MonoBehaviour
{
    float minX = -13.475f;
    float MaxX = 13.475f;
    public bool autoPlay = false;
    BallHit ball;
    private void Start()
    {
        ball = GameObject.FindObjectOfType<BallHit>();
    }
    void Update()
    {
        if (!autoPlay)
        { 
        moveWithMouse();
        }
        else
        {
            AutoPlay();
        }
    }

    private void AutoPlay()
    {
        Vector3 paddlePos = new Vector3(2f, transform.position.y, 0);
        Vector3 ballPos = ball.transform.position;
        paddlePos.x = Mathf.Clamp(ballPos.x, minX, MaxX);
        this.transform.position = paddlePos;
    }

    public void moveWithMouse()
    {
        Vector3 paddlePos = new Vector3(2f, transform.position.y, 0);
        float mousePosInBlocks = Input.mousePosition.x / Screen.width * 20;
        paddlePos.x = Mathf.Clamp(mousePosInBlocks, minX, MaxX);
        this.transform.position = paddlePos;
    }
}

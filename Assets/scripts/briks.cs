using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class briks : MonoBehaviour
{
    private int TimeHits;
    public AudioClip crack;
    public static int breakableCount = 0;
    private lavelManger levelMange;
    private bool isBreakable;
    public Sprite[] hitSprites;
    // Start is called before the first frame update
    void Start()
    {
       isBreakable = (this.tag == "breakable");
        if (isBreakable)
        {
            breakableCount++;
        }
        TimeHits = 0;
        levelMange = GameObject.FindObjectOfType<lavelManger>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        AudioSource.PlayClipAtPoint(crack, transform.position,0.8f);
        if (isBreakable)
        { 
        HandleHits();
        }
    }
    void HandleHits()
    {
        TimeHits++;
        int MaxHits = hitSprites.Length + 1;
        if (TimeHits >= MaxHits)
        {
            breakableCount--;
            print(breakableCount);  
            levelMange.BrickDestroyed();
            Destroy(gameObject);
        }
        else
        {
            loadSprite();
        }
    }
    private void loadSprite()
    {
        int spriteIndex = TimeHits - 1;
        if (hitSprites[spriteIndex] != null)
        {
            this.GetComponent<SpriteRenderer>().sprite = hitSprites[spriteIndex];
        }
        else
        {
            Debug.LogError("Bricks Sprite Missing");
        }
    }

    void SimulateWin()
    {
        levelMange.LoadNextLevel();
    }
}

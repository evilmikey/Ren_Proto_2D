using System;
using UnityEngine;

public class Conect : MonoBehaviour
{   
    public Drag drag;
    public SpriteRenderer sr;
    private PuzzleCounter pCounter;
  
    private void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        pCounter = FindAnyObjectByType<PuzzleCounter>();
    }

    public void Drop(Drag dropped)
    {
        if (drag == dropped)
        {
            Destroy(dropped.gameObject);
            sr.enabled = true;
            pCounter.Increment();
        }
    }
    
}

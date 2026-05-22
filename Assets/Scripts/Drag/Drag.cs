using System;
using UnityEngine;

public class Drag : MonoBehaviour
{
    public bool dragging = false;
    public Vector3 offset;
    
    
    // Update is called once per frame
    void Update()
    {
        if (dragging)
        {
            transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition) +  offset;
        }
    }

    private void OnMouseDown()
    {
        offset = transform.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);
        dragging = true;
    }

    private void OnMouseUp()
    {
        dragging = false;  
        
        // check with physics if we can connect
        Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, 0.1f);
        foreach (Collider2D col in colliders)
        {
            Conect conect = col.GetComponent<Conect>();
            if (conect == null) continue; // not a connection point, so skip this colliders
            
            conect.Drop(this);
        }
    }
    
}

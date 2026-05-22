using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class PlayerMovement : MonoBehaviour
{
    
    public float moveSpeed = 5f;
    private Rigidbody2D rb;
    private Vector2 moveInput;
    private Animator anim;
    
    private int count;
    
    //UI text component to display the count of "PickUp" objects collected
    public TextMeshProUGUI countText;
    //UI object to display winning text
    public GameObject winTextObject;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        
        //Initialize count to zero
        count = 0;
        
        //Update the count display
        SetCountText();
        
        //Initally set the win text to be inactive
        winTextObject.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        rb.linearVelocity = moveInput * moveSpeed;
    }

    public void Move(InputAction.CallbackContext context)
    {
        anim.SetBool("IsWalking", true);

        if (context.canceled)
        {
            anim.SetBool("IsWalking", false);
            
            anim.SetFloat("LastInputX", moveInput.x);
            anim.SetFloat("LastInputY", moveInput.y);
        }
        
        moveInput = context.ReadValue<Vector2>();

        anim.SetFloat("InputX", moveInput.x);
        anim.SetFloat("InputY", moveInput.y);
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Item"))
        {
            count = count + 1;
            SetCountText();
        }
        
    }
    
    
    void SetCountText()
    {
        countText.text = count.ToString() + "/9 Collected";
        if (count >= 9)
        {
            winTextObject.SetActive(true);
        }
    }
    
}

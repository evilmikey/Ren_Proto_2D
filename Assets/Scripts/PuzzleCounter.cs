using UnityEngine;

public class PuzzleCounter : MonoBehaviour
{
    private int count = 0;

    public void Increment()
    {
        count++;

        if (count >= 9)
        {
            Debug.Log("Win");
        }
    }
    

}

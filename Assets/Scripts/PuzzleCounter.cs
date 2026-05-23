using UnityEngine;

public class PuzzleCounter : MonoBehaviour
{
    private int count = 0;
    public GameObject winScreen;
    public AudioSource audioPlayer;
    
    void Start()
    {
        winScreen.SetActive(false);
    }
    public void Increment()
    {
        count++;

        if (count >= 9)
        {
            Debug.Log("Win");
            winScreen.SetActive(true);
            audioPlayer.Play();
        }
    }
    

}

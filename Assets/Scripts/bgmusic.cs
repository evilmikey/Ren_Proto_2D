using UnityEngine;

public class bgmusic : MonoBehaviour
{
   public static bgmusic instance;

   public void Awake()
   {
      if (instance == null)
      {
         DontDestroyOnLoad(this.gameObject);
         instance = this;
      }
      else
      {
         Destroy(this.gameObject);
      }
   }
}

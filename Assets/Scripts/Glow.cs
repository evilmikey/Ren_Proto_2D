using UnityEngine;  
using System.Collections;
using TMPro;
using UnityEngine.EventSystems;  
using UnityEngine.UI;

public class Glow : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public TextMeshProUGUI buttonText;
    public void OnPointerEnter(PointerEventData eventData)
    {
        buttonText.color = new Color32(175, 27, 39, 255);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        buttonText.color = new Color32(254, 141, 40, 255);
    }
}

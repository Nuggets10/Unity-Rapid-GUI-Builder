using UnityEngine;
using UnityEngine.EventSystems;

public class UIToolTip : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [Header("Rapid GUI Builder")]
    public GameObject targetElement; // L'elemento UI da attivare/disattivare

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (targetElement != null)
            targetElement.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (targetElement != null)
            targetElement.SetActive(false);
    }
}

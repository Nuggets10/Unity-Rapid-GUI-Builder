using UnityEngine;
using UnityEngine.EventSystems;

public class UIResize : MonoBehaviour, IDragHandler
{
    [Header("Rapid GUI Builder")]
    public RectTransform RectTransform;
    private Vector2 originalSizeDelta;
    private Vector2 originalMousePosition;
    
    private void Start()
    {
        if (RectTransform == null)
        {
            RectTransform = GetComponent<RectTransform>();
        }
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        originalSizeDelta = RectTransform.sizeDelta;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(
            RectTransform, eventData.position, eventData.pressEventCamera, out originalMousePosition);
    }

    public void OnDrag(PointerEventData eventData)
    {
        Vector2 localMousePosition;
        if (RectTransformUtility.ScreenPointToLocalPointInRectangle(
                RectTransform, eventData.position, eventData.pressEventCamera, out localMousePosition))
        {
            Vector2 difference = localMousePosition - originalMousePosition;
            RectTransform.sizeDelta = originalSizeDelta + new Vector2(difference.x, difference.y);
        }
    }
}

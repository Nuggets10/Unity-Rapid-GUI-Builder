using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIClose : MonoBehaviour
{
    [Header("Rapid GUI Builder")]
    public List<GameObject> ElementsToDisable;
    public Button TriggerButton;

    private void Start()
    {
        if (TriggerButton != null)
        {
            TriggerButton.onClick.AddListener(DeActivateElements);
        }
    }

    private void DeActivateElements()
    {
        foreach (GameObject element in ElementsToDisable)
        {
            if (element != null)
            {
                element.SetActive(false);
            }
        }
    }
}

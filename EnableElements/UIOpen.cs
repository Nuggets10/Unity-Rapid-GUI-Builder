using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIOpen : MonoBehaviour
{
    [Header("Rapid GUI Builder")]
    public List<GameObject> ElementsToEnable;
    public Button TriggerButton;

    private void Start()
    {
        if (TriggerButton != null)
        {
            TriggerButton.onClick.AddListener(ActivateUIElements);
        }
    }

    private void ActivateUIElements()
    {
        foreach (GameObject element in ElementsToEnable)
        {
            if (element != null)
            {
                element.SetActive(true);
            }
        }
    }
}

using System.Collections.Generic;
using UnityEngine;

public class UIDisableTimer : MonoBehaviour
{
    [Header("Rapid GUI Builder")]
    public List<GameObject> ElementsToDisable;
    public float Timer;

    void OnEnable()
    {
        Invoke("DisableElements", Timer);
    }

    void OnDisable()
    {
        CancelInvoke("DisableElements");
    }

    void DisableElements()
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIKeyCodeToggle : MonoBehaviour
{
    [Header("Rapid GUI Builder")]
    public KeyCode KeyCode;
    public List<GameObject> ElementsToToggle;

    [Tooltip("Select if at start the gameobject is active or not")]
    public bool isActive;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode) && isActive==true)
        {
            foreach (GameObject element in ElementsToToggle)
            {
            if (element != null)
            {
                element.SetActive(false);
            }
            }
        }

        if (Input.GetKeyDown(KeyCode) && isActive==false)
        {
            foreach (GameObject element in ElementsToToggle)
            {
            if (element != null)
            {
                element.SetActive(true);
            }
            }
        }
    }
}

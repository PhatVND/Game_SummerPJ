using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseText : MonoBehaviour
{
    public GameObject logoText;
    // Start is called before the first frame update

    // Update is called once per frame
    public void OnMouseEnter()
    {
        logoText.SetActive(true);
    }

}

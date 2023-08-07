using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu : MonoBehaviour
{
    public GameObject panel;
    void Start()
    {
        panel.SetActive(true);
        Time.timeScale = 0;
    }
    
    public void onClick()
    {
        panel.SetActive(false);
        Time.timeScale = 1;
    }

}

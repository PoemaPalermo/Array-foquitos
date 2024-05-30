using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FoquitoScript : MonoBehaviour
{
    public GameObject[] colors;
    public int currentLightIndex =-1;
    public int luces;
    public int vueltaLuces;

    void Start()
    {
        luces = colors.Length;
        vueltaLuces = luces * 3;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ActivateNextLight()
    {
        currentLightIndex++;
        vueltaLuces--;
        if (currentLightIndex >= colors.Length)
        {
            currentLightIndex = 0;
        }
        if (vueltaLuces >= 0)
        {
            DeactivateAllLights();
            colors[currentLightIndex].SetActive(true);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
    public void ActivatePreviousLight()
    {
        currentLightIndex--;
        if (currentLightIndex < 0)
        {
            currentLightIndex = colors.Length - 1;
        }
        
    }
    void DeactivateAllLights()
    {
        for(int i = 0; i<colors.Length; i++)
        {
            colors[i].SetActive(false);
        }
    }
    public void ActivateRepeating(float t)
    {
        InvokeRepeating(nameof(ActivateNextLight), 0, t);
    }

 

}

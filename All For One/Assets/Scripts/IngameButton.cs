using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngameButton : MonoBehaviour
{
    public void Next()
    {
        GameManager.instance.disableUI = true;
    }
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

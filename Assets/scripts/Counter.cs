using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    public int i = 1;
    // Start is called before the first frame update
    void Start()
    {
        // get string from parent object
      //  childObject.transform.parent.gameObject.GetComponent<
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void changeColor()
    {
        if (i == 1) 
        { 
        // set color of this button to green
        this.GetComponent<Image>().color = Color.green;
        i = 0;
        }
        else
        {
        this.GetComponent<Image>().color = Color.white;
            i = 1;
        }
    }
}

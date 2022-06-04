using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class passatempo : MonoBehaviour
{
    public float mytime;
    public float velocity=0.9f;
    public bool myplaying=false;
    public Text mycounter;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (myplaying)
        {
           
            mytime += Time.deltaTime* velocity;
            mycounter.text = mytime.ToString("00.00");
    
        }
        if (mytime > 05.00f)
        {
           myplaying = false;
        }
    }
}

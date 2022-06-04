using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuickTime : MonoBehaviour
{
    public float mytime;
    public float velocity=0.9f;
     float oldmytime;
    public bool myplaying=false;
    public Text mycounter;
    public int[] Sequencia;
    int index = 0;
    public int sucesso;
    public Text[] texts;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (myplaying)
        {
            if (index > Sequencia.Length)
            {
                myplaying = false;
            }
            mytime += Time.deltaTime* velocity;
            mycounter.text = mytime.ToString("00.00");
            if (mytime >= oldmytime + 1)
            {
                oldmytime = mytime;
                index++;
                EventSequence();
            }
            for(int i = 0; i < texts.Length; i++)
            {
                
                texts[i].transform.localPosition = new Vector3(0,(((1+i) * 100 + mytime*100)%300)*2, 0);
                texts[i].text = Sequencia[index + i].ToString();
            }
            

        }
    }

    void EventSequence()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            if (Sequencia[index] == 0)
            {
                sucesso++;
            }
        }
        if (Input.GetKey(KeyCode.W))
        {
            if (Sequencia[index] == 1)
            {
                sucesso++;
            }
        }
        if (Input.GetKey(KeyCode.E))
        {
            if (Sequencia[index] == 2)
            {
                sucesso++;
            }
        }
        if (Input.GetKey(KeyCode.R))
        {
            if (Sequencia[index] == 3)
            {
                sucesso++;
            }
        }
    }


    public void StartCounter()
    {
        myplaying = true;
    }
    public void StopCounter()
    {
        myplaying = false;
    }
}

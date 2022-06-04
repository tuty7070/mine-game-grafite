using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger : MonoBehaviour
{
    public GameObject coisa;
    public bool criador;
    void Start()
    {

    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (criador)
            {
                GameObject estacoisa = Instantiate(coisa);
                estacoisa.SetActive(true);
                
            }
            else
            {
                coisa.SetActive(true);
            }
        }
    }
}
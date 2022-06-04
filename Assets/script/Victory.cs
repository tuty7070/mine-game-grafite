using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Victory : MonoBehaviour
{
    public List<GameObject> objetos;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Check", 0, 1);
    }

    void Check(){
        if (objetos.TrueForAll(isActiveAndEnabled => true))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("Defeat");
        }
    }
  
}

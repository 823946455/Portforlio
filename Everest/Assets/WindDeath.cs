using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WindDeath : MonoBehaviour
{
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("r")){
            SceneManager.LoadScene("Everest1");
        }
        if (Input.GetKeyDown("m")){
            SceneManager.LoadScene("EverestMenu");
        }
    }
}
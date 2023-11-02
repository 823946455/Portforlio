using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class OxygenBottles : MonoBehaviour
{
     [Header("Inscribed")]
    public float oxygenBottles=5;
    private TextMeshProUGUI gt;
    // Start is called before the first frame update
    void Start()
    {
        gt=GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("a") && oxygenBottles>0){
            oxygenBottles=oxygenBottles-1;
            //Debug.Log("a key was pressed");
        }
        gt.text=oxygenBottles.ToString("#,0");
    }
}

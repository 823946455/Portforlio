using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Oxygen : MonoBehaviour
{
    [Header("Inscribed")]
    public float oxygen=100;
    public float oxygenDropDelay=2.0f;
    public float bottles=5;
    private TextMeshProUGUI gt;
    // Start is called before the first frame update
    // Update is called once per frame
    void Start(){
        gt=GetComponent<TextMeshProUGUI>();
        Invoke("OxygenDrop", oxygenDropDelay);
    }
    void OxygenDrop(){
         if (oxygen>0){
            oxygen=(oxygen-1);
            Invoke("OxygenDrop", oxygenDropDelay);
        }
        /*else{
            Debug.Log("You Died"); FIXME
        }*/
    }
    void Update()
    {
        if(Input.GetKeyDown("a") && bottles>0){
            oxygen=100;
            bottles=bottles-1;
        }
        gt.text=oxygen.ToString("#,0");
    }
}

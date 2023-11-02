using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HotWaterCounter : MonoBehaviour
{
    [Header("Inscribed")]
    public float hotWaterBottles=5;
    private TextMeshProUGUI gt;
    // Start is called before the first frame update
    void Start()
    {
        gt=GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("d") && hotWaterBottles>0){
            hotWaterBottles=hotWaterBottles-1;
            //Debug.Log("a key was pressed");
        }
        gt.text=hotWaterBottles.ToString("#,0");
    }
}

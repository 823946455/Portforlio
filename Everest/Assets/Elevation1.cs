using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Elevation1 : MonoBehaviour
{
    [Header("Dynamic")]
    public float elevation=0.0f;
    private TextMeshProUGUI gt;
    // Start is called before the first frame update
    void Start()
    {
        gt=GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!Input.GetKey("s")){
        elevation=elevation+(22.7f*Time.deltaTime);
        }
        gt.text=elevation.ToString("#,0");
    }
}

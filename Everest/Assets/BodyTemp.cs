using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class BodyTemp : MonoBehaviour
{
    [Header("Inscribed")]
    public float bodyTemp=98.6f;
    public float tempDropDelay=2.0f;
    public float bottles=5;
    private TextMeshProUGUI gt;
    // Start is called before the first frame update
    void Start()
    {
        gt=GetComponent<TextMeshProUGUI>();
        Invoke("DropTemp", tempDropDelay);
    }
    void DropTemp(){
        if (bodyTemp>95){
            bodyTemp=bodyTemp-0.1f;
            Invoke("DropTemp", tempDropDelay);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("d") && bottles>0){
            bodyTemp=98.6f;
            bottles=bottles-1;
        }
        gt.text=bodyTemp.ToString("#.#");
    }
}

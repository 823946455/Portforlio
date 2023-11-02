using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mountaineer : MonoBehaviour
{
    [Header("Inscribed")]
    public float speed=1f;
    public WindSpeed windRate;
    public float failSpeed=20f;
    [Tooltip("Check the box to become invincible")]
    public bool invincible=false;
    
    // Start is called before the first frame update
    void Start()
    {
       GameObject windGo=GameObject.Find("WindSpeed");
       windRate=windGo.GetComponent<WindSpeed>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos=transform.position; //b
        if (!Input.GetKey("s")){
            if(windRate.windSpeed==windRate.windSpeedThree && !invincible){//die if windspeed is the strongest
                pos.x+=speed*Time.deltaTime*failSpeed;
                transform.position=pos;
            }
            else {
            pos.y+=speed*Time.deltaTime; //c
            pos.x+=(-speed)*Time.deltaTime;
            transform.position=pos; //d
            }
        }
    }
}

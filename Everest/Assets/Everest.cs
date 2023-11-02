using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Everest : MonoBehaviour
{
    [Header("Inscribed")]
    public float speed=1f;
    public WindSpeed windRate;
    public Oxygen oxygenPercent;
    public BodyTemp bodyTemperature;
    // Start is called before the first frame update
    [Tooltip("Check this box to become invincible")]
    public bool invincible=false;
    void Start()
    {
        if (invincible){
            Debug.Log("You are invincible");
        }
        GameObject windGo=GameObject.Find("WindSpeed");
        windRate=windGo.GetComponent<WindSpeed>();
        GameObject oxygenGo=GameObject.Find("OxygenCounter");
        oxygenPercent=oxygenGo.GetComponent<Oxygen>();
        GameObject tempGo=GameObject.Find("BodyTemp");
        bodyTemperature=tempGo.GetComponent<BodyTemp>();
    }
    void WindDeath(){
        SceneManager.LoadScene("WindDeathScreen");
    }
    void OxygenDeath(){
        SceneManager.LoadScene("OxygenDeprivation");
    }
    void Hypothermia(){
        SceneManager.LoadScene("Hypothermia");
    }
    // Update is called once per frame
    void Update()
    {
        
        Vector3 pos=transform.position; //b
        if (oxygenPercent.oxygen==0 && !invincible){
                //Debug.Log("You Died");
            Invoke("OxygenDeath", 1);
            }
        if (bodyTemperature.bodyTemp<95 && !invincible){
                //Debug.Log("You died");
            Invoke("Hypothermia", 1);
            }
        if (!Input.GetKey("s")){
            if (windRate.windSpeed==windRate.windSpeedThree && !invincible){
                //Debug.Log("You died");
                Invoke("WindDeath", 1f);
            }
            else{
            pos.y+=speed*Time.deltaTime; //c
            pos.x+=(-speed)*Time.deltaTime;
            transform.position=pos; //d
            }
        }
        if (pos.y>146){
            SceneManager.LoadScene("BaseCampAlpha");
        }
    }
}


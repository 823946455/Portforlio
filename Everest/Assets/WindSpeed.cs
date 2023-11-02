using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WindSpeed : MonoBehaviour
{
    [Header("Inscribed")]
    public float windSpeed=5;
    public float windSpeedOne=5;
    public float windSpeedTwo=10;
    public float windSpeedThree=20;
    public float windChangeDelay=10.0f;
    public float changeWindChance=0.5f;
    private TextMeshProUGUI gt;
    // Start is called before the first frame update
    void Start()
    {
        gt=GetComponent<TextMeshProUGUI>();
        //FindObjectOfType<AudioManager>().Play("WindSafe");
        Invoke("SafeSpeed", windChangeDelay);
    }
    void SafeSpeed(){
        windSpeed=windSpeedOne; //set to 20 for debugging, set to 5 for normal gameplay
        if (Random.value<changeWindChance){
            FindObjectOfType<AudioManager>().Play("WindSafe");
            Invoke("UnsafeSpeed", windChangeDelay);
        }
        else if(Random.value>changeWindChance){
            FindObjectOfType<AudioManager>().Play("WindSafe");
            Invoke("SafeSpeed", windChangeDelay);
        }
        else {
            FindObjectOfType<AudioManager>().Play("WindDangerous");
            Invoke("DangerousSpeed", windChangeDelay);
        }
    }
    void UnsafeSpeed(){
        windSpeed=windSpeedTwo;
        if(Random.value<changeWindChance){
            FindObjectOfType<AudioManager>().Play("WindDangerous");
            Invoke("DangerousSpeed", windChangeDelay);
        }
        else if(Random.value>changeWindChance){
            FindObjectOfType<AudioManager>().Play("WindSafe");
            Invoke("UnsafeSpeed", windChangeDelay);
        }
        else {
            FindObjectOfType<AudioManager>().Play("WindSafe");
            Invoke("SafeSpeed", windChangeDelay);
        }

    }
    void DangerousSpeed(){
        windSpeed=windSpeedThree;
        if (Random.value<changeWindChance){
            FindObjectOfType<AudioManager>().Play("WindSafe");
            Invoke("SafeSpeed", windChangeDelay);
        }
         else if (Random.value>changeWindChance){
            FindObjectOfType<AudioManager>().Play("WindSafe");
            Invoke("UnsafeSpeed", windChangeDelay);
        }
        else {
            FindObjectOfType<AudioManager>().Play("WindDangerous");
            Invoke("DangerousSpeed", windChangeDelay);
        }
    }
    // Update is called once per frame
    void Update()
    {
        gt.text=windSpeed.ToString("#");
    }
}

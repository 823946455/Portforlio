using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rightHip : MonoBehaviour
{
    [Header("Inscribed")]
    // Start is called before the first frame update
    public float rotationSpeed=20f;
    public float rotationAngle=45f;
    public Vector3 rotationDirection=new Vector3();
    // Update is called once per frame
    void Start(){
        Invoke("ChangeDirectionOne", 0); //starts the process of changing direction
    }
    void ChangeDirectionOne(){//change direction
        rotationAngle=rotationAngle-1f;
        if (rotationAngle<0){
            rotationDirection.x*=-1;
            Invoke("ChangeDirectionTwo", 0);
        }
        else {
            Invoke("ChangeDirectionOne", 0.075f);
        }
    }
    void ChangeDirectionTwo(){//change direction
        rotationAngle=rotationAngle+1f;
        if (rotationAngle>45){
            rotationDirection.x*=-1;
            Invoke("ChangeDirectionOne", 0);
        }
        else {
            Invoke("ChangeDirectionTwo", 0.075f);
        }
    }
    void Update()
    {
        //makes the object rotate
        if (!Input.GetKey("s")){
        transform.Rotate(rotationSpeed*rotationDirection*Time.deltaTime);
        }
    }
}
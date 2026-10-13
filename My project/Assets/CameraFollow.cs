using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
     public  Transform Target;
    public float Cameraspeed;

    public float minX,maxX;
    public float minY,maxY; 
    
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
           if(Target!=null)
       {
        Vector2 newCamPosition= Vector2.Lerp(transform.position,Target.position,Time.deltaTime*Cameraspeed);
        float clampedX= Mathf.Clamp(newCamPosition.x,minX,maxX);
        float clampedY= Mathf.Clamp(newCamPosition.y,minY,maxY);
        transform.position= new Vector3(clampedX,clampedY,-10f);
       }  
    }


}

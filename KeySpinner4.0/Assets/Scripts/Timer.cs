using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    public Text timerText;
    private float startTime;

   Rigidbody2D rb;

   public GameObject KEY;

     public Quaternion rotationStored;
     public Quaternion currentRotation;
 
     public float maxErrorAllowedPerFrame;
 
     public bool rotacija;

      private int interval = 300;



    void Start()
    {
        startTime = Time.time;

         rotationStored = transform.rotation;
         currentRotation = transform.rotation;

       

    }

    



    // Update is called once per frame
    void Update()
    {

        currentRotation = transform.rotation;

                 if (Mathf.Abs (Quaternion.Angle (rotationStored, transform.rotation)) < maxErrorAllowedPerFrame || currentRotation == rotationStored) {
             
             rotacija = false;
 
         } else {
             
             rotacija = true;
 
         }
 
         rotationStored = transform.rotation;

            if (rotacija) {
 
        float t = Time.time - startTime;

        timerText.color = Color.white;

        string minutes = ((int) t / 60).ToString();
        string seconds = (t % 60).ToString("f2");

        timerText.text = minutes + ":" + seconds; 
        }

           if (Time.frameCount % interval == 0)
     {

         if(rotacija == false){
             timerText.color = Color.red;
         }
         
     }

         

}
       



       
    
    
    

   
}

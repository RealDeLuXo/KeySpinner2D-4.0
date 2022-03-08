using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FukniGaVluft : MonoBehaviour
{

    
    Animation anim;
   
   public GameObject KEY;
   public AnimationClip KeyRePoLufte;

    // Start is called before the first frame update
    void Start()
    {
         anim = GameObject.Find("KEY").GetComponent<Animation>();

         
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0)) { 

            anim.clip = KeyRePoLufte;
            anim.Play("KeyRePoLufte");
            

            

        }
        
    }
}

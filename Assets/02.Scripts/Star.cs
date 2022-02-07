using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (int a = 0; a <= 5; a++)
        {
            string star = "";
            for (int b = 0; b<=a; b++)
            {
                star += "¡Ú"; 
            }
              
            for (int c = 0;  c + a  < 4; c++)
            {
                star += "¡Ù";
            }
            Debug.Log(star);
               


        }
    }               

    // Update is called once per frame
    void Update()
    {
        
    }
}

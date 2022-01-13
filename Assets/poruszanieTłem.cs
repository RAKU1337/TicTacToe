using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class poruszanieTłem : MonoBehaviour
{

    Vector3 direction = new Vector3(-1, 0, 0);



    // Update is called once per frame
    void Update()
    {
        // deltaTime - ile trwa pojedyncza klatka
        // Translate - przemieszcza obiekt
        Debug.Log(Time.deltaTime);
        transform.position += direction * Time.deltaTime;

         if (transform.position.x < -1.44)
         transform.position = new Vector3(0, 0, 0);
    }
}

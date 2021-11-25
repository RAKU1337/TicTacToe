using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class przeszkoda : MonoBehaviour
{
    public float speed = 1f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // deltaTime - ile trwa pojedyncza klatka
        // Translate - przemieszcza obiekt
        transform.Translate(new Vector3(-speed*Time.deltaTime,0,0));
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flashlightScript : MonoBehaviour {

    public Light lightSource;
    public bool on = true;
    
    // Start is called before the first frame update
    void Start()
    {
        on = true;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F)) {
            if (on == true)
            {
                lightSource.enabled = false;
                on = false;

            }
            else if (on == false)
            {
                lightSource.enabled = true;
                on = true;
            }

        }
        
        
    }
}

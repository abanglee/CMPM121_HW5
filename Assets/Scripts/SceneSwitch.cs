using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneSwitch : MonoBehaviour
{
    public void LoadLevel(string name) {
        Application.LoadLevel(name);
    }
   
}

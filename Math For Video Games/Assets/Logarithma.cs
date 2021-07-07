using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Logarithma : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Mathf.Log(32));       // base on e
        Debug.Log(Mathf.Log(32, 2));    // base on whatever you want
    }

}

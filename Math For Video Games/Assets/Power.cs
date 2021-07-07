using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Power : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Mathf.Pow(2, 2));
        Debug.Log(Mathf.Pow(2, 3));

        Debug.Log(Mathf.Pow(4, 0.5f));
        Debug.Log(Mathf.Ceil(Mathf.Pow(8, 0.33f)));
        Debug.Log(Mathf.Sqrt(4));
    }

    // Update is called once per frame
    void Update()
    {

    }
}

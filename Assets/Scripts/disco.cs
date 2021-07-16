using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disco : MonoBehaviour
{
    public GameObject discofloor;
    public Material Material1;
    // Start is called before the first frame update
    void Start()
    {
        discofloor.GetComponent<MeshRenderer>().material = Material1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class RandomMat : MonoBehaviour
{
    public Material[] randomMaterials;

    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Renderer>().material = randomMaterials[Random.Range(0,5)];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

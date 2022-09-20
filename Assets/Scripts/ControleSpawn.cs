using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleSpawn : MonoBehaviour
{

    [SerializeField] Transform[] point;
    [SerializeField] GameObject inimigo;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("InimigosSpawn", 0.5f, 2.0f);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void InimigosSpawn(){
        Instantiate(inimigo, point[0].position, point[0].rotation);

    }
}

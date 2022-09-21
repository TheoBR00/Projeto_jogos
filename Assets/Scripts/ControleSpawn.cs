using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleSpawn : MonoBehaviour
{

    [SerializeField] Transform[] point;
    [SerializeField] GameObject inimigo;
    int rep = 0;
    int rep_2 = 0;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("InimigosSpawn", 0.5f, 1.5f);
            
        
        
        
    }

    // Update is called once per frame
    void Update()
    {

        if(rep_2 > 0){
            InvokeRepeating("InimigosSpawn", 0.5f, 1.0f);
            rep_2++;
        }
    }

    void InimigosSpawn(){
        if(rep < 10){
            Instantiate(inimigo, point[0].position, point[0].rotation);
            rep++;
            if(rep == 10){
                rep_2++;
            }
        }
        

    }

    
}

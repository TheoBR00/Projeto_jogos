using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleSpawn : MonoBehaviour
{

    [SerializeField] Transform[] point;
    [SerializeField] GameObject inimigo;
    int limit = 10;
    bool spawn = true;
    // Start is called before the first frame update
    void Start()
    {
        //InvokeRepeating("InimigosSpawn", 0.5f, 1.5f);
        StartCoroutine("InimigosSpawn");
        
        
        
    }

    // Update is called once per frame
    void Update()
    {
        

    }

    IEnumerator InimigosSpawn(){

        while(spawn){
        
            yield return new WaitForSeconds(2.0f);

            for(int num = 0; num < limit; num++){
                int indice = Random.Range(0, point.Length);
                Instantiate(inimigo, point[indice].position, Quaternion.identity);
                yield return new WaitForSeconds(1.5f);
            }
            yield return new WaitForSeconds(10.0f);

            limit += 5;
        }

        

        //if(rep < 10){
        //    Instantiate(inimigo, point[0].position, point[0].rotation);
        //    rep++;

            
        //}
        

    }

    
}

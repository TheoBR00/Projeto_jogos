using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleInimigo : MonoBehaviour
{
    [SerializeField] float vel;
    GameObject jogador;
    Animator an;
    bool vivo = true;

    // Start is called before the first frame update
    void Start()
    {
        jogador = GameObject.FindGameObjectWithTag("Player");

        an = GetComponentInChildren<Animator>();

        
    }

    // Update is called once per frame
    void Update()
    {
        if(jogador != null && vivo){
            transform.position = Vector2.MoveTowards(transform.position, jogador.transform.position, vel * Time.deltaTime);
        }
        
    }

    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.CompareTag("Bala")){
            an.SetTrigger("Morto");
            vivo = false;

            Destroy(gameObject, 0.8f);
        }
    }

}

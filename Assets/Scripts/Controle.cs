using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;

public class Controle : MonoBehaviour
{
    [SerializeField] float vel;
    Vector2 mover;
    Animator an;

    float vida = 3;

    float vidaMax = 3;

    Image BarraVida;

    // Start is called before the first frame update
    void Start()
    {
        an = GetComponentInChildren<Animator>();
        BarraVida = GetComponentInChildren<Image>();
        
    }

    // Update is called once per frame
    void Update()
    {
        mover.x = Input.GetAxis("Horizontal");
        mover.y = Input.GetAxis("Vertical");

        transform.Translate(mover * Time.deltaTime * vel);

        an.SetBool("isMove", (Mathf.Abs(mover.x) > 0 || Mathf.Abs(mover.y) > 0));
        
    }

    private void OnCollisionEnter2D(Collision2D collision){

        if(collision.gameObject.CompareTag("Inimigo")){
            vida-=1;

            BarraVida.fillAmount = vida/vidaMax;

            if(vida == 0){
                an.SetBool("isDead", true);
                //Thread.Sleep(4000);
                Destroy(gameObject, 2.0f);
            }
        }
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleArma : MonoBehaviour
{
    SpriteRenderer arma;

    public GameObject bala;
    public Transform apareceBala;
    // Start is called before the first frame update
    void Start()
    {
        arma = GetComponent<SpriteRenderer>();

        
    }

    // Update is called once per frame
    void Update()
    {
        Mira();
        Tiro();
        
    }

    void Tiro()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Instantiate(bala, apareceBala.position, transform.rotation);
        }

    }

    void Mira()
    {
        Vector3 posicaoMouse = Input.mousePosition;
        Vector3 tela = Camera.main.WorldToScreenPoint(transform.position);

        Vector2 des = new Vector2(posicaoMouse.x - tela.x, posicaoMouse.y - tela.y);

        float angulo = Mathf.Atan2(des.y, des.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.Euler(0, 0, angulo);
        
        if(posicaoMouse.x < tela.x){
            arma.flipY = true;
        }
        else{
            arma.flipY = false;
        }

    }
}

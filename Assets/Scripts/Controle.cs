using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controle : MonoBehaviour
{
    [SerializeField] float vel;
    Vector2 mover;
    Animator an;

    // Start is called before the first frame update
    void Start()
    {
        an = GetComponentInChildren<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        mover.x = Input.GetAxis("Horizontal");
        mover.y = Input.GetAxis("Vertical");

        transform.Translate(mover * Time.deltaTime * vel);

        an.SetBool("isMove", (Mathf.Abs(mover.x) > 0 || Mathf.Abs(mover.y) > 0));
        
    }
}

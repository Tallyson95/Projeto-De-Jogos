using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#testandotestandotestando

public class MovimentoJogador : MonoBehaviour
{
    private Rigidbody2D rigidbory2D;
    public float velocidadePersonagem;
    void Awake(){
        rigidbory2D = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovimentoPersonagem();
    }

    private void MovimentoPersonagem(){ 
        float MovimentoHorizontal = Input.GetAxis("Horizontal");
        float eixoX = MovimentoHorizontal * velocidadePersonagem;
        float eixoy = rigidbory2D.velocity.y;

        rigidbory2D.velocity = new Vector2(eixoX, eixoy);
        if(MovimentoHorizontal > 0){
            transform.localScale = new Vector3(1f,1f,1f);
        }else{
            if(MovimentoHorizontal < 0){
                transform.localScale = new Vector3(-1f,1f,1f);
            }
        }
    }
}

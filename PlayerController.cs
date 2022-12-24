using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    bool canJump = true;

    // Start is called before the first frame update
    void Start()
    {//del objeto del juego en el que esta el script, quiero obtener el componente transform
        gameObject.GetComponent<Transform>().position = new Vector3(gameObject.transform.position.x + 5, gameObject.transform.position.y, gameObject.transform.position.z);
        //el transform tiene una forma mas corta y no hace falta el getComponent
        //y del transform queremos su posicion

        
    }

    // Update is called once per frame
    void Update()
    {
        //gameObject.GetComponent<Transform>().position = new Vector3(gameObject.transform.position.x + 0.1f * Time.deltaTime, gameObject.transform.position.y, gameObject.transform.position.z);
        //otro atajo para no poner tanto texto (?
        //gameObject.transform.Translate(1f * Time.deltaTime, 0, 0);

        /*if (Input.GetKey("left")) {
            gameObject.transform.Translate(-1f * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("right")) {
            gameObject.transform.Translate(1f * Time.deltaTime, 0, 0);
        }

        ManageJump();*/


        //ahora lo mismo, pero usando fisicas

        if (Input.GetKey("left")) {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(-1000f * Time.deltaTime, 0));
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
        }

        if (Input.GetKey("right")) {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(1000f * Time.deltaTime, 0));
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
        }

        if (Input.GetKeyDown("up") && canJump) {
            canJump = false;
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 200f));
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "ground") {
            canJump = true;
        }
    }

    void ManageJump()
    {
        /*if (gameObject.transform.position.y <= 0) {
            canJump = true;
        }

        if (Input.GetKey("up") && canJump && gameObject.transform.position.y < 10) {
            gameObject.transform.Translate(0, 5f * Time.deltaTime, 0);
        } else {
            canJump = false;

            if (gameObject.transform.position.y > 0) {
                gameObject.transform.Translate(0, -5f * Time.deltaTime, 0);
            }
        }*/

    }
}

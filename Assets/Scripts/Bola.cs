using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour
{

    public float VelocidadeDaBola;

    public float direcaoAleatoriaX;
    public float direcaoAleatoriaY;

    public Rigidbody2D oRigidBody2D;

    public AudioSource somDaBola;
    // Start is called before the first frame update
    void Start()
    {
        MoverBola();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void MoverBola()
    {
        oRigidBody2D.velocity = new Vector2(VelocidadeDaBola, VelocidadeDaBola);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        somDaBola.Play();
        oRigidBody2D.velocity += new Vector2(direcaoAleatoriaX, direcaoAleatoriaY);
    }
}

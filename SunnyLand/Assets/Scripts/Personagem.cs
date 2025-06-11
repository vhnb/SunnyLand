using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Personagem : MonoBehaviour
{
    string name = "vitinho";
    public int life = 100;
    float velocity = 2.5f;
    bool isDead = false;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log($"Personagem: {name} \n Vida: {life} \n Velocidade: {velocity} \n Morto: {isDead}");
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0.001f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillPlayerAtk : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject obj;
    public float countdown = 1.5f;
    public float vel;
    private Rigidbody2D bala;
    private Vector2 dir;
    private Transform alvo;
    public GameObject play;
    // Use this for initialization
    void Start()
    {
        bala = GetComponent<Rigidbody2D>();
        //alvo = GameObject.FindWithTag("Player").GetComponent<Transform>();
        vel = 0.3f;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /*void FixedUpdate()
    {
        //transform.position += Vector3.up * 0.3f;

        transform.position += Vector3.zero;
        countdown -= Time.deltaTime;
        if (countdown <= 0.0f)
        {
            Destroy(gameObject);
        }

        //bala.velocity = dir.normalized * vel;
    }*/
    // Update is called once per frame
    void FixedUpdate()
    {
        //transform.position += Vector3.up * 0.3f;

        transform.position += Vector3.up * vel;
        //bala.velocity = dir.normalized * vel;
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Inimigo"))
        {
            Destroy(gameObject);

        }
    }
}

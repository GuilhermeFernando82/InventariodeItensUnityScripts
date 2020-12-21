using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerController : MonoBehaviour
{
 
    public float speed = 5f;
    public Rigidbody2D playerRB;
    Vector2 movimento;
    public Animator anim;
    public float vida;
    public Image barra;
    public GameObject obj;
    public Rigidbody2D rb;
    public GameObject AtkHeroi;
    public bool esquerda;
    public bool baixo;
    public bool cima;
    public bool rgt;
	public GameObject SkillDown;
	public GameObject SkillRight;
	public GameObject SkillUp;
	public GameObject SkillLeft;
    public static PlayerController instance;
    public bool verify;
    
    // Start is called before the first frame update
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    void Start()
    {
        
    }
   


    // Update is called once per frame
    void Update()
    {
       /* if (Input.GetKeyUp(KeyCode.Space))
        {
            obj = Instantiate(AtkHeroi, transform.position, Quaternion.identity);
            rb = obj.GetComponent<Rigidbody2D>();
            rb.velocity = -transform.forward * 4;
        }*/
        barra.fillAmount = vida / 100;
        if (vida <= 0)
        {
            Application.LoadLevel("GameOver");
        }
        movimento.x = Input.GetAxisRaw("Horizontal");
        movimento.y = Input.GetAxisRaw("Vertical");

        anim.SetFloat("horizontal", movimento.x);
        anim.SetFloat("vertical", movimento.y);
        anim.SetFloat("velocity", movimento.sqrMagnitude);

        if (movimento != Vector2.zero)
        {
            anim.SetFloat("horizontalidle", movimento.x);
            anim.SetFloat("verticalidle", movimento.y);
        }

        if (baixo && Input.GetKeyUp(KeyCode.Space))
        {
            obj = Instantiate(SkillDown, transform.position, Quaternion.identity);
            rb = obj.GetComponent<Rigidbody2D>();
            rb.velocity = -transform.forward * 4;
            AudioController.corrent.PlayMusic(AudioController.corrent.Shot);

        }
        if (cima && Input.GetKeyUp(KeyCode.Space))
        {
            obj = Instantiate(SkillUp, transform.position, Quaternion.identity);
            rb = obj.GetComponent<Rigidbody2D>();
            rb.velocity = -transform.forward * 4;
            AudioController.corrent.PlayMusic(AudioController.corrent.Shot);
        }
        if (esquerda && Input.GetKeyUp(KeyCode.Space))
        {
            obj = Instantiate(SkillLeft, transform.position, Quaternion.identity);
            rb = obj.GetComponent<Rigidbody2D>();
            rb.velocity = -transform.forward * 4;
            AudioController.corrent.PlayMusic(AudioController.corrent.Shot);
        }
        if (rgt && Input.GetKeyUp(KeyCode.Space))
        {
            obj = Instantiate(SkillRight, transform.position, Quaternion.identity);
            rb = obj.GetComponent<Rigidbody2D>();
            rb.velocity = -transform.forward * 4;
            AudioController.corrent.PlayMusic(AudioController.corrent.Shot);


        }
      
        inputplayer();
    }
    void inputplayer()
    {
        movimento = Vector2.zero;
        if (Input.GetKey(KeyCode.UpArrow))
        {
            movimento += Vector2.up;
            cima = true;
            esquerda = false;
            baixo = false;
            rgt = false;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            movimento += Vector2.down;
            baixo = true;
            esquerda = false;
            cima = false;
            rgt = false;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            movimento += Vector2.left;
            esquerda = true;
            baixo = false;
            cima = false;
            rgt = false;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            movimento += Vector2.right;
            rgt = true;
            esquerda = false;
            baixo = false;
            cima = false;
        }


        //if (direcao == Vector2.down) {

        //}
    }
    public void StatusAdd(float heath, float vel)
    {
        verify = true;
        speed += vel;
        vida += heath;
    }
    public void StatusRemove(float heath, float vel)
    {
        verify = false;
        speed -= vel;
        vida -= heath;
        
       
        
    }
    private void FixedUpdate()
    {
        playerRB.MovePosition(playerRB.position + movimento * speed * Time.fixedDeltaTime);   
    }
}

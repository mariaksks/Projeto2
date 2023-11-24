using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;



public class Playermove : MonoBehaviour
{
    public float speed = 10f;
    public Rigidbody2D playerRb;
    public  Animator animator;
    public Transform limitesCamera;
    double vida = 10;
    double garrafa = 10;
    public TMP_Text fim;
    public GameObject gomensFim, goCaminhaoComida, goPlayer;
    int vidaLocal;
    Vector2 move;
    private AudioSource sound;
    void Awake()
    {
      sound = GetComponent<AudioSource> ();
    }
    //private int vidaMax = 5;

    //vida
    [SerializeField] Image vidaOn1;
    [SerializeField] Image vidametade1;
    [SerializeField] Image vidaOff1;

    [SerializeField] Image vidaOn2;
    [SerializeField] Image vidametade2;
    [SerializeField] Image vidaOff2;

    [SerializeField] Image vidaOn3;
    [SerializeField] Image vidametade3;
    [SerializeField] Image vidaOff3;

    [SerializeField] Image vidaOn4;
    [SerializeField] Image vidametade4;
    [SerializeField] Image vidaOff4;

    [SerializeField] Image vidaOn5;
    [SerializeField] Image vidametade5;
    [SerializeField] Image vidaOff5;

    // garrafa de agua

    [SerializeField] Image garrafavazia1;
    [SerializeField] Image garrafametade1;
    [SerializeField] Image garrafacheia1;


    [SerializeField] Image garrafavazia2;
    [SerializeField] Image garrafametade2;
    [SerializeField] Image garrafacheia2;


    [SerializeField] Image garrafavazia3;
    [SerializeField] Image garrafametade3;
    [SerializeField] Image garrafacheia3;


    [SerializeField] Image garrafavazia4;
    [SerializeField] Image garrafametade4;
    [SerializeField] Image garrafacheia4;


    [SerializeField] Image garrafavazia5;
    [SerializeField] Image garrafametade5;
    [SerializeField] Image garrafacheia5;
    
    [SerializeField] Text txtTempo;
    [SerializeField] float contTempo = 180;
    public GameObject mensFimT;
    public TMP_Text fimT;

    void Start()
    {
        InvokeRepeating("DecrementarTempo", 1f, 1f);
    }
    void DecrementarTempo()
    {

        if(contTempo > 0)
        {
            contTempo--;
        }
        else
        {
            contTempo = 0f;
        }
        ExibirTempo(contTempo);
    }


    void ExibirTempo(float contTempo)
    {
        if (contTempo <= 0f)
        {
            mensFimT.SetActive(true);
            fimT.text = "Seu tempo acabou!";
            SceneManager.LoadScene("Menu");
            
        }

        float minutos = Mathf.FloorToInt(contTempo /60);
        float segundos = Mathf.FloorToInt(contTempo % 60);
        if(segundos == 55 || segundos == 50 || segundos == 45 || segundos == 40 || segundos == 35 || segundos == 30 || segundos == 25|| segundos == 20 || segundos == 15 || segundos == 10 || segundos == 5)
        {
            Dano();
            Desidratacao();
        }
        
        txtTempo.text = string.Format("{0:00} : {1:00}", minutos, segundos);
    }
    //dano na vida
    private void Dano()
    {
        
        
        if (vida >= 10)
        {
            vidametade5.enabled = true;
            vidaOn5.enabled = false;
            vida -= 1;
        }
        else if (vida == 9)
        {
            vidametade5.enabled = false;
            vidaOff5.enabled = true;
            vida -= 1;
        }
        else if (vida == 8)
        {
            vidaOn4.enabled = false;
            vidametade4.enabled = true;
            vida -= 1;
        }
        else if (vida == 7)
        {
            vidametade4.enabled = false;
            vidaOff4.enabled = true;
            vida -= 1;
        }
        else if (vida == 6)
        {
            vidaOn3.enabled = false;
            vidametade3.enabled = true;
            vida -= 1;
        }
        else if (vida == 5)
        {
            vidametade3.enabled = false;
            vidaOff3.enabled = true;
            vida -= 1;
        }
        else if (vida == 4)
        {
            vidaOn2.enabled = false;
            vidametade2.enabled = true;
            vida -= 1;
            goCaminhaoComida.SetActive(true);
        }
        else if (vida == 3)
        {
            goCaminhaoComida.SetActive(false);
            vidametade2.enabled = false;
            vidaOff2.enabled = true;
            vida -= 1;
        }
        else if (vida == 2)
        {
            vidaOn1.enabled = false;
            vidametade1.enabled = true;
            vida -= 1;

        }
        else if (garrafa <= 1)
        {
            vidametade1.enabled = false;
            vidaOff1.enabled = true;
            vida -= 1;
            gomensFim.SetActive(true);
            fim.text = "Você não comeu o suficiente!";
            SceneManager.LoadScene("Menu");
        }
        
    }
    //fun��o para quando a garrafa vai ficar vazia 
        private void Desidratacao()
    {
        if (garrafa >= 10)
        {
            garrafacheia5.enabled = false;
            garrafametade5.enabled = true;
            garrafa -= 1;
        }
        else if (garrafa == 9)
        {
            garrafametade5.enabled = false;
            garrafavazia5.enabled = true;
            garrafa -= 1;
        }
        else if (garrafa == 8)
        {
            garrafacheia4.enabled = false;
            garrafametade4.enabled = true;
            garrafa-= 1;
        }
        else if (garrafa == 7)
        {
            garrafametade4.enabled = false;
            garrafavazia4.enabled = true;
            garrafa -= 1;
        }

        else if (garrafa == 6)
        {
            garrafacheia3.enabled = false;
            garrafametade3.enabled = true;
            garrafa -= 1;
        }
        else if (garrafa == 5)
        {
            garrafametade3.enabled = false;
            garrafavazia3.enabled = true;
            garrafa -= 1;
        }
        else if (garrafa == 4)
        {
            garrafacheia2.enabled = false;
            garrafametade2.enabled = true;
            garrafa -= 1;
        }
        else if (garrafa == 3)
        {
            garrafametade2.enabled = false;
            garrafavazia2.enabled = true;
            garrafa -= 1;
        }
        else if (garrafa == 2)
        {
            garrafacheia1.enabled = false;
            garrafametade1.enabled = true;
            garrafa -= 1;
        }
        else if (garrafa == 1)
        {
            garrafametade1.enabled = false;
            garrafavazia1.enabled = true;
            garrafa -= 1;
            gomensFim.SetActive(true);
            fim.text = "Você desidratou!";
            SceneManager.LoadScene("Menu");
        }
        
    }
    //fun��o para o cora��o ficar cheio ou vazio 
    private void Vida()
    {
       if (vida >= 10)
        {
            vidaOn5.enabled = true;
            vidametade5.enabled = false;
        }
        else if (vida == 9)
        {
            vidametade5.enabled = true;
            vidaOff5.enabled = false;
        }
        else if (vida == 8) 
        {
            vidaOn4.enabled = true;
            vidametade4.enabled = false;
        }
        else if (vida == 7)
        {
            vidametade4.enabled = true;
            vidaOff4.enabled = false;
        }
        else if (vida == 6)
        {
            vidaOn3.enabled = true;
            vidametade3.enabled = false;
        }
        else if (vida == 5)
        {
            vidametade3.enabled = true;
            vidaOff3.enabled = false;
        }
        else if (vida == 4)
        {
            vidaOn2.enabled = true;
            vidametade2.enabled = false;
        }
        else if (vida == 3)
        {
            vidametade2.enabled = true;
            vidaOff2.enabled = false;
        }
        else if(vida == 2)
        {
            vidaOn1.enabled = true;
            vidametade1.enabled = false;
        }
        else if (vida == 1)
        {
            vidametade1.enabled = true;
            vidaOff1.enabled = false;
        }
    }
    //fun��o para a garrafa ficar vazia ou cheia
    private void Hidratacao()
    {
        if (garrafa >= 10)
        {
            garrafacheia5.enabled = true;
            garrafametade5.enabled = false;
        }
        else if (garrafa == 9)
        {
            garrafametade5.enabled = true;
            garrafavazia5.enabled = false;
        }
        else if (garrafa == 8)
        {
            garrafacheia4.enabled = true;
            garrafametade4.enabled = false;
        }
        else if (garrafa == 7)
        {
            garrafametade4.enabled = true;
            garrafavazia4.enabled = false;
        }
        else if (garrafa == 6)
        {
            garrafacheia3.enabled = true;
            garrafametade3.enabled = false;
        }
        else if (garrafa == 5)
        {
            garrafametade3.enabled = true;
            garrafavazia3.enabled = false;
        }
        else if (garrafa == 4)
        {
            garrafacheia2.enabled = true;
            garrafametade2.enabled = false;
        }
        else if (garrafa == 3)
        {
            garrafametade2.enabled = true;
            garrafavazia2.enabled = false;
        }
        else if (vida == 2)
        {
            garrafacheia1.enabled = true;
            garrafametade1.enabled = false;
        }
        else if (garrafa == 1)
        {
            garrafametade1.enabled = true;
            garrafavazia1.enabled = false;
        }
    }
    // Update is called once per frame
    void Update()
    {
        move.x = Input.GetAxisRaw("Horizontal");
        move.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("horizontal", move.x);
        animator.SetFloat("vertical", move.y);
        animator.SetFloat("velocidade", move.sqrMagnitude);

        if(move != Vector2.zero)
        {
            animator.SetFloat("horizontalIdle", move.x);
            animator.SetFloat("verticalIdle", move.y);
        }
    }
    
    private void FixedUpdate()
    {
        playerRb.MovePosition(playerRb.position + move * speed * Time.fixedDeltaTime);
        limitesCamera.position = new Vector3(Mathf.Clamp(transform.position.x,22f, 82f), Mathf.Clamp(transform.position.y,-3.349999f, 54.54974f), transform.position.z);
    }
    
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "banana" || col.gameObject.tag == "cafe" || col.gameObject.tag == "maca" || col.gameObject.tag == "pao")
        {
            Destroy(col.gameObject);
            sound.Play();
            vida += 1;
            Vida();
        }
        if (col.gameObject.tag == "Agua")
        {
            Destroy(col.gameObject);
            sound.Play();
            garrafa += 1;
            Hidratacao();

        }
        if (col.gameObject.tag == "bananaP" || col.gameObject.tag == "macaP" )
        {
            Destroy(col.gameObject);
            sound.Play();
            Dano();
            Desidratacao();     
        } 
        else if (col.gameObject.tag == "espinho")
        {
            Dano();      
        }
        if (col.gameObject.tag == "CamminhaoComida")
        {
            while (vidaLocal < 3)
            {
                vida += 1;
                Vida();
                vidaLocal++;
            }
            
            goCaminhaoComida.SetActive(false);
            sound.Play();
        }
         if (col.gameObject.tag == "Policial")
        {

            vida = 0;
            gomensFim.SetActive(true);
            fim.text = "Você foi pego. Fim de Jogo!";
            SceneManager.LoadScene("Menu");
        }
        if (col.gameObject.tag == "ONG")
        {
            goPlayer.SetActive(false);
            gomensFim.SetActive(true);
            fim.text = "Você conseguiu chegar na ONG!";
            SceneManager.LoadScene("Ganhou");
        }

    }
    
}

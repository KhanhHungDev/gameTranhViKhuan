using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayGame : MonoBehaviour
{   
    public int maxHealth = 100;
    public int currentHeath;
    public Healthbar healthbar;
    private  Collider other;

    //
    private TextMeshProUGUI text;
    private static int points = 0;
    public GameObject scoretext;
    //
    [HideInInspector]
    public TextMeshProUGUI textDie;
    [HideInInspector]
    public static int pointDie = 0;
    public GameObject Dietext;

    //
    public PlayerCollision collison;
    //
    private void Start()
    {
        currentHeath = maxHealth;
        healthbar.SetMaxHealth(maxHealth);
        other = GetComponent<Collider>();
        //
        text = scoretext.GetComponent<TextMeshProUGUI>();
        textDie = Dietext.GetComponent<TextMeshProUGUI>();

        //
    }
    private void Update()
    {
        
            Damage();
       
    }
    private void Damage()
    {
        if (other.CompareTag("Cylinder"))
        {
            //
            points++;
            Debug.Log(points);
            text.text = "Score" + points;
            //
            FindObjectOfType<AudioManager>().Play("PlayerDeath");
            //TakeDamage(20);
            other.gameObject.SetActive(false);       
        }

        else if(other.CompareTag("Group"))
        {
            Debug.Log("You die");
            TakeDamage(20);
           
        }
        else if (other.CompareTag("win"))
        {
            TakeDamage(50);
            other.gameObject.SetActive(false);
        }
        else if (other.CompareTag("end"))
        {
            TakeDamage(50);
            other.gameObject.SetActive(false);
        }  
    }
    public  void TakeDamage (int damage)
    {
        currentHeath -= damage;
        healthbar.SetHealth(currentHeath); 
    }

    //

   public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Cylinder"))
        {   //
            points++;
            Debug.Log(points);
            text.text = "SCORE:" + points;

            //
            FindObjectOfType<AudioManager>().Play("COINS");
            //TakeDamage(20);    
            other.gameObject.SetActive(false);
        }
        else if (other.CompareTag("Group"))
        {
            Debug.Log("You die");
            FindObjectOfType<AudioManager>().Play("Aww");
            GetComponent<Animator>().Play("DAMAGED00", -1, 0f);
            TakeDamage(50);
            

        }
        else if (other.CompareTag("win"))
        {
            FindObjectOfType<GameManager>().EndGame();
            GetComponent<Animator>().Play("WIN00", -1, 0f);
            FindObjectOfType<AudioManager>().Play("Win");
            other.gameObject.SetActive(false);
        }
        else if (other.CompareTag("end"))
        {
            FindObjectOfType<GameManager>().EndGame();
            GetComponent<Animator>().Play("WIN00", -1, 0f);
            FindObjectOfType<AudioManager>().Play("Win");
            other.gameObject.SetActive(false);
        }

    }
 


    private void FixedUpdate()
    {
        if (currentHeath<=0)
        {
            FindObjectOfType<GameManager>().EndGame();
            FindObjectOfType<AudioManager>().Play("PlayerDeath");
            currentHeath = 100;
            points = 0;
            GetComponent<Animator>().Play("LOSE00", -1, 0f);
            //
            pointDie++;
            textDie.text = "DIE:" + pointDie;
        }
       
    }
}

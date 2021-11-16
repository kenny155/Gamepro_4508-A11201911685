using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControl : MonoBehaviour{
    public Rigidbody2D Rb;
    public float ms = 5 ;
    int score = 0;
    private Vector2 moveDirection;
    GUIStyle guiStyle = new GUIStyle();
    private AudioSource audioSource;
    public AudioClip Scored;
    
    void Update(){
        ProcessInputs();
    }
    void FixedUpdate(){
        Move();
    }
    void ProcessInputs(){
        float horiz = Input.GetAxisRaw("Horizontal");
        float verti = Input.GetAxisRaw("Vertical");
        moveDirection = new Vector2(horiz,verti).normalized;
    }
    void Move(){
        Rb.velocity = new Vector2(moveDirection.x * ms, moveDirection.y * ms);
    }
    void Die(){
        Debug.Log("Game Over");
        SceneManager.LoadScene("Menu");
    }
    void OnCollisionEnter2D(Collision2D coll){
        if(coll.gameObject.tag == "enemyTag"){
            Die();
        }
        if(coll.gameObject.tag == "coinTag"){
            score++;
            audioSource = GetComponent<AudioSource>();
            audioSource.clip = Scored;
            audioSource.Play();
        }
    }
    void OnGUI(){
        guiStyle.fontSize = 40;
        GUI.Label(new Rect(0,0,300,50), "Score: "+score.ToString(), guiStyle);
    }
}

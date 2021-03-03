using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BallSpawar : MonoBehaviour
{
    public static BallSpawar instance;
    [SerializeField] AudioSource M_audio;
    [SerializeField] GameObject playerPref;
    [SerializeField] GameObject Spawnposition;
    [SerializeField] Text M_TEXT;
    [SerializeField] private int S_speed = 1000;
    [SerializeField]int dead = 6;

    int temp = 0;
    int M_bullet = 20;
    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {    
        M_audio = GetComponent<AudioSource>();
        M_TEXT.text = "BULLET:" + M_bullet.ToString();
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            temp++;
            if (temp <= 20)
            {
                M_audio.Play();
                M_bullet--;
                M_TEXT.text = "BULLET:" + M_bullet.ToString();
                Invoke("bulletover", 5f);
                GameObject shoot = Instantiate(playerPref, Spawnposition.transform.position, Quaternion.identity) as GameObject;
                var rb = shoot.AddComponent<Rigidbody>();
                //Debug.Log(shoot.transform.position);
                rb.useGravity = false;
                rb.AddForce(transform.forward * S_speed, ForceMode.Force);
                Destroy(shoot, 2f);
            }    
        }
        else
        {
            //Debug.Log("Bullet Over");
        }
    }
    public void bulletover()
    {
        if(M_bullet <= 0 && dead >= 0)
        {          
            Debug.Log("Bullet Over....And You Lost");
            //Time.timeScale = 0;
            Invoke("LoseScreen", 2f);
        }
    }
    public void M_DEAD()
    {
        dead--;
        Debug.Log(dead);
        if (dead <= 0 && M_bullet >= 1)
        {
            Debug.Log("You Win!!!");
            //Time.timeScale = 0;
            // StartCoroutine(WinScreen());
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        }
    }
   public  void LoseScreen()
    {
        SceneManager.LoadScene("LoseScreen");
    }
    /*void M_check()
    {
        float enemy = GameObject.Find("enemys").transform.childCount;
        Debug.Log("ChildCount::"+enemy);
    }*/

}
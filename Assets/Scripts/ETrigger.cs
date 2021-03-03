using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class ETrigger : MonoBehaviour
{
    [SerializeField] Text level;
    
    private void OnTriggerEnter(Collider other)
    {      
            Destroy(other.gameObject);
            level.text = "You Lost Wait..";
            Invoke("S_Scene", 3f);
           //BallSpawar.instance.LoseScreen();       
    }
    void S_Scene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}

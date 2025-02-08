using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerIntelligence : MonoBehaviour
{
    public Image Pause;
    public Player Player;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.A))
        {
            Player.MoveVector = -1;
        }else if (Input.GetKey(KeyCode.D))
        {
            Player.MoveVector = 1;
        }else Player.MoveVector = 0;

        if (Input.GetKeyDown(KeyCode.W))
        {
            Player.BasketFlag = true;
        }else if (Input.GetKeyDown(KeyCode.S))
            Player.BasketFlag = false;
        
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = Time.timeScale == 0 ? 1 : 0;
            Pause.enabled = Time.timeScale == 0;
        }
    }
}

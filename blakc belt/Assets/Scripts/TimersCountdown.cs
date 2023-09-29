using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimersCountdown : MonoBehaviour
{
    public Text lapTime;
    public Text startCountdown;

    public float totalLapTime;
    public float totalCountdownTime;
    public CodeyMove codeySpeed;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(totalCountdownTime > 0){
            totalCountdownTime-=Time.deltaTime;
            startCountdown.text = totalCountdownTime.ToString("F0");
            codeySpeed.Speed = 0;

        }
        if(totalCountdownTime <= 0){
            Destroy(startCountdown);
            totalLapTime-=Time.deltaTime;
            lapTime.text = totalLapTime.ToString("F0");
            codeySpeed.Speed = 40;
        }
        if(totalLapTime < 0){
            print("Time is up!");
            SceneManager.LoadScene(2);
        }
    }
}

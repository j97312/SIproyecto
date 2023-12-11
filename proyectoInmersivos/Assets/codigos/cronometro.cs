using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cronometro : MonoBehaviour
{
    public float timer;
    public Text text;
    public Animator animator;
    public bool start;
    public bool stop;

    void Start()
    {
        timer = 0;
        start = false;
        stop = false;
        text.text = "Tiempo: " + timer.ToString();
    }

    void Update()
    {
        if (start && !stop)
        {
            timer += Time.deltaTime;
            text.text = "Tiempo: " + Mathf.Round(timer).ToString();
        }
    }

    public void StartTimer()
    {
        start = true;
    }

    public void StopTimer()
    {
        stop = true;
        start = false;
        animator.SetTrigger("TimerFinished");
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstaculo"))
        {
            FindObjectOfType<cronometro>().StopTimer();
        }
        void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.CompareTag("Obstaculo2"))
            {
                FindObjectOfType<cronometro>().StopTimer();
            }
        }
    }
}
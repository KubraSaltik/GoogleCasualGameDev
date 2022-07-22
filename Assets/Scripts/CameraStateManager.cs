using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraStateManager : MonoBehaviour
{
    private float waitTime = 2.0f;
    private float timer = 0.0f;
    private bool isTimerStarted = false;
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
        StartIdleTimer();
    }

    private void Awake()
    {
        Cursor.visible = true;
    }

    void Update()
    {
        Idle();
    }

    private void Idle()
    {
        if (animator.GetBool("Idle")) return;
        if (!isTimerStarted) return;

        timer += Time.deltaTime;

        if (waitTime < timer)
        {
            animator.SetBool("Idle", true);
            timer = 0.0f;
            isTimerStarted = false;
        }
    }

    public void ExitIdle()
    {
        animator.SetBool("Idle", false);
    }

    public void StartIdleTimer()
    {
        timer = 0.0f;
        isTimerStarted = true;
    }
}

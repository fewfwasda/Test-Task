using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlauerContorlls : MonoBehaviour
{
    [SerializeField] private List<Transform> wayPoints;
    [SerializeField] private float speed;
    private int index = 0;
    Animator animator;
    public bool isMove = true;
    private int maxIndex = 0;
    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        maxIndex = wayPoints.Count;
        if (isMove == true)
        {
            if (DetectoinZone.Run == true)
            {
                if (Vector3.Distance(transform.position, wayPoints[index].position) < 0.001f)
                {
                    index++;
                    if (maxIndex == index) isMove = false;
                    else isMove = true;
                }

                var step = speed * Time.deltaTime;
                transform.position = Vector3.MoveTowards(transform.position, wayPoints[index].position, step);
                animator.SetBool("isRunnig", true);
            }
            else animator.SetBool("isRunnig", false);
        }
        else SceneManager.LoadScene(0);
    }
}
using UnityEngine;
using System.Collections;

public class animator : MonoBehaviour
{
    Animator m_Animator;

    void OnMouseUp()
    {
        m_Animator = gameObject.GetComponent<Animator>();
        m_Animator.enabled = true;
    }
}
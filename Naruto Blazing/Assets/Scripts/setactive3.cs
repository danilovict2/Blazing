using UnityEngine;
using System.Collections;

public class setactive3 : MonoBehaviour
{
    public GameObject rank, rank2, Button;

    void Start()
    {
        StartCoroutine(Wait());
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(1);
        rank.SetActive(false);
        rank2.SetActive(true);
        yield return new WaitForSeconds(2);
        Button.SetActive(true);
    }
}
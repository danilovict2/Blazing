using UnityEngine;
using System.Collections;

public class setactive2_3no : MonoBehaviour
{
    public GameObject narutokid_1, rasengan, teleport_0, commse0_00119, enemy_2_0, enemy_2_1, damage1, damage2, damage3, damage5;

    void OnMouseUp()
    {
        StartCoroutine(Wait());
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(1.5F);
        narutokid_1.SetActive(true);
        rasengan.SetActive(true);
        yield return new WaitForSeconds(1);
        teleport_0.SetActive(false);
        commse0_00119.SetActive(false);
        enemy_2_0.SetActive(true);
        yield return new WaitForSeconds(1);
        enemy_2_1.SetActive(false);
        damage1.SetActive(false);
        damage2.SetActive(false);
        damage3.SetActive(false);
        damage5.SetActive(false);
    }
}
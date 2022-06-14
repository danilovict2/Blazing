using UnityEngine;
using System.Collections;

public class die4 : MonoBehaviour
{
    public GameObject teleport_0, commse0_00119, enemy_2_0, enemy_2_1, icon2, health2, running_1, SceneChange, Image3, battle_00075, bt_com_system1;

    void OnMouseUp()
    {
        StartCoroutine(Wait());
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(2);
        teleport_0.SetActive(false);
        commse0_00119.SetActive(false);
        enemy_2_0.SetActive(false);
        enemy_2_1.SetActive(false);
        icon2.SetActive(false);
        health2.SetActive(false);
        running_1.SetActive(true);
        SceneChange.SetActive(true);
        Image3.SetActive(true);
        battle_00075.SetActive(true);
        bt_com_system1.SetActive(true);
    }
}
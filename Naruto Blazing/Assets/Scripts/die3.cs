using UnityEngine;
using System.Collections;

public class die3 : MonoBehaviour
{
    public GameObject teleport_0, commse0_00119, enemy_0, enemy_1, enemy_2_0, enemy_2_1, icon, icon2, health, health2, running_1, SceneChange, Image3, battle_00075, bt_com_system0, bt_com_system1;

    void OnMouseUp()
    {
        StartCoroutine(Wait());
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(3.5F);
        teleport_0.SetActive(false);
        commse0_00119.SetActive(false);
        enemy_0.SetActive(false);
        enemy_2_0.SetActive(false);
        icon.SetActive(false);
        icon2.SetActive(false);
        health.SetActive(false);
        health2.SetActive(false);
        running_1.SetActive(true);
        SceneChange.SetActive(true);
        Image3.SetActive(true);
        battle_00075.SetActive(true);
        bt_com_system0.SetActive(true);
        bt_com_system1.SetActive(true);
        enemy_1.SetActive(false);
        enemy_2_1.SetActive(false);
    }
}
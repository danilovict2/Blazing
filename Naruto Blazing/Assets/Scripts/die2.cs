using UnityEngine;
using System.Collections;

public class die2 : MonoBehaviour
{
    public GameObject teleport_0, commse0_00119, enemy_0, enemy_1, icon, health, running_1, SceneChange, Image3, battle_00075, bt_com_system0;

    void OnMouseUp()
    {
        StartCoroutine(Wait());
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(2);
        teleport_0.SetActive(false);
        commse0_00119.SetActive(false);
        enemy_0.SetActive(false);
        icon.SetActive(false);
        health.SetActive(false);
        running_1.SetActive(true);
        SceneChange.SetActive(true);
        Image3.SetActive(true);
        battle_00075.SetActive(true);
        bt_com_system0.SetActive(true);
        enemy_1.SetActive(false);
    }
}
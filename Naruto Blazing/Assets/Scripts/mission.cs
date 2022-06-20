using UnityEngine;
using System.Collections;

public class mission : MonoBehaviour
{
    public GameObject teleport_0, commse0_00119, enemy_0, enemy_1, icon, health, SceneChange, battle_00075, bt_com_system0, narutokid_3, Image, Image4, Image5, Image6, Image7, Image8, Image9, Image10, Image11, Image12;

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
        icon.SetActive(false);
        health.SetActive(false);
        SceneChange.SetActive(true);
        battle_00075.SetActive(true);
        bt_com_system0.SetActive(true);
        narutokid_3.SetActive(true);
        Image4.SetActive(true);
        Image5.SetActive(true);
        Image6.SetActive(true);
        Image7.SetActive(true);
        Image8.SetActive(true);
        Image9.SetActive(true);
        Image10.SetActive(true);
        Image11.SetActive(true);
        Image12.SetActive(true);
        enemy_1.SetActive(false);
        Image.SetActive(false);
    }
}
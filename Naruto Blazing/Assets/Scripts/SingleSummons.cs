using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SingleSummons : MonoBehaviour
{
    /*  Units   */
    public Sprite[] fiveStars;
    public Sprite[] fourStars;
    public Sprite[] threeStars;
    /*Contracts for changing depending on rarity*/
    public Sprite fiveStarContact,fourStarContact,threeStarContact;
    /*Panels for changing depending on rarity*/
    public Sprite threeStarPanel,fourStarPanel,fiveStarPanel,sixStarPanel;
    /*Stars for changing depending on rarity*/
    public Sprite stars3,stars4,stars5;
    /*Unit for activation*/
    public GameObject unit;
    /*Types for changing*/
    public Sprite bravery,wisdom,heart,body,wind;//change name for wind
    /*Contract changer*/
    SpriteRenderer unitRarity;
    /*Animations*/
    public Animator contractTransition,contract;
    /*Sprites being changed*/
    public Image stars,panel,icon,type;
    int randomChoice;//random choice for unit
    public GameObject next;
    bool firstclick = true;
    void Start() {
        unitRarity = contract.gameObject.GetComponent<SpriteRenderer>();
        randomChoice = Random.Range(0,100);
        if(randomChoice>=0 && randomChoice<=11){
            unitRarity.sprite = fiveStarContact; 
        }else if(randomChoice>=12 && randomChoice<=62){
            unitRarity.sprite = fourStarContact; 
        }else{
            unitRarity.sprite = threeStarContact; 
        }
        contract.gameObject.SetActive(true);
        contract.Play("spawnIn");
        
        
    }
    void Update() {
        bool click = Input.GetMouseButtonDown(0);
        if(click){
            Vector2 cubeRay = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D cubeHit = Physics2D.Raycast(cubeRay, Vector2.zero);
            if(firstclick){
                firstclick = false;
                if(cubeHit){
                    instantiateUnits();
                }
            }else{
                if(cubeHit){
                    SceneManager.LoadScene("summons");
                }
            }
        }
    }

    void instantiateUnits(){
        if(randomChoice>=0 && randomChoice<=11){
            int randChoice = Random.Range(0,fiveStars.Length - 1);
            createFiveStar(randChoice);
        }else if(randomChoice>=12 && randomChoice<=62){
            int randChoice = Random.Range(0,fourStars.Length - 1);
            createFourStar(randChoice);
        }else{
            int randChoice = Random.Range(0,threeStars.Length - 1);
            createThreeStar(randChoice);
        }
        createUnit();
    }

    void createFiveStar(int randChoice){
        panel.sprite = fiveStarPanel;
        stars.sprite = stars5;
        icon.sprite = fiveStars[randChoice];
    }
    void createFourStar(int randChoice){
        panel.sprite = fourStarPanel;
        stars.sprite = stars4;
        icon.sprite = fourStars[randChoice];
    }

    void createThreeStar(int randChoice){
        panel.sprite = threeStarPanel;
        stars.sprite = stars3;
        icon.sprite = threeStars[randChoice];
    }
    void createUnit(){
        contractTransition.gameObject.SetActive(true);
        contractTransition.Play("contract");
        contract.Play("contract2");
        Invoke("random", 0.5f);
    }
    void random(){
        unit.SetActive(true);
        next.SetActive(true);
    }
    
}




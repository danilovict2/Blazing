using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Multis : MonoBehaviour
{
    public Animator[] contracts;
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
    public GameObject[] units;
    /*Types for changing*/
    //public Sprite bravery,wisdom,heart,body,wind;//change name for wind
    /*Contract changer*/
    SpriteRenderer unitRarity;
    /*Animations*/
    public Animator[] contractTransition,contract;
    /*Sprites being changed*/
    public Image[] stars,panel,icon,type;
    int currentUnit = 0;
    int[] randomChoice = new int[10];//random choice for unit
    public GameObject next;
    int SpawnHelp = 0;
    bool firstclick = true;
    void Start() {
        int i;
        for(i=0;i<contracts.Length;++i){
            randomChoice[i] = Random.Range(0,100);
            getRarity(i);
            Invoke("createContact",i * 0.1f);
        }
        
    }
    void Update() {
        bool click = Input.GetMouseButtonDown(0);
        if(click){
            Vector2 cubeRay = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D cubeHit = Physics2D.Raycast(cubeRay, Vector2.zero);
            if(firstclick){
                if(currentUnit >= 9){
                    firstclick = false;
                    next.SetActive(true);
                }
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
    void createContact(){
        contracts[SpawnHelp].gameObject.SetActive(true);
        contracts[SpawnHelp].Play("spawnIn");
        ++SpawnHelp;
    }
    void getRarity(int i){
        unitRarity = contracts[i].gameObject.GetComponent<SpriteRenderer>();
        if(randomChoice[i]>=0 && randomChoice[i]<=11){
            unitRarity.sprite = fiveStarContact;
        }else if(randomChoice[i]>=12 && randomChoice[i]<=62){
            unitRarity.sprite = fourStarContact;
        }else{
            unitRarity.sprite = threeStarContact;
        }
    }
    void instantiateUnits(){
        if(randomChoice[currentUnit]>=0 && randomChoice[currentUnit]<=11){
            int randChoice = Random.Range(0,fiveStars.Length - 1);
            createFiveStar(randChoice);
        }else if(randomChoice[currentUnit]>=12 && randomChoice[currentUnit]<=62){
            int randChoice = Random.Range(0,fourStars.Length - 1);
            createFourStar(randChoice);
        }else{
            int randChoice = Random.Range(0,threeStars.Length - 1);
            createThreeStar(randChoice);
        }
        createUnit();
    }

    void createFiveStar(int randChoice){
        panel[currentUnit].sprite = fiveStarPanel;
        stars[currentUnit].sprite = stars5;
        icon[currentUnit].sprite = fiveStars[randChoice];
    }
    void createFourStar(int randChoice){
        panel[currentUnit].sprite = fourStarPanel;
        stars[currentUnit].sprite = stars4;
        icon[currentUnit].sprite = fourStars[randChoice];
    }

    void createThreeStar(int randChoice){
        panel[currentUnit].sprite = threeStarPanel;
        stars[currentUnit].sprite = stars3;
        icon[currentUnit].sprite = threeStars[randChoice];
    }
    void createUnit(){
        Animator tmp = contractTransition[currentUnit];
        tmp.gameObject.SetActive(true);
        tmp.Play("contract");
        contract[currentUnit].Play("contract2");
        Invoke("instantiateUnit", 0.5f);
    }
    void instantiateUnit(){
        units[currentUnit].SetActive(true);
        currentUnit++;
    }
}

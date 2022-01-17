using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;

public class GUIManager : MonoBehaviour
{
    public Button bEasy,bMed,bHard;

//button 
    public void OnPlay(){
        SceneManager.LoadScene("Menu");
    }
    public void OnStart(){
        SceneManager.LoadScene("multilevel1");
    }
    public void OnCredits(){
        SceneManager.LoadScene("Credits");
    }

    public void OnHelp(){
        SceneManager.LoadScene("Help");
    }

    public void OnBack(){
        SceneManager.LoadScene("Menu");
    }

    public void Onlevel1(){
        SceneManager.LoadScene("Main");
    }

    public void Onlevel2(){
        SceneManager.LoadScene("Medium");
    }
    
    public void Onlevel3(){
        SceneManager.LoadScene("Imposible");
    }

    public static int LoadLevel(){
        int hg = 0;
        if(!PlayerPrefs.HasKey("Level"))
            PlayerPrefs.SetInt("Level", 0);
        else
        //PlayerPrefs.SetInt("Level", 0);
            hg = PlayerPrefs.GetInt("Level");
        return hg;
    }

    public static void saveLevel(int lvl){
        if(!PlayerPrefs.HasKey("Level"))
            PlayerPrefs.SetInt("Level", 0);
        else 
            PlayerPrefs.SetInt("Level", lvl);
    }

    void LoadButtonLevel(){
        bEasy = GameObject.Find ("Easy").GetComponent<Button>();
        bMed = GameObject.Find ("Medium").GetComponent<Button>();
        bHard = GameObject.Find ("Hard").GetComponent<Button>();

        bEasy.interactable = bMed.interactable = bHard.interactable = false;
    }

    void Start(){
        try{
            LoadButtonLevel();
            int Levelstate = LoadLevel();
            switch (Levelstate){
                case 0:
                    bEasy.interactable = true;
                    break;
                case 1:
                    bEasy.interactable = true;
                    bMed.interactable = true;
                    break;
                case 2:
                    bEasy.interactable = true;
                    bMed.interactable = true;
                    bHard.interactable = true;
                    break;
            }
        }

        catch(NullReferenceException e){

        }
    }
}

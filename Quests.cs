using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Quests : MonoBehaviour
{
    [SerializeField] private Text NameText;
    [SerializeField] private string[] Names;

    public void Start()
    {
        NameText.text = Names[Random.Range(0, Names.Length)];
    }





}

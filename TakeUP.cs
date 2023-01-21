using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TakeUP : MonoBehaviour
{
    [SerializeField] private AudioSource UpFood;
    [SerializeField] private Text NameText;
    [SerializeField] private Text RandText;
    [SerializeField] private Text QText;

    public int food;
    public Text TextFood;
    public GameObject spawn;
    public GameObject collfood;
    public int NameCount;
    public int q;
    public int qq;
    public bool H1;
    public bool H2;
    public bool H3;
    public GameObject food1;
    public GameObject food2;
    public GameObject food3;

    public GameObject cam2;

    public GameObject Next;
    public GameObject Passed;
    public GameObject NoConv;

    public GameObject PlusOne;

    public Transform[] point;
    public GameObject cam;



    private Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();

        q = Random.Range(1, 5);
        RandText.text = q.ToString();

        qq = Random.Range(1, 3);
        QText.text = qq.ToString();


        if(qq == 1)
        {
            H1 = true;
            food1.gameObject.SetActive(true);
        }
        if(qq == 2)
        {
            H2 = true;
            food2.gameObject.SetActive(true);
        }
        if(qq == 3)
        {
            H3 = true;
            food3.gameObject.SetActive(true);
        }




    }
    private void Update()
    {

        if (food == q)
        {
            anim.SetTrigger("Dance");
            Next.gameObject.SetActive(true);
            Passed.gameObject.SetActive(true);
            NoConv.gameObject.SetActive(false);
            cam.gameObject.SetActive(false);
            cam2.gameObject.SetActive(true);
        }

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bananas")
            if(H1 == true)
        {
            food++;
            UpFood.Play();
            CollectFood();
            other.gameObject.SetActive(false);
            TextFood.text = food.ToString();
            }
        if (other.gameObject.tag == "Apple")
            if(H2 == true)
        {
            food++;
            UpFood.Play();
            CollectFood();
            other.gameObject.SetActive(false);
            TextFood.text = food.ToString();
            }
        if (other.gameObject.tag == "Cherry")
            if(H3 == true)
        {
            food++;
            UpFood.Play();
            CollectFood();
            other.gameObject.SetActive(false);
            TextFood.text = food.ToString();
            }
    }

    private void CollectFood()
    {
        Instantiate(collfood, spawn.transform.position, Quaternion.identity);
    }
}

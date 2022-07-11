using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class StartGameCube : MonoBehaviour
{
    public GameObject StartCube;

    public GameObject front;
    public GameObject back;
    public GameObject right;
    public GameObject left;
    public GameObject up;
    public GameObject down;

    //public GameObject[] faces;
    //public Material Mats;
    public float a;

    // Start is called before the first frame update
    void Start()
    {
        //Mats = new Material[faces.Length];

        //for (float i = 0; i < faces.Length; i++)
        //{
        //    Mats[i] = faces[i].GetComponent<Renderer>.material;
        //}

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

            //for (float i = 0; i < faces.Length; i++)
            //{
            //    Fade();
            //    //faces[i].
            //}

            //Mats.DoFade(0f, 3f);
            Fade(up);
            Fade(down);
            Fade(left);
            Fade(right);
            Fade(front);
            Fade(back);
            
            
            //Starting(3);
        }

        if (Input.GetKeyDown(KeyCode.M))
        {
            up.SetActive(false);
            down.SetActive(false);
            front.SetActive(false);
            back.SetActive(false);
            right.SetActive(false);
            left.SetActive(false);
        }
    }

    void Fade(GameObject gameObject)
    {
        gameObject.GetComponent<MeshRenderer>().material.DOFade(0.0f, 3.0f);
        a++;
    }

    IEnumerator Starting(GameObject gameObject, float seconds)
    {
        yield return new WaitForSeconds(seconds);
        gameObject.SetActive(false);
    }
}

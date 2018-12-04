using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setmenu : MonoBehaviour {

    public GameObject Canvas;
    public GameObject Canvas_1;
    public GameObject Canvas_2;
    public GameObject Canvas_3;
    public GameObject whaiye;
    public GameObject daduo;
    public GameObject gsales;
    public GameObject peter;
    public GameObject wadas;
    public GameObject bingtiang;
    public GameObject whaduo;
    public GameObject putumans;
    public GameObject real;
    public GameObject rice;
    public GameObject dear;
    public GameObject cloth;
    public GameObject gold;
    public GameObject shield;
    public GameObject Al;
    public GameObject salt;
    public GameObject smoke;
    public GameObject S;
    public GameObject daduothing;
    public GameObject whaiyething;
    public GameObject maduothing;
    public GameObject bingtiangthing;


    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }

    public void gotocharactor() {
        Canvas.active = false;
        Canvas_1.active = true;
    }
    public void gotostuff()
    {
        Canvas.active = false;
        Canvas_2.active = true;
    }
    public void gotostory()
    {
        Canvas.active = false;
        Canvas_3.active = true;
    }
    public void returntomenu()
    {
        Canvas.active =true;
        Canvas_1.active =false;
        Canvas_2.active = false;
        Canvas_3.active = false;
    }
    public void gowhaiye()
    {
        Canvas_1.active = false;
        whaiye.active = true;
    }
    public void godaduo()
    {
        Canvas_1.active = false;
        daduo.active = true;
    }
    public void gogsales()
    {
        Canvas_1.active = false;
        gsales.active = true;
    }
    public void gopeter()
    {
        Canvas_1.active = false;
        peter.active = true;
    }
    public void gowadas()
    {
        Canvas_1.active = false;
        wadas.active = true;
    }
    public void gobingtiang()
    {
        Canvas_1.active = false;
        bingtiang.active = true;
    }
    public void gowhaduo()
    {
        Canvas_1.active = false;
        whaduo.active = true;
    }
    public void goputumans()
    {
        Canvas_1.active = false;
        putumans.active = true;
    }

    public void creturn()
    {
        Canvas_1.active = true;
        whaiye.active = false;
        daduo.active = false;
        gsales.active = false;
        peter.active = false;
        wadas.active = false;
        bingtiang.active = false;
        whaduo.active = false;
        putumans.active = false;
    }

    public void goreal()
    {
        Canvas_2.active = false;
        real.active = true;
    }
    public void gorice()
    {
        Canvas_2.active = false;
        rice.active = true;
    }
    public void godear()
    {
        Canvas_2.active = false;
        dear.active = true;
    }
    public void gocloth()
    {
        Canvas_2.active = false;
        cloth.active = true;
    }
    public void gogold()
    {
        Canvas_2.active = false;
        gold.active = true;
    }
    public void goshield()
    {
        Canvas_2.active = false;
        shield.active = true;
    }
    public void goAl()
    {
        Canvas_2.active = false;
        Al.active = true;
    }
    public void gosalt()
    {
        Canvas_2.active = false;
        salt.active = true;
    }
    public void gosmoke()
    {
        Canvas_2.active = false;
        smoke.active = true;
    }
    public void goS()
    {
        Canvas_2.active = false;
        S.active = true;
    }
    public void stuffreturn()
    {
        Canvas_2.active = true;
        real.active = false;
        rice.active = false;
        dear.active = false;
        cloth.active = false;
        gold.active = false;
        shield.active = false;
        Al.active = false;
        salt.active = false;
        smoke.active = false;
        S.active = false;
    }

    public void godaduothing()
    {
        Canvas_3.active = false;
        daduothing.active = true;
    }
    public void gowhaiyething()
    {
        Canvas_3.active = false;
        whaiyething.active = true;
    }
    public void gomaduothing()
    {
        Canvas_3.active = false;
        maduothing.active = true;
    }
    public void gobingtiangthing()
    {
        Canvas_3.active = false;
        bingtiangthing.active = true;
    }
    public void storyreturn()
    {
        Canvas_3.active = true;
        daduothing.active = false;
        whaiyething.active = false;
        maduothing.active = false;
        bingtiangthing.active = false;
    }
}

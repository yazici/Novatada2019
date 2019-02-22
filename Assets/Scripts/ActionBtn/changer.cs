﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class changer : MonoBehaviour
{
    public Button ActionButton;

    // Las imagenes se ingresan desde la interfaz de unity
    public Sprite btnInteract;
    public Sprite btnAttack;
    public Sprite btnPassive;
    
    private static bool btnChange = false;
    private static string tag = null;

    private void Start()
    {
        ActionButton = GetComponent<Button>();
    }

    private void Update()
    {
        // Cambia la imagen del boton de acuerdo al booleano btnChange y
        // el tag que se ingresa con el metodo setTag
        ChangeButton();
    }

    public void ChangeButton() {
        if (btnChange)
        {
            if (tag.Equals("Dialog"))
                ActionButton.image.overrideSprite = btnInteract;
            else if (tag.Equals("Destroy"))
                ActionButton.image.overrideSprite = btnAttack;
        }
        else {
            ActionButton.image.overrideSprite = btnPassive;
        }
    }

    public static void changeActionBtn(bool boolean)
    {
        btnChange = boolean;
    }

    public static void setTag(string Tag) {
        tag = Tag;
    }

}

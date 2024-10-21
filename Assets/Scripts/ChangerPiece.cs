using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangerPiece : MonoBehaviour
{
    public RawImage imageDisplay; 
    public Texture textureCuisine;  
    public Texture textureSalleAManger; 
    public Texture textureSalon; 

    public void ChangerEnCuisine()
    {
        imageDisplay.texture = textureCuisine;
    }

    public void ChangerEnSalleAManger()
    {
        imageDisplay.texture = textureSalleAManger;
    }

    public void ChangerEnSalon()
    {
        imageDisplay.texture = textureSalon;
    }
}

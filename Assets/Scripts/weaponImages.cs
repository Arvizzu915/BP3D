using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class weaponImages : MonoBehaviour
{
    [SerializeField] Player player;
    [SerializeField] int weaponIndex;
    [SerializeField] Image image;

    private void Update()
    {
        if(weaponIndex == 1 && player.katana)
        {
            if (weaponIndex == player.selectedWeapon)
            {
                var tempColor = image.color;
                tempColor.a = 1f;
                image.color = tempColor;
            }
            else
            {
                var tempColor = image.color;
                tempColor.a = .3f;
                image.color = tempColor;
            }
        }
        else if(weaponIndex == 1)
        {
            var tempColor = image.color;
            tempColor.a = 0f;
            image.color = tempColor;
        }

        if (weaponIndex == 2 && player.bazooka)
        {
            if (weaponIndex == player.selectedWeapon)
            {
                var tempColor = image.color;
                tempColor.a = 1f;
                image.color = tempColor;
            }
            else
            {
                var tempColor = image.color;
                tempColor.a = .3f;
                image.color = tempColor;
            }
        }
        else if(weaponIndex == 2)
        {
            var tempColor = image.color;
            tempColor.a = 0f;
            image.color = tempColor;
        }

        if (weaponIndex == 0)
        {
            if (weaponIndex == player.selectedWeapon)
            {
                var tempColor = image.color;
                tempColor.a = 1f;
                image.color = tempColor;
            }
            else
            {
                var tempColor = image.color;
                tempColor.a = .3f;
                image.color = tempColor;
            }
        }
    }
}

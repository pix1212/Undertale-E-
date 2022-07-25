using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogManager : MonoBehaviour
{
   public GameObject dialog;
   public Text descriptionText;


   public void SetActiveDialog(bool active)
   {
        dialog.SetActive(active);
   }

   public void SetDialogContent(string desc)
   {
        descriptionText.text = desc;
   }
}

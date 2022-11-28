using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SettingsMenu : MonoBehaviour
{
   public AudioMixer mainMixer;

   public void setQuality(int qualityindex)
   {
       QualitySettings.SetQualityLevel(qualityindex);
   }
   public void setVolume(float volume)
   {
       mainMixer.SetFloat("volume", volume);
   }
}

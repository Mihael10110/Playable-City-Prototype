using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class effectsSounder : MonoBehaviour
{
    public AudioSource source;
    public AudioClip game1;
    public AudioClip game2;
    public AudioClip game3;
    public AudioClip game4;
    public AudioClip game5;
    public AudioClip game6;
    public AudioClip music1;
    public AudioClip music2;
    public AudioClip music3;
    public AudioClip music4;
    public AudioClip music5;
    public AudioClip music6;
    public AudioClip mech1;
    public AudioClip mech2;
    public AudioClip mech3;
    public AudioClip mech4;
    public AudioClip mech5;
    public AudioClip mech6;
    
    public void pgame1(){
        source.PlayOneShot(game1);
    }
    public void pgame2(){
        source.PlayOneShot(game2);
    }
    public void pgame3(){
        source.PlayOneShot(game3);
    }
    public void pgame4(){
        source.PlayOneShot(game4);
    }
    public void pgame5(){
        source.PlayOneShot(game5);
    }
    public void pgame6(){
        source.PlayOneShot(game6);
    }
    public void pmusic1(){
        source.PlayOneShot(music1);
    }
    public void pmusic2(){
        source.PlayOneShot(music2);
    }
    public void pmusic3(){
        source.PlayOneShot(music3);
    }
    public void pmusic4(){
        source.PlayOneShot(music4);
    }
    public void pmusic5(){
        source.PlayOneShot(music5);
    }
    public void pmusic6(){
        source.PlayOneShot(music6);
    }
    public void pmech1(){
        source.PlayOneShot(mech1);
    }
    public void pmech2(){
        source.PlayOneShot(mech2);
    }
    public void pmech3(){
        source.PlayOneShot(mech3);
    }
    public void pmech4(){
        source.PlayOneShot(mech4);
    }
    public void pmech5(){
        source.PlayOneShot(mech5);
    }
    public void pmech6(){
        source.PlayOneShot(mech6);
    }
    
    
}

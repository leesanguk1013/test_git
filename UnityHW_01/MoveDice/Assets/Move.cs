using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Move : MonoBehaviour
{
    AudioSource BackMusic;
    public Slider VolValue;
    public GameObject Player;
    public GameObject SoundSourceMan;
    public RawImage Background_Onoff;
    public bool BackOnoff = false;
    public static int Direction_switcher = 0;
    // Start is called before the first frame update
    void Start()
    {
        BackMusic = SoundSourceMan.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

        Background_Onoff.enabled = BackOnoff;
    }

    public void AudioSourceControll() {
        BackMusic.volume = VolValue.value;
    }

    public void BackGrounds()
    {
       if( BackOnoff == true)
            {
            BackOnoff = false;
        }
        else if (BackOnoff == false)
        {
            BackOnoff = true;
        }
    }

        public void MoveCube()
    {
        if (Direction_switcher == 0) {
            Player.transform.Translate(0, 0, 2.45f);
        }
        else if (Direction_switcher == 1)
        {

            Player.transform.Translate(2.45f, 0,0 );
        }
        else if (Direction_switcher == 2)
        {
            Player.transform.Translate(0, 0, -2.45f);

        }
        else if (Direction_switcher == 3)
        {

            Player.transform.Translate(-2.45f, 0, 0);
        }
    }
}

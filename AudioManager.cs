using UnityEngine;

/* Simple single script handler for sound effects. All that's needed is to 
 * place sound files into the Resources folder of the project. Create a variable
 * to store x sound file. Then add a switch case for it, so it can be found when
 * the sound effect needs to be played. Prevents having to store individual sound effects
 * in the corresponding script that needs them.
 */

public class AudioManager : MonoBehaviour
{
    // Sound file variables
    private AudioClip walkSound, shurikenThrow, cannonFire, jumpSound;

    private AudioSource audioSource;

    // Initialize all sound files to appropriate member variables
    void Awake()
    {
        walkSound = Resources.Load<AudioClip>("WalkingSound");
        shurikenThrow = Resources.Load<AudioClip>("ShurikenThrow");
        cannonFire = Resources.Load<AudioClip>("CannonFire");
        jumpSound = Resources.Load<AudioClip>("JumpSound");
        audioSource = GetComponent<AudioSource>();
    }

    // Called when a certain sound is needed. Plays that sound file once.
    public void PlaySound(string name)
    {
        switch (name)
        {
            case "walkSound":
                audioSource.PlayOneShot(walkSound);
                break;
            case "shurikenThrow":
                audioSource.PlayOneShot(shurikenThrow);
                break;
            case "cannonFire":
                audioSource.PlayOneShot(cannonFire);
                break;
            case "jumpSound":
                audioSource.PlayOneShot(jumpSound);
                break;
        }
    }

    // Stops sounds from playing if multiple sound effects need to go off
    // and it becomes too polluted or certain background music/dialogue needs to be
    // heard
    public void StopSound()
    {
        audioSource.Stop();
    }
}

using UnityEngine;

public class Dooropen : MonoBehaviour
{
    private Animator anime;
    void Start()
    {
        anime = GetComponent<Animator>();
    }

    private void OnTiggerEnter(Collider other)
    {
        anime.SetTrigger("Open");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// 用于场景淡入淡出
public class SceneLoader : MonoBehaviour
{
    public static SceneLoader Instance
    {
        get; set;
    }
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public IEnumerator LoadScene(string name)
    {
        animator = GameObject.Find("Mask Image").GetComponent<Animator>();
        animator.SetBool("FadeIn", false);
        animator.SetBool("FadeOut", true);
        AsyncOperation async = SceneManager.LoadSceneAsync(name);
        async.allowSceneActivation = false;
        yield return new WaitForSeconds(2f);
        async.allowSceneActivation = true;
        async.completed += OnLoadedScene;
    }
    private void OnLoadedScene(AsyncOperation async)
    {
        animator = GameObject.Find("Mask Image").GetComponent<Animator>();
        animator.SetBool("FadeOut", false);
        animator.SetBool("FadeIn", true);
        StopAllCoroutines();
    }
    public Animator animator;
}

using MelonLoader;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace ReRunRetry
{
    public class Main : MelonMod
    {

		public override void OnUpdate()
		{
			if(Input.GetKeyDown(KeyCode.R))
			{
				SceneManager.LoadScene(SceneManager.GetActiveScene().name);
			}
		}

	}
}

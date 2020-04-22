using UnityEngine;

using AppFw.Core;

namespace slide.Core
{
    /// <summary>
    /// 入力周りのマネージャ.
    /// </summary>
    public class InputManager : RuntimeManagerBase
    {

        void Awake()
        {
            ManagerProvider.RegisterRuntimeManager(this);
        }
        
  
        void Update()
        {
            OnEscapeApplication();
        }

        
        void OnEscapeApplication()
        {
            // TODO : これでは不完全,そのうちいい感じに仮想キーを導入する.
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                Application.Quit();
            }
        }
    }
}


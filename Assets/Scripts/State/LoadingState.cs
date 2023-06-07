using UnityEngine;
using Arbor;
using Cysharp.Threading.Tasks;
using UnityEngine.AddressableAssets;

[AddComponentMenu("")]
public class LoadingState : StateBehaviour
{

    public StateLink _nextState;
    private bool _loadCompleted = false;

    // Use this for awake state
    public override async void OnStateAwake()
    {
        await UniTask.WhenAll(LoadCharacterDataAsync("CharacterData"), LoadDeckDataAsync("DeckData"));
        Debug.Log("LoadCompleted");
        _loadCompleted = true;
    }

    // Use this for enter state
    public override void OnStateBegin()
    {
    }

    // Use this for exit state
    public override void OnStateEnd()
    {
    }

    // OnStateUpdate is called once per frame
    public override void OnStateUpdate()
    {
        /*
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Transition(_nextState);
        }
        */
        if (_loadCompleted)
        {
            Transition(_nextState);
        }
    }

    // OnStateLateUpdate is called once per frame, after Update has finished.
    public override void OnStateLateUpdate()
    {

    }

    private async UniTask LoadCharacterDataAsync(string label)
    {
        var ret = await Addressables.LoadAssetsAsync<CharacterData>(label, (loadData) =>
        {
            Debug.Log(loadData);
        });
    }

    private async UniTask LoadDeckDataAsync(string label)
    {
        var ret = await Addressables.LoadAssetsAsync<DeckData>(label, (loadData) =>
        {
            Debug.Log(loadData);
        });
    }
}

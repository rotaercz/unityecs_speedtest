//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsShmid.C34Component ecsShmidC34 { get { return (EcsShmid.C34Component)GetComponent(GameComponentsLookup.EcsShmidC34); } }
    public bool hasEcsShmidC34 { get { return HasComponent(GameComponentsLookup.EcsShmidC34); } }

    public void AddEcsShmidC34(int newField0, int newField1) {
        var index = GameComponentsLookup.EcsShmidC34;
        var component = CreateComponent<EcsShmid.C34Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsShmidC34(int newField0, int newField1) {
        var index = GameComponentsLookup.EcsShmidC34;
        var component = CreateComponent<EcsShmid.C34Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsShmidC34() {
        RemoveComponent(GameComponentsLookup.EcsShmidC34);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherEcsShmidC34;

    public static Entitas.IMatcher<GameEntity> EcsShmidC34 {
        get {
            if (_matcherEcsShmidC34 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsShmidC34);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsShmidC34 = matcher;
            }

            return _matcherEcsShmidC34;
        }
    }
}
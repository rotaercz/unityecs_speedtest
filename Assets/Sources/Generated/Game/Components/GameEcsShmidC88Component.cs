//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsShmid.C88Component ecsShmidC88 { get { return (EcsShmid.C88Component)GetComponent(GameComponentsLookup.EcsShmidC88); } }
    public bool hasEcsShmidC88 { get { return HasComponent(GameComponentsLookup.EcsShmidC88); } }

    public void AddEcsShmidC88(long newField0, int newField1) {
        var index = GameComponentsLookup.EcsShmidC88;
        var component = CreateComponent<EcsShmid.C88Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsShmidC88(long newField0, int newField1) {
        var index = GameComponentsLookup.EcsShmidC88;
        var component = CreateComponent<EcsShmid.C88Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsShmidC88() {
        RemoveComponent(GameComponentsLookup.EcsShmidC88);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsShmidC88;

    public static Entitas.IMatcher<GameEntity> EcsShmidC88 {
        get {
            if (_matcherEcsShmidC88 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsShmidC88);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsShmidC88 = matcher;
            }

            return _matcherEcsShmidC88;
        }
    }
}
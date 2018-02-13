//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsShmid.C93Component ecsShmidC93 { get { return (EcsShmid.C93Component)GetComponent(GameComponentsLookup.EcsShmidC93); } }
    public bool hasEcsShmidC93 { get { return HasComponent(GameComponentsLookup.EcsShmidC93); } }

    public void AddEcsShmidC93(float newField0, float newField1) {
        var index = GameComponentsLookup.EcsShmidC93;
        var component = CreateComponent<EcsShmid.C93Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsShmidC93(float newField0, float newField1) {
        var index = GameComponentsLookup.EcsShmidC93;
        var component = CreateComponent<EcsShmid.C93Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsShmidC93() {
        RemoveComponent(GameComponentsLookup.EcsShmidC93);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsShmidC93;

    public static Entitas.IMatcher<GameEntity> EcsShmidC93 {
        get {
            if (_matcherEcsShmidC93 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsShmidC93);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsShmidC93 = matcher;
            }

            return _matcherEcsShmidC93;
        }
    }
}
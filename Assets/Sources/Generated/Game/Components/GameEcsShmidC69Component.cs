//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsShmid.C69Component ecsShmidC69 { get { return (EcsShmid.C69Component)GetComponent(GameComponentsLookup.EcsShmidC69); } }
    public bool hasEcsShmidC69 { get { return HasComponent(GameComponentsLookup.EcsShmidC69); } }

    public void AddEcsShmidC69(float newField0, int newField1) {
        var index = GameComponentsLookup.EcsShmidC69;
        var component = CreateComponent<EcsShmid.C69Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsShmidC69(float newField0, int newField1) {
        var index = GameComponentsLookup.EcsShmidC69;
        var component = CreateComponent<EcsShmid.C69Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsShmidC69() {
        RemoveComponent(GameComponentsLookup.EcsShmidC69);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsShmidC69;

    public static Entitas.IMatcher<GameEntity> EcsShmidC69 {
        get {
            if (_matcherEcsShmidC69 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsShmidC69);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsShmidC69 = matcher;
            }

            return _matcherEcsShmidC69;
        }
    }
}
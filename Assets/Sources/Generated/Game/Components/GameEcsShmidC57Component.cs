//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsShmid.C57Component ecsShmidC57 { get { return (EcsShmid.C57Component)GetComponent(GameComponentsLookup.EcsShmidC57); } }
    public bool hasEcsShmidC57 { get { return HasComponent(GameComponentsLookup.EcsShmidC57); } }

    public void AddEcsShmidC57(float newField0, float newField1) {
        var index = GameComponentsLookup.EcsShmidC57;
        var component = CreateComponent<EcsShmid.C57Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsShmidC57(float newField0, float newField1) {
        var index = GameComponentsLookup.EcsShmidC57;
        var component = CreateComponent<EcsShmid.C57Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsShmidC57() {
        RemoveComponent(GameComponentsLookup.EcsShmidC57);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsShmidC57;

    public static Entitas.IMatcher<GameEntity> EcsShmidC57 {
        get {
            if (_matcherEcsShmidC57 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsShmidC57);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsShmidC57 = matcher;
            }

            return _matcherEcsShmidC57;
        }
    }
}
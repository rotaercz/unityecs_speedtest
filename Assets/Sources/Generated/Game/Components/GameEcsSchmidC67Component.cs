//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsSchmid.C67Component ecsSchmidC67 { get { return (EcsSchmid.C67Component)GetComponent(GameComponentsLookup.EcsSchmidC67); } }
    public bool hasEcsSchmidC67 { get { return HasComponent(GameComponentsLookup.EcsSchmidC67); } }

    public void AddEcsSchmidC67(float newField0, float newField1) {
        var index = GameComponentsLookup.EcsSchmidC67;
        var component = CreateComponent<EcsSchmid.C67Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsSchmidC67(float newField0, float newField1) {
        var index = GameComponentsLookup.EcsSchmidC67;
        var component = CreateComponent<EcsSchmid.C67Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsSchmidC67() {
        RemoveComponent(GameComponentsLookup.EcsSchmidC67);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsSchmidC67;

    public static Entitas.IMatcher<GameEntity> EcsSchmidC67 {
        get {
            if (_matcherEcsSchmidC67 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsSchmidC67);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsSchmidC67 = matcher;
            }

            return _matcherEcsSchmidC67;
        }
    }
}

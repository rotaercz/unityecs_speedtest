//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsSchmid.C21Component ecsSchmidC21 { get { return (EcsSchmid.C21Component)GetComponent(GameComponentsLookup.EcsSchmidC21); } }
    public bool hasEcsSchmidC21 { get { return HasComponent(GameComponentsLookup.EcsSchmidC21); } }

    public void AddEcsSchmidC21(float newField0, float newField1) {
        var index = GameComponentsLookup.EcsSchmidC21;
        var component = CreateComponent<EcsSchmid.C21Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsSchmidC21(float newField0, float newField1) {
        var index = GameComponentsLookup.EcsSchmidC21;
        var component = CreateComponent<EcsSchmid.C21Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsSchmidC21() {
        RemoveComponent(GameComponentsLookup.EcsSchmidC21);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsSchmidC21;

    public static Entitas.IMatcher<GameEntity> EcsSchmidC21 {
        get {
            if (_matcherEcsSchmidC21 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsSchmidC21);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsSchmidC21 = matcher;
            }

            return _matcherEcsSchmidC21;
        }
    }
}

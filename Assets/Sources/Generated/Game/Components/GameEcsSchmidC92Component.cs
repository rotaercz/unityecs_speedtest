//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsSchmid.C92Component ecsSchmidC92 { get { return (EcsSchmid.C92Component)GetComponent(GameComponentsLookup.EcsSchmidC92); } }
    public bool hasEcsSchmidC92 { get { return HasComponent(GameComponentsLookup.EcsSchmidC92); } }

    public void AddEcsSchmidC92(long newField0, float newField1) {
        var index = GameComponentsLookup.EcsSchmidC92;
        var component = CreateComponent<EcsSchmid.C92Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsSchmidC92(long newField0, float newField1) {
        var index = GameComponentsLookup.EcsSchmidC92;
        var component = CreateComponent<EcsSchmid.C92Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsSchmidC92() {
        RemoveComponent(GameComponentsLookup.EcsSchmidC92);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsSchmidC92;

    public static Entitas.IMatcher<GameEntity> EcsSchmidC92 {
        get {
            if (_matcherEcsSchmidC92 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsSchmidC92);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsSchmidC92 = matcher;
            }

            return _matcherEcsSchmidC92;
        }
    }
}

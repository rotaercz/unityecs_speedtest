//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsSchmid.C22Component ecsSchmidC22 { get { return (EcsSchmid.C22Component)GetComponent(GameComponentsLookup.EcsSchmidC22); } }
    public bool hasEcsSchmidC22 { get { return HasComponent(GameComponentsLookup.EcsSchmidC22); } }

    public void AddEcsSchmidC22(int newField0, long newField1) {
        var index = GameComponentsLookup.EcsSchmidC22;
        var component = CreateComponent<EcsSchmid.C22Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsSchmidC22(int newField0, long newField1) {
        var index = GameComponentsLookup.EcsSchmidC22;
        var component = CreateComponent<EcsSchmid.C22Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsSchmidC22() {
        RemoveComponent(GameComponentsLookup.EcsSchmidC22);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsSchmidC22;

    public static Entitas.IMatcher<GameEntity> EcsSchmidC22 {
        get {
            if (_matcherEcsSchmidC22 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsSchmidC22);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsSchmidC22 = matcher;
            }

            return _matcherEcsSchmidC22;
        }
    }
}

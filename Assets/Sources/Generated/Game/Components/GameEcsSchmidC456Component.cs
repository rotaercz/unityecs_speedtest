//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsSchmid.C456Component ecsSchmidC456 { get { return (EcsSchmid.C456Component)GetComponent(GameComponentsLookup.EcsSchmidC456); } }
    public bool hasEcsSchmidC456 { get { return HasComponent(GameComponentsLookup.EcsSchmidC456); } }

    public void AddEcsSchmidC456(int newField0, float newField1) {
        var index = GameComponentsLookup.EcsSchmidC456;
        var component = CreateComponent<EcsSchmid.C456Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsSchmidC456(int newField0, float newField1) {
        var index = GameComponentsLookup.EcsSchmidC456;
        var component = CreateComponent<EcsSchmid.C456Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsSchmidC456() {
        RemoveComponent(GameComponentsLookup.EcsSchmidC456);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsSchmidC456;

    public static Entitas.IMatcher<GameEntity> EcsSchmidC456 {
        get {
            if (_matcherEcsSchmidC456 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsSchmidC456);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsSchmidC456 = matcher;
            }

            return _matcherEcsSchmidC456;
        }
    }
}
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsSchmid.C247Component ecsSchmidC247 { get { return (EcsSchmid.C247Component)GetComponent(GameComponentsLookup.EcsSchmidC247); } }
    public bool hasEcsSchmidC247 { get { return HasComponent(GameComponentsLookup.EcsSchmidC247); } }

    public void AddEcsSchmidC247(int newField0, int newField1) {
        var index = GameComponentsLookup.EcsSchmidC247;
        var component = CreateComponent<EcsSchmid.C247Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsSchmidC247(int newField0, int newField1) {
        var index = GameComponentsLookup.EcsSchmidC247;
        var component = CreateComponent<EcsSchmid.C247Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsSchmidC247() {
        RemoveComponent(GameComponentsLookup.EcsSchmidC247);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsSchmidC247;

    public static Entitas.IMatcher<GameEntity> EcsSchmidC247 {
        get {
            if (_matcherEcsSchmidC247 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsSchmidC247);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsSchmidC247 = matcher;
            }

            return _matcherEcsSchmidC247;
        }
    }
}
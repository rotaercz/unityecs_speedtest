//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsSchmid.C310Component ecsSchmidC310 { get { return (EcsSchmid.C310Component)GetComponent(GameComponentsLookup.EcsSchmidC310); } }
    public bool hasEcsSchmidC310 { get { return HasComponent(GameComponentsLookup.EcsSchmidC310); } }

    public void AddEcsSchmidC310(int newField0, float newField1) {
        var index = GameComponentsLookup.EcsSchmidC310;
        var component = CreateComponent<EcsSchmid.C310Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsSchmidC310(int newField0, float newField1) {
        var index = GameComponentsLookup.EcsSchmidC310;
        var component = CreateComponent<EcsSchmid.C310Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsSchmidC310() {
        RemoveComponent(GameComponentsLookup.EcsSchmidC310);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsSchmidC310;

    public static Entitas.IMatcher<GameEntity> EcsSchmidC310 {
        get {
            if (_matcherEcsSchmidC310 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsSchmidC310);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsSchmidC310 = matcher;
            }

            return _matcherEcsSchmidC310;
        }
    }
}
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsSchmid.C95Component ecsSchmidC95 { get { return (EcsSchmid.C95Component)GetComponent(GameComponentsLookup.EcsSchmidC95); } }
    public bool hasEcsSchmidC95 { get { return HasComponent(GameComponentsLookup.EcsSchmidC95); } }

    public void AddEcsSchmidC95(long newField0, long newField1) {
        var index = GameComponentsLookup.EcsSchmidC95;
        var component = CreateComponent<EcsSchmid.C95Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsSchmidC95(long newField0, long newField1) {
        var index = GameComponentsLookup.EcsSchmidC95;
        var component = CreateComponent<EcsSchmid.C95Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsSchmidC95() {
        RemoveComponent(GameComponentsLookup.EcsSchmidC95);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsSchmidC95;

    public static Entitas.IMatcher<GameEntity> EcsSchmidC95 {
        get {
            if (_matcherEcsSchmidC95 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsSchmidC95);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsSchmidC95 = matcher;
            }

            return _matcherEcsSchmidC95;
        }
    }
}

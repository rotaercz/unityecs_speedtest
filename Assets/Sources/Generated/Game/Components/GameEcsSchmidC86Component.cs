//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsSchmid.C86Component ecsSchmidC86 { get { return (EcsSchmid.C86Component)GetComponent(GameComponentsLookup.EcsSchmidC86); } }
    public bool hasEcsSchmidC86 { get { return HasComponent(GameComponentsLookup.EcsSchmidC86); } }

    public void AddEcsSchmidC86(float newField0, int newField1) {
        var index = GameComponentsLookup.EcsSchmidC86;
        var component = CreateComponent<EcsSchmid.C86Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsSchmidC86(float newField0, int newField1) {
        var index = GameComponentsLookup.EcsSchmidC86;
        var component = CreateComponent<EcsSchmid.C86Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsSchmidC86() {
        RemoveComponent(GameComponentsLookup.EcsSchmidC86);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsSchmidC86;

    public static Entitas.IMatcher<GameEntity> EcsSchmidC86 {
        get {
            if (_matcherEcsSchmidC86 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsSchmidC86);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsSchmidC86 = matcher;
            }

            return _matcherEcsSchmidC86;
        }
    }
}

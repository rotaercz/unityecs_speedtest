//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsSchmid.C64Component ecsSchmidC64 { get { return (EcsSchmid.C64Component)GetComponent(GameComponentsLookup.EcsSchmidC64); } }
    public bool hasEcsSchmidC64 { get { return HasComponent(GameComponentsLookup.EcsSchmidC64); } }

    public void AddEcsSchmidC64(float newField0, long newField1) {
        var index = GameComponentsLookup.EcsSchmidC64;
        var component = CreateComponent<EcsSchmid.C64Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsSchmidC64(float newField0, long newField1) {
        var index = GameComponentsLookup.EcsSchmidC64;
        var component = CreateComponent<EcsSchmid.C64Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsSchmidC64() {
        RemoveComponent(GameComponentsLookup.EcsSchmidC64);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsSchmidC64;

    public static Entitas.IMatcher<GameEntity> EcsSchmidC64 {
        get {
            if (_matcherEcsSchmidC64 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsSchmidC64);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsSchmidC64 = matcher;
            }

            return _matcherEcsSchmidC64;
        }
    }
}

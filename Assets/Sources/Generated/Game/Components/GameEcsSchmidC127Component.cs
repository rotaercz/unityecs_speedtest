//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsSchmid.C127Component ecsSchmidC127 { get { return (EcsSchmid.C127Component)GetComponent(GameComponentsLookup.EcsSchmidC127); } }
    public bool hasEcsSchmidC127 { get { return HasComponent(GameComponentsLookup.EcsSchmidC127); } }

    public void AddEcsSchmidC127(long newField0, long newField1) {
        var index = GameComponentsLookup.EcsSchmidC127;
        var component = CreateComponent<EcsSchmid.C127Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsSchmidC127(long newField0, long newField1) {
        var index = GameComponentsLookup.EcsSchmidC127;
        var component = CreateComponent<EcsSchmid.C127Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsSchmidC127() {
        RemoveComponent(GameComponentsLookup.EcsSchmidC127);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsSchmidC127;

    public static Entitas.IMatcher<GameEntity> EcsSchmidC127 {
        get {
            if (_matcherEcsSchmidC127 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsSchmidC127);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsSchmidC127 = matcher;
            }

            return _matcherEcsSchmidC127;
        }
    }
}
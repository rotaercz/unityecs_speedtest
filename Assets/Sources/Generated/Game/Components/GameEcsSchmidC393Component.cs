//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsSchmid.C393Component ecsSchmidC393 { get { return (EcsSchmid.C393Component)GetComponent(GameComponentsLookup.EcsSchmidC393); } }
    public bool hasEcsSchmidC393 { get { return HasComponent(GameComponentsLookup.EcsSchmidC393); } }

    public void AddEcsSchmidC393(int newField0, float newField1) {
        var index = GameComponentsLookup.EcsSchmidC393;
        var component = CreateComponent<EcsSchmid.C393Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsSchmidC393(int newField0, float newField1) {
        var index = GameComponentsLookup.EcsSchmidC393;
        var component = CreateComponent<EcsSchmid.C393Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsSchmidC393() {
        RemoveComponent(GameComponentsLookup.EcsSchmidC393);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsSchmidC393;

    public static Entitas.IMatcher<GameEntity> EcsSchmidC393 {
        get {
            if (_matcherEcsSchmidC393 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsSchmidC393);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsSchmidC393 = matcher;
            }

            return _matcherEcsSchmidC393;
        }
    }
}
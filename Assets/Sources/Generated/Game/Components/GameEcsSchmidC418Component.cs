//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsSchmid.C418Component ecsSchmidC418 { get { return (EcsSchmid.C418Component)GetComponent(GameComponentsLookup.EcsSchmidC418); } }
    public bool hasEcsSchmidC418 { get { return HasComponent(GameComponentsLookup.EcsSchmidC418); } }

    public void AddEcsSchmidC418(long newField0, int newField1) {
        var index = GameComponentsLookup.EcsSchmidC418;
        var component = CreateComponent<EcsSchmid.C418Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsSchmidC418(long newField0, int newField1) {
        var index = GameComponentsLookup.EcsSchmidC418;
        var component = CreateComponent<EcsSchmid.C418Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsSchmidC418() {
        RemoveComponent(GameComponentsLookup.EcsSchmidC418);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsSchmidC418;

    public static Entitas.IMatcher<GameEntity> EcsSchmidC418 {
        get {
            if (_matcherEcsSchmidC418 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsSchmidC418);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsSchmidC418 = matcher;
            }

            return _matcherEcsSchmidC418;
        }
    }
}
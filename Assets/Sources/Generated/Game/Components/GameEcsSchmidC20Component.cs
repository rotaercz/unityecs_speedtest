//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsSchmid.C20Component ecsSchmidC20 { get { return (EcsSchmid.C20Component)GetComponent(GameComponentsLookup.EcsSchmidC20); } }
    public bool hasEcsSchmidC20 { get { return HasComponent(GameComponentsLookup.EcsSchmidC20); } }

    public void AddEcsSchmidC20(long newField0, int newField1) {
        var index = GameComponentsLookup.EcsSchmidC20;
        var component = CreateComponent<EcsSchmid.C20Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsSchmidC20(long newField0, int newField1) {
        var index = GameComponentsLookup.EcsSchmidC20;
        var component = CreateComponent<EcsSchmid.C20Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsSchmidC20() {
        RemoveComponent(GameComponentsLookup.EcsSchmidC20);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsSchmidC20;

    public static Entitas.IMatcher<GameEntity> EcsSchmidC20 {
        get {
            if (_matcherEcsSchmidC20 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsSchmidC20);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsSchmidC20 = matcher;
            }

            return _matcherEcsSchmidC20;
        }
    }
}
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsSchmid.C12Component ecsSchmidC12 { get { return (EcsSchmid.C12Component)GetComponent(GameComponentsLookup.EcsSchmidC12); } }
    public bool hasEcsSchmidC12 { get { return HasComponent(GameComponentsLookup.EcsSchmidC12); } }

    public void AddEcsSchmidC12(int newField0, int newField1) {
        var index = GameComponentsLookup.EcsSchmidC12;
        var component = CreateComponent<EcsSchmid.C12Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsSchmidC12(int newField0, int newField1) {
        var index = GameComponentsLookup.EcsSchmidC12;
        var component = CreateComponent<EcsSchmid.C12Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsSchmidC12() {
        RemoveComponent(GameComponentsLookup.EcsSchmidC12);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsSchmidC12;

    public static Entitas.IMatcher<GameEntity> EcsSchmidC12 {
        get {
            if (_matcherEcsSchmidC12 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsSchmidC12);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsSchmidC12 = matcher;
            }

            return _matcherEcsSchmidC12;
        }
    }
}

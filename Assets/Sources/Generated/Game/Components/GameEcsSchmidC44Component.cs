//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsSchmid.C44Component ecsSchmidC44 { get { return (EcsSchmid.C44Component)GetComponent(GameComponentsLookup.EcsSchmidC44); } }
    public bool hasEcsSchmidC44 { get { return HasComponent(GameComponentsLookup.EcsSchmidC44); } }

    public void AddEcsSchmidC44(long newField0, int newField1) {
        var index = GameComponentsLookup.EcsSchmidC44;
        var component = CreateComponent<EcsSchmid.C44Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsSchmidC44(long newField0, int newField1) {
        var index = GameComponentsLookup.EcsSchmidC44;
        var component = CreateComponent<EcsSchmid.C44Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsSchmidC44() {
        RemoveComponent(GameComponentsLookup.EcsSchmidC44);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsSchmidC44;

    public static Entitas.IMatcher<GameEntity> EcsSchmidC44 {
        get {
            if (_matcherEcsSchmidC44 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsSchmidC44);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsSchmidC44 = matcher;
            }

            return _matcherEcsSchmidC44;
        }
    }
}

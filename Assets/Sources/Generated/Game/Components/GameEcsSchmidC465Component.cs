//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsSchmid.C465Component ecsSchmidC465 { get { return (EcsSchmid.C465Component)GetComponent(GameComponentsLookup.EcsSchmidC465); } }
    public bool hasEcsSchmidC465 { get { return HasComponent(GameComponentsLookup.EcsSchmidC465); } }

    public void AddEcsSchmidC465(float newField0, long newField1) {
        var index = GameComponentsLookup.EcsSchmidC465;
        var component = CreateComponent<EcsSchmid.C465Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsSchmidC465(float newField0, long newField1) {
        var index = GameComponentsLookup.EcsSchmidC465;
        var component = CreateComponent<EcsSchmid.C465Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsSchmidC465() {
        RemoveComponent(GameComponentsLookup.EcsSchmidC465);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsSchmidC465;

    public static Entitas.IMatcher<GameEntity> EcsSchmidC465 {
        get {
            if (_matcherEcsSchmidC465 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsSchmidC465);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsSchmidC465 = matcher;
            }

            return _matcherEcsSchmidC465;
        }
    }
}
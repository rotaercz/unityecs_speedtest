//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsSchmid.C328Component ecsSchmidC328 { get { return (EcsSchmid.C328Component)GetComponent(GameComponentsLookup.EcsSchmidC328); } }
    public bool hasEcsSchmidC328 { get { return HasComponent(GameComponentsLookup.EcsSchmidC328); } }

    public void AddEcsSchmidC328(float newField0, long newField1) {
        var index = GameComponentsLookup.EcsSchmidC328;
        var component = CreateComponent<EcsSchmid.C328Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsSchmidC328(float newField0, long newField1) {
        var index = GameComponentsLookup.EcsSchmidC328;
        var component = CreateComponent<EcsSchmid.C328Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsSchmidC328() {
        RemoveComponent(GameComponentsLookup.EcsSchmidC328);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsSchmidC328;

    public static Entitas.IMatcher<GameEntity> EcsSchmidC328 {
        get {
            if (_matcherEcsSchmidC328 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsSchmidC328);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsSchmidC328 = matcher;
            }

            return _matcherEcsSchmidC328;
        }
    }
}
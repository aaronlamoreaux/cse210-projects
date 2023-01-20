using Unit06.Game.Casting;


namespace Unit06.Game.Scripting {
    public interface Action{
        void Execute(Cast cast, Script script);
    }
}
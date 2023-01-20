using System.Collections.Generic;
using Raylib_cs;
using Unit06.Game.Casting;


namespace Unit06.Game.Services
{
    /// <summary>
    /// <para>Detects player input.</para>
    /// <para>
    /// The responsibility of a KeyboardService is to indicate whether or not a key is up or down.
    /// </para>
    /// </summary>
    public class KeyboardService
    {
        private Dictionary<string, KeyboardKey> _keys = new Dictionary<string, KeyboardKey>();
        public KeyboardService()
        {
            _keys["w"] = KeyboardKey.KEY_W;
            _keys["a"] = KeyboardKey.KEY_A;
            _keys["s"] = KeyboardKey.KEY_S;
            _keys["d"] = KeyboardKey.KEY_D;
        }
        public bool IsKeyDown(string key)
        {
            KeyboardKey raylibKey = _keys[key.ToLower()];
            return Raylib.IsKeyDown(raylibKey);
        }

        public bool IsKeyUp(string key)
        {
            KeyboardKey raylibKey = _keys[key.ToLower()];
            return Raylib.IsKeyUp(raylibKey);
        }

    }
}
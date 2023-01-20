using System;
using Unit06.Game.Directing;
using Unit06.Game.Services;
using Unit06.Game.Casting;
using Unit06.Game.Scripting;

namespace Unit06
{
    class Program
    {
        static void Main(string[] args)
        {
            KeyboardService keyboardService = new KeyboardService();
            VideoService videoService = new VideoService(false);

            Script script = new Script();
            script.AddAction("output", new DrawActorsAction(videoService));

            Cast cast = new Cast();
            cast.AddActor("score", new Score());

            Director director = new Director(videoService);
            director.StartGame(cast, script);
        }
    }
}

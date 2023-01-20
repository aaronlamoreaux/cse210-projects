using System.Collections.Generic;
using Unit06.Game.Casting;
using Unit06.Game.Services;
using Unit06.Game.Scripting;


namespace Unit06.Game.Directing {
     public class Director
    {
        private VideoService _videoService = null;

        public Director(VideoService videoService)
        {
            this._videoService = videoService;
        }

         public void StartGame(Cast cast, Script script)
        {
            _videoService.OpenWindow();
            while (_videoService.IsWindowOpen())
            {
                ExecuteActions("input", cast, script);
                ExecuteActions("update", cast, script);
                ExecuteActions("output", cast, script);
            }
            _videoService.CloseWindow();
        }

         private void ExecuteActions(string group, Cast cast, Script script)
        {
            List<Action> actions = script.GetActions(group);
            foreach(Action action in actions)
            {
                action.Execute(cast, script);
            }
        }
    }
}
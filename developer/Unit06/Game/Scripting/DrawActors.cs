using System.Collections.Generic;
using Unit06.Game.Casting;
using Unit06.Game.Services;


namespace Unit06.Game.Scripting {
    public class DrawActorsAction : Action {
        private VideoService _videoService;

        public DrawActorsAction(VideoService videoService) {
            this._videoService = videoService;
        }

        public void Execute(Cast cast, Script script) {
            Actor score = cast.GetFirstActor("score");
            List<Actor> messages = cast.GetActors("messages");
            
            _videoService.ClearBuffer();
            _videoService.DrawActor(score);
            _videoService.DrawActors(messages);
            _videoService.FlushBuffer();
        }
    }
}
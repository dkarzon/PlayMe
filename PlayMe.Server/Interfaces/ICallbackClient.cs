﻿using System.Collections.Generic;
using PlayMe.Common.Model;

namespace PlayMe.Server.Interfaces
{
    public interface ICallbackClient
    {
        void TrackHistoryChanged(PagedResult<QueuedTrack> trackHistory);
        void QueueChanged(IEnumerable<QueuedTrack> notifyQueue);
        void PlayingTrackChanged(QueuedTrack track);
    }
}

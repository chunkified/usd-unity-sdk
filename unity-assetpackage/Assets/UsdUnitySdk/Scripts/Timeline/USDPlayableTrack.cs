﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;

namespace USD.NET.Unity.Extensions.Timeline {

#if UNITY_2017
  [TrackMediaType(TimelineAsset.MediaType.Script)]
#endif
  [TrackClipType(typeof(UsdPlayableAsset))]
  [TrackBindingType(typeof(StageRoot))]
  [TrackColor(0.1f, 0.2f, 0.8f)]
  [System.Serializable]
  public class UsdPlayableTrack : TrackAsset {

    protected override void OnAfterTrackDeserialize() {
      base.OnAfterTrackDeserialize();
    }

    protected override void OnBeforeTrackSerialize() {
      base.OnBeforeTrackSerialize();
    }

    protected override void OnCreateClip(TimelineClip clip) {
      base.OnCreateClip(clip);
      clip.displayName = clip.asset.name;
    }

  }
}
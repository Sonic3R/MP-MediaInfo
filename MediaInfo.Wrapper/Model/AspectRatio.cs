﻿#region Copyright (C) 2005-2020 Team MediaPortal

// Copyright (C) 2005-2020 Team MediaPortal
// http://www.team-mediaportal.com
// 
// MediaPortal is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 2 of the License, or
// (at your option) any later version.
// 
// MediaPortal is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with MediaPortal. If not, see <http://www.gnu.org/licenses/>.

#endregion

namespace MediaInfo.Model
{
  /// <summary>
  /// Describes video aspect ratio
  /// </summary>
  public enum AspectRatio
  {
    /// <summary>
    /// The opaque (1:1)
    /// </summary>
    Opaque,

    /// <summary>
    /// The high end data graphics (5:4)
    /// </summary>
    HighEndDataGraphics,

    /// <summary>
    /// The full screen (4:3)
    /// </summary>
    FullScreen,

    /// <summary>
    /// The standard slides (3:3)
    /// </summary>
    StandardSlides,

    /// <summary>
    /// The digital SLR cameras (3:2)
    /// </summary>
    DigitalSlrCameras,

    /// <summary>
    /// The High Definition TV (16:9)
    /// </summary>
    HighDefinitionTv,

    /// <summary>
    /// The wide screen display (16:10)
    /// </summary>
    WideScreenDisplay,

    /// <summary>
    /// The wide screen (1.85:1)
    /// </summary>
    WideScreen,

    /// <summary>
    /// The cinema scope (21:9)
    /// </summary>
    CinemaScope
  }
}
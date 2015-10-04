﻿//=================================================================================================
// Copyright 2013-2015 Dirk Lemstra <https://magick.codeplex.com/>
//
// Licensed under the ImageMagick License (the "License"); you may not use this file except in 
// compliance with the License. You may obtain a copy of the License at
//
//   http://www.imagemagick.org/script/license.php
//
// Unless required by applicable law or agreed to in writing, software distributed under the
// License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
// express or implied. See the License for the specific language governing permissions and
// limitations under the License.
//=================================================================================================

namespace ImageMagick
{
  ///<summary>
  /// Specifies the pixel storage types.
  ///</summary>
  public enum StorageType
  {
    /// <summary>
    /// Undefined
    /// </summary>
    Undefined,

    /// <summary>
    /// Char
    /// </summary>
    Char,

    /// <summary>
    /// Double
    /// </summary>
    Double,

    /// <summary>
    /// Float
    /// </summary>
    Float,

    /// <summary>
    /// Long
    /// </summary>
    Long,

    /// <summary>
    /// LongLong
    /// </summary>
    LongLong,

    /// <summary>
    /// Quantum
    /// </summary>
    Quantum,

    /// <summary>
    /// Short
    /// </summary>
    Short
  }
}
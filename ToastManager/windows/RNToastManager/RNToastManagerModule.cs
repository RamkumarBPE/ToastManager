using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Toast.Manager.RNToastManager
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNToastManagerModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNToastManagerModule"/>.
        /// </summary>
        internal RNToastManagerModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNToastManager";
            }
        }
    }
}

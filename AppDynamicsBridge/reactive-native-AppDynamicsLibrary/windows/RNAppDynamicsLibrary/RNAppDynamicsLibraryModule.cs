using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace App.Dynamics.Library.RNAppDynamicsLibrary
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNAppDynamicsLibraryModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNAppDynamicsLibraryModule"/>.
        /// </summary>
        internal RNAppDynamicsLibraryModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNAppDynamicsLibrary";
            }
        }
    }
}

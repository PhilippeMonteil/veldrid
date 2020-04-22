using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

using Veldrid;

namespace Veldrid.Android
{

    public static class GraphicsDeviceFactory
    {
        public static GraphicsDevice CreateOpenGL(
            GraphicsDeviceOptions options,
            OpenGL.OpenGLPlatformInfo platformInfo,
            uint width,
            uint height)
        {
            return new OpenGL.OpenGLGraphicsDevice(options, platformInfo, width, height);
        }

        public static GraphicsDevice CreateOpenGLES(
            GraphicsDeviceOptions options,
            SwapchainDescription swapchainDescription)
        {
            return new OpenGL.OpenGLGraphicsDevice(options, swapchainDescription);
        }

    }

}

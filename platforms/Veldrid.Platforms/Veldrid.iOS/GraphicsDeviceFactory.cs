using System;
using System.Collections.Generic;
using System.Text;

using Veldrid;

namespace Veldrid.MTL
{

    public static class GraphicsDeviceFactory
    {

        public static GraphicsDevice CreateMetal(GraphicsDeviceOptions options)
        {
            return new MTL.MTLGraphicsDevice(options, null);
        }

        public static GraphicsDevice CreateMetal(GraphicsDeviceOptions options, SwapchainDescription swapchainDescription)
        {
            return new MTL.MTLGraphicsDevice(options, swapchainDescription);
        }

        public static GraphicsDevice CreateMetal(GraphicsDeviceOptions options, IntPtr nsWindow)
        {
            SwapchainDescription swapchainDesc = new SwapchainDescription(
                new NSWindowSwapchainSource(nsWindow),
                0, 0,
                options.SwapchainDepthFormat,
                options.SyncToVerticalBlank,
                options.SwapchainSrgbFormat);

            return new MTL.MTLGraphicsDevice(options, swapchainDesc);
        }

    }

}

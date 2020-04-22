using System;
using System.Collections.Generic;
using System.Text;

using Veldrid;

namespace Veldrid.D3D11
{

    public static class GraphicsDeviceFactory
    {

        public static GraphicsDevice CreateD3D11(GraphicsDeviceOptions options)
        {
            return new D3D11.D3D11GraphicsDevice(options, new D3D11DeviceOptions(), null);
        }

        public static GraphicsDevice CreateD3D11(GraphicsDeviceOptions options, SwapchainDescription swapchainDescription)
        {
            return new D3D11.D3D11GraphicsDevice(options, new D3D11DeviceOptions(), swapchainDescription);
        }

        public static GraphicsDevice CreateD3D11(GraphicsDeviceOptions options, D3D11DeviceOptions d3d11Options)
        {
            return new D3D11.D3D11GraphicsDevice(options, d3d11Options, null);
        }

        public static GraphicsDevice CreateD3D11(GraphicsDeviceOptions options, D3D11DeviceOptions d3d11Options, SwapchainDescription swapchainDescription)
        {
            return new D3D11.D3D11GraphicsDevice(options, d3d11Options, swapchainDescription);
        }

        public static GraphicsDevice CreateD3D11(GraphicsDeviceOptions options, IntPtr hwnd, uint width, uint height)
        {
            SwapchainDescription swapchainDescription = new SwapchainDescription(
                SwapchainSource.CreateWin32(hwnd, IntPtr.Zero),
                width, height,
                options.SwapchainDepthFormat,
                options.SyncToVerticalBlank,
                options.SwapchainSrgbFormat);

            return new D3D11.D3D11GraphicsDevice(options, new D3D11DeviceOptions(), swapchainDescription);
        }

        public static GraphicsDevice CreateD3D11(
            GraphicsDeviceOptions options,
            object swapChainPanel,
            double renderWidth,
            double renderHeight,
            float logicalDpi)
        {
            SwapchainDescription swapchainDescription = new SwapchainDescription(
                SwapchainSource.CreateUwp(swapChainPanel, logicalDpi),
                (uint)renderWidth,
                (uint)renderHeight,
                options.SwapchainDepthFormat,
                options.SyncToVerticalBlank,
                options.SwapchainSrgbFormat);

            return new D3D11.D3D11GraphicsDevice(options, new D3D11DeviceOptions(), swapchainDescription);
        }

    }
}

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
using Veldrid.Vk;

namespace Veldrid.Vk
{

    public static class GraphicsDeviceFactory
    {

        public static GraphicsDevice CreateVulkan(GraphicsDeviceOptions options)
        {
            return new Vk.VkGraphicsDevice(options, null);
        }

        /// <summary>
        /// Creates a new <see cref="GraphicsDevice"/> using Vulkan.
        /// </summary>
        /// <param name="options">Describes several common properties of the GraphicsDevice.</param>
        /// <param name="vkOptions">The Vulkan-specific options used to create the device.</param>
        /// <returns>A new <see cref="GraphicsDevice"/> using the Vulkan API.</returns>
        public static GraphicsDevice CreateVulkan(GraphicsDeviceOptions options, VulkanDeviceOptions vkOptions)
        {
            return new Vk.VkGraphicsDevice(options, null, vkOptions);
        }

        /// <summary>
        /// Creates a new <see cref="GraphicsDevice"/> using Vulkan, with a main Swapchain.
        /// </summary>
        /// <param name="options">Describes several common properties of the GraphicsDevice.</param>
        /// <param name="swapchainDescription">A description of the main Swapchain to create.</param>
        /// <returns>A new <see cref="GraphicsDevice"/> using the Vulkan API.</returns>
        public static GraphicsDevice CreateVulkan(GraphicsDeviceOptions options, SwapchainDescription swapchainDescription)
        {
            return new Vk.VkGraphicsDevice(options, swapchainDescription);
        }

        /// <summary>
        /// Creates a new <see cref="GraphicsDevice"/> using Vulkan, with a main Swapchain.
        /// </summary>
        /// <param name="options">Describes several common properties of the GraphicsDevice.</param>
        /// <param name="vkOptions">The Vulkan-specific options used to create the device.</param>
        /// <param name="swapchainDescription">A description of the main Swapchain to create.</param>
        /// <returns>A new <see cref="GraphicsDevice"/> using the Vulkan API.</returns>
        public static GraphicsDevice CreateVulkan(
            GraphicsDeviceOptions options,
            SwapchainDescription swapchainDescription,
            VulkanDeviceOptions vkOptions)
        {
            return new Vk.VkGraphicsDevice(options, swapchainDescription, vkOptions);
        }

        /// <summary>
        /// Creates a new <see cref="GraphicsDevice"/> using Vulkan, with a main Swapchain.
        /// </summary>
        /// <param name="options">Describes several common properties of the GraphicsDevice.</param>
        /// <param name="surfaceSource">The source from which a Vulkan surface can be created.</param>
        /// <param name="width">The initial width of the window.</param>
        /// <param name="height">The initial height of the window.</param>
        /// <returns>A new <see cref="GraphicsDevice"/> using the Vulkan API.</returns>
        public static GraphicsDevice CreateVulkan(GraphicsDeviceOptions options, Vk.VkSurfaceSource surfaceSource, uint width, uint height)
        {
            SwapchainDescription scDesc = new SwapchainDescription(
                surfaceSource.GetSurfaceSource(),
                width, height,
                options.SwapchainDepthFormat,
                options.SyncToVerticalBlank,
                options.SwapchainSrgbFormat);

            return new Vk.VkGraphicsDevice(options, scDesc);
        }

    }

}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

using Veldrid;
using System.Diagnostics;

namespace Test0
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void bnTest_Clicked(object sender, EventArgs e)
        {
            try
            {
                GraphicsDevice gd = aVeldridView.VeldridView0Renderer.GraphicsDevice; ;
                ResourceFactory factory = gd.ResourceFactory;

                CommandList copyCL = factory.CreateCommandList();
                copyCL.Begin();
                copyCL.End();

                gd.SubmitCommands(copyCL);
            }
            catch (Exception E)
            {
                Debug.WriteLine($"Exception={E.Message} <<{E.StackTrace}>>");
            }

        }
    }
}

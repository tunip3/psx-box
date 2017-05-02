using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.Storage;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Core;
using System.Runtime.InteropServices;


// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace PSX_BOX_UI
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {


        // Use P_Invoke so PSXACT Library can be used 
        class NativeMethods
        {
            [DllImport("psxact", EntryPoint = "init")]
            public static extern IntPtr Create();

            [DllImport("psxact", EntryPoint = "run_for_one_frame")]
            public static extern void RunForOneFrame(IntPtr handle);
        }

 



    public MainPage()
        {
            this.InitializeComponent();
            

            // Handling Page Back navigation behaviors
            SystemNavigationManager.GetForCurrentView().BackRequested +=
                SystemNavigationManager_BackRequested;


    }


        // Using systemnavmanager to allow navigation with Xbox Controller
        private void SystemNavigationManager_BackRequested(
    object sender,
    BackRequestedEventArgs e)
        {
            if (!e.Handled)
            {
                e.Handled = this.BackRequested();
            }
        }


        public Frame AppFrame { get { return this.Frame; } }

        private bool BackRequested()
        {
            // Get a hold of the current frame so that we can inspect the app back stack
            if (this.AppFrame == null)
                return false;

            // Check to see if this is the top-most page on the app back stack
            if (this.AppFrame.CanGoBack)
            {
                // If not, set the event to handled and go back to the previous page in the
                // app.
                this.AppFrame.GoBack();
                return true;
            }
            return false;
        }



        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            // Uses Media element to say a special message when the license button is clicked
            MediaElement mediaElement = new MediaElement();
            var synth = new Windows.Media.SpeechSynthesis.SpeechSynthesizer();
            Windows.Media.SpeechSynthesis.SpeechSynthesisStream stream = await synth.SynthesizeTextToStreamAsync("Pee s ex box is free software licensed under the GNU General Public Licesense Version 3. ");
            mediaElement.SetSource(stream, stream.ContentType);
            mediaElement.Play();
        }

        private async void Button_Click_1(object sender, RoutedEventArgs e)
        {
            // Uses Media element to say a special message when the about button is clicked
            MediaElement mediaElement = new MediaElement();
            var synth = new Windows.Media.SpeechSynthesis.SpeechSynthesizer();
            Windows.Media.SpeechSynthesis.SpeechSynthesisStream stream = await synth.SynthesizeTextToStreamAsync("pee s ex box is a playstation one emulator developed specifically for the xbox one platform. It was the result of a co lab rotive effort between various members of the online community");
            mediaElement.SetSource(stream, stream.ContentType);
            mediaElement.Play();
        }

        private async void Button_Click_2(object sender, RoutedEventArgs e)
        {
            // Uses File Picker to Import a Game
            var picker = new Windows.Storage.Pickers.FileOpenPicker();
            picker.ViewMode = Windows.Storage.Pickers.PickerViewMode.Thumbnail;
            picker.SuggestedStartLocation = Windows.Storage.Pickers.PickerLocationId.DocumentsLibrary;
            picker.FileTypeFilter.Add(".bin");
            Windows.Storage.StorageFile file = await picker.PickSingleFileAsync();

            if (file != null)
            {


            }
        }

        
        private async void Button_Click_3(object sender, RoutedEventArgs e)
        {


            // Uses File Picker to import the scph1001.bin bios
            var picker = new Windows.Storage.Pickers.FileOpenPicker();
            picker.ViewMode = Windows.Storage.Pickers.PickerViewMode.Thumbnail;
            picker.SuggestedStartLocation = Windows.Storage.Pickers.PickerLocationId.DocumentsLibrary;
            picker.FileTypeFilter.Add(".bin");
            Windows.Storage.StorageFile file = await picker.PickSingleFileAsync();

            if (file != null)
            {

                // Application now has read/write access to the picked file
                

            }

        }

        private async void Button_Click_4(object sender, RoutedEventArgs e)
        {

            // Uses File Picker to export a file
            var picker = new Windows.Storage.Pickers.FileOpenPicker();
            picker.ViewMode = Windows.Storage.Pickers.PickerViewMode.Thumbnail;
            picker.SuggestedStartLocation = Windows.Storage.Pickers.PickerLocationId.DocumentsLibrary;
            picker.FileTypeFilter.Add(".bin");
            Windows.Storage.StorageFile file = await picker.PickSingleFileAsync();

            if (file != null)
            {

               


            }

        }

      
    }
}

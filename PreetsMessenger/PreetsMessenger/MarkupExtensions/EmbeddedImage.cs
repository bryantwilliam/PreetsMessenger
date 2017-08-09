using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PreetsMessenger
{
    [ContentProperty("ResourcePath")]
    class EmbeddedImage : IMarkupExtension
    {
        public string ResourcePath { get; set; }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (String.IsNullOrWhiteSpace(ResourcePath)) return null;
            Debug.WriteLine("Resource: " + ImageSource.FromResource(ResourcePath));
            return ImageSource.FromResource(ResourcePath);
        }
    }
}
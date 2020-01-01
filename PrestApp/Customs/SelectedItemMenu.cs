using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace PrestApp.Shared.Customs
{
    public class SelectedItemMenu : ViewCell
    {
        public static readonly BindableProperty SelectedBackgroundColorProperty =
            BindableProperty.Create("SelectedBackgroundColor",
                                    typeof(Color),
                                    typeof(SelectedItemMenu),
                                    Color.Default);

        public Color SelectedBackgroundColor
        {
            get { return (Color)GetValue(SelectedBackgroundColorProperty); }
            set { SetValue(SelectedBackgroundColorProperty, value); }
        }
    }
}
